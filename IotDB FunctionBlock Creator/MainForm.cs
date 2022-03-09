using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IotDB_FunctionBlock_Creator
{
    public partial class MainForm : Form
    {
        private string CLI_PATH = Application.StartupPath + @"\sbin\cli.bat";
        private string BAT_PATH = Application.StartupPath + @"\sbin\bat";
        private string DEFINE = "void *handle = dlopen(\"/home/CASS-ePLC/libiotdbclient.so\", RTLD_LAZY);        Query query = (Query)dlsym(handle, \"_Z5queryPhS_PlS_\");        dlclose(handle);";
        private string DEFINE_W = "void *handle = dlopen(\"/home/CASS-ePLC/libiotdbclient.so\", RTLD_LAZY);        InsertRecord insertRecord = (InsertRecord)dlsym(handle, \"_Z12insertRecordlPhS_S_\");        dlclose(handle);";
        private string CODES = "if(FB->Start==0&&FB->Execute==1){        ";
        private string CODEM = "query((Uint8*)\"device\",(Uint8*)\"measurement\",(long*)FB->timestamp,FB->value);        ";
        private string CODEM_W = "insertRecord(FB->timestamp,(Uint8*)\"device\",(Uint8*)\"measurement\",FB->value);        ";
        private string CODEE = "FB->Done=1;}    FB->Start=FB->Execute;";
        private DataTable dt = new DataTable();
        private List<TimeSeries> timeSeries = new List<TimeSeries>();
        private FunctionBlockGroup fbg = new FunctionBlockGroup("iotdb", "时序数据库");
        private int plusi = 0;  //用于读取数据库的一个计数
        private int funcindex = 0;  //获取点击列表的序号
        private bool menu = false;  //列表是否已打开
        private System.Drawing.Size lastsize;

        public MainForm()
        {
            InitializeComponent();
            //初始化表格
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dt.Columns.Add("check", Type.GetType("System.Boolean"));
            dt.Columns.Add("ti", Type.GetType("System.String"));
            dt.Columns.Add("al", Type.GetType("System.String"));
            dt.Columns.Add("sg", Type.GetType("System.String"));
            dt.Columns.Add("dt", Type.GetType("System.String"));
            dt.Columns.Add("en", Type.GetType("System.String"));
            dt.Columns.Add("co", Type.GetType("System.String"));
            dt.Columns.Add("ta", Type.GetType("System.String"));
            dt.Columns.Add("at", Type.GetType("System.String"));
            contextList.Visible = false;
            lastsize = Size;
        }

        public void ExcuteBAT(string path)
        {
            //调用bat脚本
            try
            {
                plusi = 0;
                dt.Clear();
                timeSeries.Clear();
                dataGridView.DataSource = null;
                Process p = new Process();
                StreamWriter sw;
                string cmd = "show timeseries";
                p.StartInfo.FileName = path;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = false;
                p.StartInfo.CreateNoWindow = true;
                p.OutputDataReceived += new DataReceivedEventHandler(batOutput);
                p.Start();
                sw = p.StandardInput;
                p.BeginOutputReadLine();
                if (!String.IsNullOrEmpty(cmd))
                {
                    sw.WriteLine(cmd);
                }
                sw.WriteLine("exit");
                sw.Close();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void batOutput(object sender, DataReceivedEventArgs e)
        {
            //bat输出数据事件
            if (!String.IsNullOrEmpty(e.Data))
            {
                if (e.Data.StartsWith("+"))
                {
                    plusi++;
                }
                DGVDataTableSet();
                if (plusi == 2 && !e.Data.StartsWith("+"))
                {
                    TimeSeries ts = new TimeSeries(e.Data);
                    timeSeries.Add(ts);
                    dt.Rows.Add(ts.ToDataRow(dt));
                }
            }
        }

        public void DGVDataTableSet()
        {
            //更新表格数据
            BeginInvoke(new Action(() =>
            {
                dataGridView.DataSource = dt;
                dataGridView.Columns[0].DataPropertyName = "check";
                dataGridView.Columns[1].DataPropertyName = "ti";
                dataGridView.Columns[2].DataPropertyName = "al";
                dataGridView.Columns[3].DataPropertyName = "sg";
                dataGridView.Columns[4].DataPropertyName = "dt";
                dataGridView.Columns[5].DataPropertyName = "en";
                dataGridView.Columns[6].DataPropertyName = "co";
                dataGridView.Columns[7].DataPropertyName = "ta";
                dataGridView.Columns[8].DataPropertyName = "at";
            }));
        }

        public List<int> GetDGVIndex()
        {
            //获取选中的行数序号
            List<int> index = new List<int>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value))
                    index.Add(i);
            }
            return index;
        }

        public bool CreateBAT(string ip, string port, string user, string password)
        {
            //从模板创建bat脚本
            if (ip != "" && port != "" && user != "" && password != "")
            {
                StreamReader sr = new StreamReader(BAT_PATH);
                string bat = sr.ReadToEnd();
                bat = bat.Replace("@@@@@@", password).Replace("@@@@@", user).Replace("@@@@", port).Replace("@@@", ip);
                if (File.Exists(CLI_PATH))
                {
                    File.Delete(CLI_PATH);
                }
                StreamWriter srw = new StreamWriter(CLI_PATH);
                srw.Write(bat);
                sr.Close();
                srw.Close();
                return true;
            }
            else
            {
                MessageBox.Show("请先填写IotDB登录信息！");
                return false;
            }
        }

        public bool FuzzyCompare(string strlong, string strshort)
        {
            //模糊比对
            int t = 0;
            int count = 0;
            foreach(char c in strshort)
            {
                for (; t < strlong.Length; t++) 
                {
                    if(strlong.ToCharArray()[t]==c)
                    {
                        count++;
                        break;
                    }
                }
            }
            if(count==strshort.Length)
            {
                return true;
            }
            return false;
        }

        public void SearchSort(string name, bool fuzzy, bool upper)
        {
            //搜索排序,先传感器后路径，模糊，大小写 
            List<int> sort = new List<int>();
            List<TimeSeries> ts = new List<TimeSeries>(timeSeries);
            int[] searched = new int[timeSeries.Count];
            for (int i = 0; i < timeSeries.Count; i++)
            {
                searched[i] = 0;
            }
            //1.搜索            
            if (!fuzzy)
            {
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (timeSeries[i].GetMeasurement() == name && searched[i] == 0)    //和传感器一致
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (timeSeries[i].GetMeasurement().ToLower() == name.ToLower() && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (timeSeries[i].GetMeasurement().Contains(name) && searched[i] == 0)  //传感器包含
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (timeSeries[i].GetMeasurement().ToLower().Contains(name.ToLower()) && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (timeSeries[i].timeseries.Contains(name) && searched[i] == 0)    //全名包含
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (timeSeries[i].timeseries.ToLower().Contains(name.ToLower()) && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (timeSeries[i].ToString().Contains(name) && searched[i] == 0)    //全信息包含
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (timeSeries[i].ToString().ToLower().Contains(name.ToLower()) && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
            }
            //1.5.模糊搜索
            else
            {
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (FuzzyCompare(timeSeries[i].timeseries, name) && searched[i] == 0)    //全名包含
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (FuzzyCompare(timeSeries[i].timeseries.ToLower(), name.ToLower()) && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < timeSeries.Count; i++)
                {
                    if (FuzzyCompare(timeSeries[i].ToString(), name) && searched[i] == 0)    //全信息包含
                    {
                        sort.Add(i);
                        searched[i] = 1;
                    }
                    if (!upper)
                    {
                        if (FuzzyCompare(timeSeries[i].ToString().ToLower(), name.ToLower()) && searched[i] == 0)
                        {
                            sort.Add(i);
                            searched[i] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < timeSeries.Count; i++)
            {
                if (searched[i] == 0)     //剩余项
                {
                    sort.Add(i);
                    searched[i] = 1;
                }
            }
            //2.排序
            timeSeries.Clear();
            dataGridView.DataSource = null;
            dt.Rows.Clear();
            for (int i = 0; i < ts.Count; i++)
            {
                int index = sort[i];
                timeSeries.Add(ts[index]);
                dt.Rows.Add(ts[index].ToDataRow(dt));
            }
            dataGridView.DataSource = dt;
            dataGridView.Refresh();
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
        }

        public void FreshContextList()
        {
            //刷新列表显示
            contextList.Close();
            contextList.Show(buttonList, -(contextList.Size.Width - buttonList.Size.Width), -contextList.Size.Height);
            menu = true;
        }

        private void buttonBAT_Click(object sender, EventArgs e)
        {
            //调用bat脚本获取时间序列
            try
            {
                bool ret = CreateBAT(textBoxip.Text.Trim(), textBoxport.Text.Trim(), textBoxuser.Text.Trim(), textBoxpw.Text.Trim());
                if (ret)
                {
                    ExcuteBAT(CLI_PATH);
                    if (dt.Rows.Count != 0)
                    {
                        dataGridView.Refresh();
                        dataGridView.ClearSelection();
                        dataGridView.CurrentCell = null;
                        labeltext.Text = "已登录IotDB服务器" + textBoxip.Text.Trim() + ":" + textBoxport.Text.Trim() + "，共有" + dt.Rows.Count + "项时间序列。";
                    }
                    else if(plusi==3)
                    {
                        MessageBox.Show("数据库中没有已创建的时间序列！");
                    }
                    else if(plusi==0)
                    {
                        MessageBox.Show("IotDB服务器登陆失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            //保存为xml
            if (fbg.count > 1)
            {
                string path = Application.StartupPath + @"\FunctionBlock.xml";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Application.StartupPath;
                saveFileDialog.FileName = "FunctionBlock.xml";
                saveFileDialog.Filter = "XML文件|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    fbg.SaveAsXml(path);
                    MessageBox.Show("生成xml文件成功！");
                    labeltext.Text = "已生成xml文件，保存在" + path;
                }
            }
            else
            {
                MessageBox.Show("现在还未添加任何功能块！");
            }
        }

        private void buttonAddFB_Click(object sender, EventArgs e)
        {
            //把选中的时间序列保存为读功能块
            var index = GetDGVIndex();
            if (index.Count > 0)
            {
                NameForm nf = new NameForm();
                if (nf.ShowDialog() == DialogResult.OK)
                {
                    FunctionBlock fb = new FunctionBlock(nf.name);
                    string code = CODES;
                    fb.AddSpecialVars();
                    if (!nf.eachtimestamp)
                    {
                        fb.AddTimestampVars(true);
                    }
                    foreach (int i in index) 
                    {
                        if (nf.eachtimestamp)
                        {
                            fb.AddVarT(timeSeries[i].getVar());
                            code += CODEM.Replace("device", timeSeries[i].GetDevice()).Replace("measurement", timeSeries[i].GetMeasurement()).Replace("timestamp",
                                timeSeries[i].timeseries.Replace(".", "_") + "T").Replace("value", timeSeries[i].timeseries.Replace(".", "_"));
                        }
                        else
                        {
                            code += CODEM.Replace("device", timeSeries[i].GetDevice()).Replace("measurement", timeSeries[i].GetMeasurement()).Replace("value", timeSeries[i].timeseries.Replace(".", "_"));
                        }
                        fb.AddVar(timeSeries[i].getVar());
                    }
                    code += CODEE;
                    fb.SetCCode(DEFINE, code);
                    fbg.AddFuncBlock(fb);
                    ToolStripMenuItem toolStrip = new ToolStripMenuItem();
                    toolStrip.Text = fb.ToString();
                    toolStrip.Click += new EventHandler(toolStripMenuItem_Click);
                    contextList.Items.Add(toolStrip);
                    FreshContextList();
                }
            }
            else
            {
                MessageBox.Show("请先选择至少一个时间序列！");
            }
        }

        private void buttonAddWFB_Click(object sender, EventArgs e)
        {
            //把选中的时间序列保存为写功能块
            var index = GetDGVIndex();
            if (index.Count > 0)
            {
                NameForm nf = new NameForm();
                if (nf.ShowDialog() == DialogResult.OK)
                {
                    FunctionBlock fb = new FunctionBlock(nf.name);
                    string code = CODES;
                    fb.AddSpecialVars();
                    if (!nf.eachtimestamp)
                    {
                        fb.AddTimestampVars(false);
                    }
                    foreach (int i in index)
                    {
                        if (nf.eachtimestamp)
                        {
                            fb.AddVarT(timeSeries[i].getVar(false));
                            code += CODEM_W.Replace("device", timeSeries[i].GetDevice()).Replace("measurement", timeSeries[i].GetMeasurement()).Replace("timestamp",
                                timeSeries[i].timeseries.Replace(".", "_") + "T").Replace("value", timeSeries[i].timeseries.Replace(".", "_"));
                        }
                        else
                        {
                            code += CODEM_W.Replace("device", timeSeries[i].GetDevice()).Replace("measurement", timeSeries[i].GetMeasurement()).Replace("value", timeSeries[i].timeseries.Replace(".", "_"));
                        }
                        fb.AddVar(timeSeries[i].getVar(false));
                    }
                    code += CODEE;
                    fb.SetCCode(DEFINE_W, code);
                    fbg.AddFuncBlock(fb);
                    ToolStripMenuItem toolStrip = new ToolStripMenuItem();
                    toolStrip.Text = fb.ToString();
                    toolStrip.Click += new EventHandler(toolStripMenuItem_Click);
                    contextList.Items.Add(toolStrip);
                    FreshContextList();
                }
            }
            else
            {
                MessageBox.Show("请先选择至少一个时间序列！");
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            //显示已经添加的功能块信息
            if (contextList.Visible == false)
            {
                contextList.Show(Location);
                contextList.Close();
                contextList.Visible = true;
            }
            if (!menu)
            {
                contextList.Show(buttonList, -(contextList.Size.Width - buttonList.Size.Width), -contextList.Size.Height);
                menu = true;
            }
            else
            {
                contextList.Close();
                menu = false;
            }
        }

        private void toolStripMenuIteminfo_Click(object sender, EventArgs e)
        {
            //查看功能块详细信息
            MessageBox.Show(fbg.GetInfo(funcindex), "功能块详细信息");
        }

        private void toolStripMenuItemdelete_Click(object sender, EventArgs e)
        {
            //删除功能块
            fbg.DeleteFuncBlock(funcindex);
            contextList.Items.Remove(contextList.Items[funcindex]);
            FreshContextList();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击功能块的行为
            funcindex = contextList.Items.IndexOf((ToolStripItem)sender);
            contextListMenu.Show(MousePosition);
        }

        private void buttoncsv_Click(object sender, EventArgs e)
        {
            //将时间序列表格导出为csv文件
            string path = Application.StartupPath + @"\TimeSeries.csv";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.FileName = "TimeSeries.csv";
            saveFileDialog.Filter = "CSV文件|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string data = "";
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    data += dataGridView.Columns[i].HeaderText;
                    if (i < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    data = "";
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        data += dt.Rows[i][j].ToString();
                        if (j < dt.Columns.Count - 1)
                        {
                            data += ",";
                        }
                    }
                    sw.WriteLine(data);
                }
                sw.Close();
                MessageBox.Show("导出csv文件成功！");
                labeltext.Text = "csv文件已导出到" + path;
            }

        }

        private void buttonselectall_Click(object sender, EventArgs e)
        {
            //全选时间序列
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void buttonclearselect_Click(object sender, EventArgs e)
        {
            //清除时间序列的选择
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //调整控件位置
            System.Drawing.Size delta = Size - lastsize;
            lastsize = Size;
            dataGridView.Size += delta;
            paneldown.Location = new System.Drawing.Point(paneldown.Location.X, paneldown.Location.Y + delta.Height);
            paneldown.Size = new System.Drawing.Size(paneldown.Size.Width + delta.Width, paneldown.Size.Height);
            groupBoxlogin.Location = new System.Drawing.Point(groupBoxlogin.Location.X + delta.Width, groupBoxlogin.Location.Y);
            buttonAddFB.Location = new System.Drawing.Point(buttonAddFB.Location.X + delta.Width, buttonAddFB.Location.Y);
            buttonAddWFB.Location = new System.Drawing.Point(buttonAddWFB.Location.X + delta.Width, buttonAddWFB.Location.Y);
            buttonBAT.Location = new System.Drawing.Point(buttonBAT.Location.X + delta.Width, buttonBAT.Location.Y);
            buttoncsv.Location = new System.Drawing.Point(buttoncsv.Location.X + delta.Width, buttoncsv.Location.Y);
            buttonXML.Location = new System.Drawing.Point(buttonXML.Location.X + delta.Width, buttonXML.Location.Y);
            buttonList.Location = new System.Drawing.Point(buttonList.Location.X + delta.Width, buttonList.Location.Y);
            labeltext.Size = new System.Drawing.Size(labeltext.Size.Width + delta.Width, labeltext.Size.Height);
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            //显示搜索窗口
            Search search = new Search(this);
            search.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            //显示关于窗口
            About about = new About();
            about.ShowDialog();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            //失去焦点后关闭列表
            menu = false;
            contextList.Close();
        }
    }
}
