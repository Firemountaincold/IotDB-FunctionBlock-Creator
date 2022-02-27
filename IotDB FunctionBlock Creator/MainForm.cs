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
        private DataTable dt = new DataTable();
        private List<TimeSeries> timeSeries = new List<TimeSeries>();
        FunctionBlockGroup fbg = new FunctionBlockGroup("iotdb", "时序数据库");
        private int plusi = 0;
        private int funcindex = 0;
        private bool menu = false;

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
        }

        public void ExcuteBAT(string path)
        {
            //调用bat脚本
            try
            {
                dt.Clear();
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
                plusi = 0;
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

        private void buttonBAT_Click(object sender, EventArgs e)
        {
            //调用bat脚本获取时间序列
            try
            {
                bool ret = CreateBAT(textBoxip.Text.Trim(), textBoxport.Text.Trim(), textBoxuser.Text.Trim(), textBoxpw.Text.Trim());
                if (ret)
                {
                    ExcuteBAT(CLI_PATH);
                    dataGridView.Refresh();
                    dataGridView.ClearSelection();
                    dataGridView.CurrentCell = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            //保存为xml
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
            }
        }

        private void buttonAddFB_Click(object sender, EventArgs e)
        {
            //把选中的时间序列保存为功能块
            var index = GetDGVIndex();
            if (index.Count > 0)
            {
                FunctionBlock fb = new FunctionBlock("iotdb");
                foreach (int i in index)
                {
                    fb.AddVar(timeSeries[i].getVar());
                }
                fbg.AddFuncBlock(fb);
                ToolStripMenuItem toolStrip = new ToolStripMenuItem();
                toolStrip.Text = fb.ToString();
                toolStrip.Click += new EventHandler(toolStripMenuItem_Click);
                contextList.Items.Add(toolStrip);
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
            MessageBox.Show(fbg.GetInfo(funcindex));
        }

        private void toolStripMenuItemdelete_Click(object sender, EventArgs e)
        {
            //删除功能块
            fbg.DeleteFuncBlock(funcindex);
            contextList.Items.Remove(contextList.Items[funcindex]);
            contextList.Close();
            contextList.Show(buttonList, -(contextList.Size.Width - buttonList.Size.Width), -contextList.Size.Height);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击功能块的行为
            funcindex = contextList.Items.IndexOf((ToolStripItem)sender);
            contextListMenu.Show(MousePosition);
        }
    }
}
