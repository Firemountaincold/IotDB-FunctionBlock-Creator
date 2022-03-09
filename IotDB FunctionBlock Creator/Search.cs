using System;
using System.Windows.Forms;

namespace IotDB_FunctionBlock_Creator
{
    public partial class Search : Form
    {
        private readonly MainForm main;
        private const int WM_NCITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public Search(MainForm mf)
        {
            InitializeComponent();
            main = mf;

            string info = "模糊搜索是指可以使用缩写的字母来搜索全称，如使用“abc”搜索“aaabbbccc”。";
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(checkBoxFuzzy, info);
        }

        public void SearchOnce()
        {
            //搜索一次
            main.SearchSort(textBox.Text, checkBoxFuzzy.Checked, checkBoxUpper.Checked);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //搜索按钮，输入一个字触发一次
            SearchOnce();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            //关闭搜索框
            Close();
        }

        protected override void WndProc(ref Message m)
        {
            //重写消息，使用户可以移动窗口
            if (m.Msg == WM_NCITTEST)
            {
                base.WndProc(ref m);
                if ((int)m.Result == HTCLIENT)
                {
                    m.Result = (IntPtr)HTCAPTION;
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //触发搜索
            SearchOnce();
        }

        private void checkBoxFuzzy_CheckedChanged(object sender, EventArgs e)
        {
            //触发搜索
            SearchOnce();
        }

        private void checkBoxUpper_CheckedChanged(object sender, EventArgs e)
        {
            //触发搜索
            SearchOnce();
        }
    }
}
