
namespace IotDB_FunctionBlock_Creator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBAT = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTimeSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEncoding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxpw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltext = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.contextList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuIteminfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemdelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBAT
            // 
            this.buttonBAT.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBAT.Location = new System.Drawing.Point(1147, 252);
            this.buttonBAT.Name = "buttonBAT";
            this.buttonBAT.Size = new System.Drawing.Size(146, 40);
            this.buttonBAT.TabIndex = 1;
            this.buttonBAT.Text = "读取数据库";
            this.buttonBAT.UseVisualStyleBackColor = false;
            this.buttonBAT.Click += new System.EventHandler(this.buttonBAT_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnTimeSeries,
            this.ColumnAlias,
            this.ColumnStorage,
            this.ColumnDataType,
            this.ColumnEncoding,
            this.ColumnCompression,
            this.ColumnTags,
            this.ColumnDescription});
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1128, 552);
            this.dataGridView.TabIndex = 3;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.FillWeight = 10F;
            this.ColumnCheck.HeaderText = "选择";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Width = 50;
            // 
            // ColumnTimeSeries
            // 
            this.ColumnTimeSeries.FillWeight = 16.99072F;
            this.ColumnTimeSeries.HeaderText = "时间序列";
            this.ColumnTimeSeries.Name = "ColumnTimeSeries";
            this.ColumnTimeSeries.ReadOnly = true;
            this.ColumnTimeSeries.Width = 200;
            // 
            // ColumnAlias
            // 
            this.ColumnAlias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAlias.FillWeight = 6.335751F;
            this.ColumnAlias.HeaderText = "别名";
            this.ColumnAlias.Name = "ColumnAlias";
            this.ColumnAlias.ReadOnly = true;
            // 
            // ColumnStorage
            // 
            this.ColumnStorage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStorage.FillWeight = 6.335751F;
            this.ColumnStorage.HeaderText = "仓库";
            this.ColumnStorage.Name = "ColumnStorage";
            this.ColumnStorage.ReadOnly = true;
            // 
            // ColumnDataType
            // 
            this.ColumnDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataType.FillWeight = 6.335751F;
            this.ColumnDataType.HeaderText = "数据类型";
            this.ColumnDataType.Name = "ColumnDataType";
            this.ColumnDataType.ReadOnly = true;
            // 
            // ColumnEncoding
            // 
            this.ColumnEncoding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEncoding.FillWeight = 6.335751F;
            this.ColumnEncoding.HeaderText = "编码方式";
            this.ColumnEncoding.Name = "ColumnEncoding";
            this.ColumnEncoding.ReadOnly = true;
            // 
            // ColumnCompression
            // 
            this.ColumnCompression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCompression.FillWeight = 6.335751F;
            this.ColumnCompression.HeaderText = "压缩方式";
            this.ColumnCompression.Name = "ColumnCompression";
            this.ColumnCompression.ReadOnly = true;
            // 
            // ColumnTags
            // 
            this.ColumnTags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTags.FillWeight = 6.335751F;
            this.ColumnTags.HeaderText = "标签";
            this.ColumnTags.Name = "ColumnTags";
            this.ColumnTags.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.FillWeight = 6.335751F;
            this.ColumnDescription.HeaderText = "描述";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // buttonXML
            // 
            this.buttonXML.BackColor = System.Drawing.Color.Azure;
            this.buttonXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXML.Location = new System.Drawing.Point(1148, 344);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(145, 40);
            this.buttonXML.TabIndex = 4;
            this.buttonXML.Text = "生成xml";
            this.buttonXML.UseVisualStyleBackColor = false;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textBoxpw);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxuser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1148, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IotDB登录";
            // 
            // textBoxpw
            // 
            this.textBoxpw.Location = new System.Drawing.Point(9, 198);
            this.textBoxpw.Name = "textBoxpw";
            this.textBoxpw.Size = new System.Drawing.Size(130, 21);
            this.textBoxpw.TabIndex = 7;
            this.textBoxpw.Text = "root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码：";
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(9, 145);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(130, 21);
            this.textBoxuser.TabIndex = 5;
            this.textBoxuser.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名：";
            // 
            // textBoxport
            // 
            this.textBoxport.Location = new System.Drawing.Point(9, 92);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(130, 21);
            this.textBoxport.TabIndex = 3;
            this.textBoxport.Text = "6667";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(9, 42);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(130, 21);
            this.textBoxip.TabIndex = 1;
            this.textBoxip.Text = "192.168.0.47";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // buttonAddFB
            // 
            this.buttonAddFB.BackColor = System.Drawing.Color.Lavender;
            this.buttonAddFB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddFB.Location = new System.Drawing.Point(1148, 298);
            this.buttonAddFB.Name = "buttonAddFB";
            this.buttonAddFB.Size = new System.Drawing.Size(145, 40);
            this.buttonAddFB.TabIndex = 4;
            this.buttonAddFB.Text = "添加功能块";
            this.buttonAddFB.UseVisualStyleBackColor = false;
            this.buttonAddFB.Click += new System.EventHandler(this.buttonAddFB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labeltext);
            this.panel1.Controls.Add(this.buttonList);
            this.panel1.Location = new System.Drawing.Point(13, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 50);
            this.panel1.TabIndex = 6;
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltext.Location = new System.Drawing.Point(14, 17);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(227, 15);
            this.labeltext.TabIndex = 1;
            this.labeltext.Text = "欢迎使用IotDB功能块创建工具！";
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonList.Location = new System.Drawing.Point(1048, 3);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 43);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "列表";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // contextList
            // 
            this.contextList.AutoClose = false;
            this.contextList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contextList.Name = "contextList";
            this.contextList.Size = new System.Drawing.Size(181, 26);
            // 
            // contextListMenu
            // 
            this.contextListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIteminfo,
            this.toolStripMenuItemdelete});
            this.contextListMenu.Name = "contextListMenu";
            this.contextListMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuIteminfo
            // 
            this.toolStripMenuIteminfo.Name = "toolStripMenuIteminfo";
            this.toolStripMenuIteminfo.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuIteminfo.Text = "查看详细";
            this.toolStripMenuIteminfo.Click += new System.EventHandler(this.toolStripMenuIteminfo_Click);
            // 
            // toolStripMenuItemdelete
            // 
            this.toolStripMenuItemdelete.Name = "toolStripMenuItemdelete";
            this.toolStripMenuItemdelete.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemdelete.Text = "删除功能块";
            this.toolStripMenuItemdelete.Click += new System.EventHandler(this.toolStripMenuItemdelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1305, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddFB);
            this.Controls.Add(this.buttonXML);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonBAT);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IotDB功能块创建工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextListMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBAT;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEncoding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompression;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxpw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddFB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ContextMenuStrip contextList;
        private System.Windows.Forms.ContextMenuStrip contextListMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIteminfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemdelete;
    }
}

