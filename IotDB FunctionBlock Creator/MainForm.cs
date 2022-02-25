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
        private DataTable dt = new DataTable();
        private List<TimeSeries> timeSeries = new List<TimeSeries>();
        private Process p = new Process();
        private StreamWriter sw;
        private int i = 0;

        public MainForm()
        {
            InitializeComponent();
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
        }

        public void ExcuteBAT(string path)
        {
            //调用bat脚本
            try
            {
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
                i = 0;
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
                    i++;
                }
                if (i == 2 && !e.Data.StartsWith("+"))
                {
                    TimeSeries ts = new TimeSeries(e.Data);
                    timeSeries.Add(ts);
                    dt.Rows.Add(ts.ToDataRow(dt));
                    DGVDataTableSet();
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

        private void buttonBAT_Click(object sender, EventArgs e)
        {
            //调用bat脚本获取时间序列
            ExcuteBAT(@"E:\Iotdb\apache-iotdb-0.12.3-server-bin\apache-iotdb-0.12.3-server-bin\sbin\start-cli-linux.bat");
            dataGridView.Refresh();
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            //把选中的时间序列保存为功能块xml
            var index = GetDGVIndex();
            if (index.Count > 0)
            {
                FunctionBlockGroup fbg = new FunctionBlockGroup("iotdb", "时序数据库");
                FunctionBlock fb = new FunctionBlock("iotdb");
                foreach (int i in index)
                {
                    fb.AddVar(timeSeries[i].getVar());
                }
                fbg.AddFuncBlock(fb);
                fbg.SaveAsXml(@"E:\Iotdb\a.xml");
                MessageBox.Show("生成xml文件成功！");
            }
            else
            {
                MessageBox.Show("请先选择至少一个时间序列！");
            }
        }
    }
}
