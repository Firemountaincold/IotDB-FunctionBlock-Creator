using System;
using System.Windows.Forms;

namespace IotDB_FunctionBlock_Creator
{
    public partial class NameForm : Form
    {
        public string name = "iotdb";
        public bool eachtimestamp = false;

        public NameForm()
        {
            InitializeComponent();
            textBoxname.Text = name;
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            //选择确认
            name = textBoxname.Text;
            eachtimestamp = checkBox.Checked;
            DialogResult = DialogResult.OK;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //选择取消
            DialogResult = DialogResult.Cancel;
        }
    }
}
