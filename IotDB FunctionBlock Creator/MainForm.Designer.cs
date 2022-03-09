
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
            this.buttonXML = new System.Windows.Forms.Button();
            this.groupBoxlogin = new System.Windows.Forms.GroupBox();
            this.textBoxpw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFB = new System.Windows.Forms.Button();
            this.paneldown = new System.Windows.Forms.Panel();
            this.buttonclearselect = new System.Windows.Forms.Button();
            this.buttonselectall = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.contextList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuIteminfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttoncsv = new System.Windows.Forms.Button();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTimeSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEncoding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeltext = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReadDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddWFB = new System.Windows.Forms.Button();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReadFB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWriteFB = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxlogin.SuspendLayout();
            this.paneldown.SuspendLayout();
            this.contextListMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBAT
            // 
            this.buttonBAT.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBAT.Location = new System.Drawing.Point(1146, 273);
            this.buttonBAT.Name = "buttonBAT";
            this.buttonBAT.Size = new System.Drawing.Size(146, 30);
            this.buttonBAT.TabIndex = 1;
            this.buttonBAT.Text = "读取数据库";
            this.buttonBAT.UseVisualStyleBackColor = false;
            this.buttonBAT.Click += new System.EventHandler(this.buttonBAT_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
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
            this.dataGridView.Location = new System.Drawing.Point(13, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1128, 531);
            this.dataGridView.TabIndex = 3;
            // 
            // buttonXML
            // 
            this.buttonXML.BackColor = System.Drawing.Color.Azure;
            this.buttonXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXML.Location = new System.Drawing.Point(1148, 479);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(145, 30);
            this.buttonXML.TabIndex = 4;
            this.buttonXML.Text = "生成功能块xml";
            this.buttonXML.UseVisualStyleBackColor = false;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // groupBoxlogin
            // 
            this.groupBoxlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxlogin.Controls.Add(this.textBoxpw);
            this.groupBoxlogin.Controls.Add(this.label4);
            this.groupBoxlogin.Controls.Add(this.textBoxuser);
            this.groupBoxlogin.Controls.Add(this.label3);
            this.groupBoxlogin.Controls.Add(this.textBoxport);
            this.groupBoxlogin.Controls.Add(this.label2);
            this.groupBoxlogin.Controls.Add(this.textBoxip);
            this.groupBoxlogin.Controls.Add(this.label1);
            this.groupBoxlogin.Location = new System.Drawing.Point(1147, 34);
            this.groupBoxlogin.Name = "groupBoxlogin";
            this.groupBoxlogin.Size = new System.Drawing.Size(145, 233);
            this.groupBoxlogin.TabIndex = 5;
            this.groupBoxlogin.TabStop = false;
            this.groupBoxlogin.Text = "IotDB登录";
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
            this.buttonAddFB.Location = new System.Drawing.Point(1148, 407);
            this.buttonAddFB.Name = "buttonAddFB";
            this.buttonAddFB.Size = new System.Drawing.Size(145, 30);
            this.buttonAddFB.TabIndex = 4;
            this.buttonAddFB.Text = "添加读取功能块";
            this.buttonAddFB.UseVisualStyleBackColor = false;
            this.buttonAddFB.Click += new System.EventHandler(this.buttonAddFB_Click);
            // 
            // paneldown
            // 
            this.paneldown.BackColor = System.Drawing.Color.SeaShell;
            this.paneldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldown.Controls.Add(this.labeltext);
            this.paneldown.Controls.Add(this.buttonclearselect);
            this.paneldown.Controls.Add(this.buttonselectall);
            this.paneldown.Controls.Add(this.buttonList);
            this.paneldown.Location = new System.Drawing.Point(13, 565);
            this.paneldown.Name = "paneldown";
            this.paneldown.Size = new System.Drawing.Size(1128, 38);
            this.paneldown.TabIndex = 6;
            // 
            // buttonclearselect
            // 
            this.buttonclearselect.BackColor = System.Drawing.Color.Beige;
            this.buttonclearselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonclearselect.Location = new System.Drawing.Point(84, 3);
            this.buttonclearselect.Name = "buttonclearselect";
            this.buttonclearselect.Size = new System.Drawing.Size(75, 30);
            this.buttonclearselect.TabIndex = 0;
            this.buttonclearselect.Text = "清除选择";
            this.buttonclearselect.UseVisualStyleBackColor = false;
            this.buttonclearselect.Click += new System.EventHandler(this.buttonclearselect_Click);
            // 
            // buttonselectall
            // 
            this.buttonselectall.BackColor = System.Drawing.Color.LightCyan;
            this.buttonselectall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonselectall.Location = new System.Drawing.Point(3, 3);
            this.buttonselectall.Name = "buttonselectall";
            this.buttonselectall.Size = new System.Drawing.Size(75, 30);
            this.buttonselectall.TabIndex = 0;
            this.buttonselectall.Text = "全选";
            this.buttonselectall.UseVisualStyleBackColor = false;
            this.buttonselectall.Click += new System.EventHandler(this.buttonselectall_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonList.Location = new System.Drawing.Point(1021, 3);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(102, 30);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "功能块列表";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // contextList
            // 
            this.contextList.AutoClose = false;
            this.contextList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contextList.Name = "contextList";
            this.contextList.Size = new System.Drawing.Size(61, 4);
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
            // buttoncsv
            // 
            this.buttoncsv.BackColor = System.Drawing.Color.Azure;
            this.buttoncsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncsv.Location = new System.Drawing.Point(1146, 309);
            this.buttoncsv.Name = "buttoncsv";
            this.buttoncsv.Size = new System.Drawing.Size(145, 30);
            this.buttoncsv.TabIndex = 4;
            this.buttoncsv.Text = "导出时间序列到csv";
            this.buttoncsv.UseVisualStyleBackColor = false;
            this.buttoncsv.Click += new System.EventHandler(this.buttoncsv_Click);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.FillWeight = 3F;
            this.ColumnCheck.HeaderText = "选择";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Width = 50;
            // 
            // ColumnTimeSeries
            // 
            this.ColumnTimeSeries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTimeSeries.FillWeight = 10F;
            this.ColumnTimeSeries.HeaderText = "时间序列";
            this.ColumnTimeSeries.Name = "ColumnTimeSeries";
            this.ColumnTimeSeries.ReadOnly = true;
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
            // labeltext
            // 
            this.labeltext.BackColor = System.Drawing.Color.SeaShell;
            this.labeltext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labeltext.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltext.Location = new System.Drawing.Point(165, 4);
            this.labeltext.Multiline = true;
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(807, 28);
            this.labeltext.TabIndex = 1;
            this.labeltext.Text = "欢迎使用IotDB功能块创建工具！";
            this.labeltext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Azure;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemTool,
            this.toolStripMenuItemHelp});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1305, 25);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReadDatabase,
            this.tsmiCSV,
            this.tsmiXML});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItemFile.Text = "文件(&F)";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReadFB,
            this.tsmiWriteFB,
            this.tsmiSelectAll,
            this.tsmiClear});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(59, 21);
            this.toolStripMenuItemEdit.Text = "编辑(&E)";
            // 
            // toolStripMenuItemTool
            // 
            this.toolStripMenuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch});
            this.toolStripMenuItemTool.Name = "toolStripMenuItemTool";
            this.toolStripMenuItemTool.Size = new System.Drawing.Size(59, 21);
            this.toolStripMenuItemTool.Text = "工具(&T)";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(61, 21);
            this.toolStripMenuItemHelp.Text = "帮助(&H)";
            // 
            // tsmiReadDatabase
            // 
            this.tsmiReadDatabase.Name = "tsmiReadDatabase";
            this.tsmiReadDatabase.Size = new System.Drawing.Size(189, 22);
            this.tsmiReadDatabase.Text = "读取 IotDB数据库(&R)";
            this.tsmiReadDatabase.Click += new System.EventHandler(this.buttonBAT_Click);
            // 
            // tsmiCSV
            // 
            this.tsmiCSV.Name = "tsmiCSV";
            this.tsmiCSV.Size = new System.Drawing.Size(189, 22);
            this.tsmiCSV.Text = "导出 csv文件(&C)";
            this.tsmiCSV.Click += new System.EventHandler(this.buttoncsv_Click);
            // 
            // tsmiXML
            // 
            this.tsmiXML.Name = "tsmiXML";
            this.tsmiXML.Size = new System.Drawing.Size(189, 22);
            this.tsmiXML.Text = "生成 xml文件(&X)";
            this.tsmiXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "关于(&A)...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(180, 22);
            this.tsmiSearch.Text = "搜索 时间序列(&C)";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // buttonAddWFB
            // 
            this.buttonAddWFB.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddWFB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddWFB.Location = new System.Drawing.Point(1148, 443);
            this.buttonAddWFB.Name = "buttonAddWFB";
            this.buttonAddWFB.Size = new System.Drawing.Size(145, 30);
            this.buttonAddWFB.TabIndex = 4;
            this.buttonAddWFB.Text = "添加写入功能块";
            this.buttonAddWFB.UseVisualStyleBackColor = false;
            this.buttonAddWFB.Click += new System.EventHandler(this.buttonAddWFB_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(184, 22);
            this.tsmiSelectAll.Text = "全选(&S)";
            this.tsmiSelectAll.Click += new System.EventHandler(this.buttonselectall_Click);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(184, 22);
            this.tsmiClear.Text = "清除 选择(&C)";
            this.tsmiClear.Click += new System.EventHandler(this.buttonclearselect_Click);
            // 
            // tsmiReadFB
            // 
            this.tsmiReadFB.Name = "tsmiReadFB";
            this.tsmiReadFB.Size = new System.Drawing.Size(184, 22);
            this.tsmiReadFB.Text = "创建 读取功能块(&R)";
            this.tsmiReadFB.Click += new System.EventHandler(this.buttonAddFB_Click);
            // 
            // tsmiWriteFB
            // 
            this.tsmiWriteFB.Name = "tsmiWriteFB";
            this.tsmiWriteFB.Size = new System.Drawing.Size(184, 22);
            this.tsmiWriteFB.Text = "创建 写入功能块(&W)";
            this.tsmiWriteFB.Click += new System.EventHandler(this.buttonAddWFB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1305, 614);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.paneldown);
            this.Controls.Add(this.groupBoxlogin);
            this.Controls.Add(this.buttonAddWFB);
            this.Controls.Add(this.buttonAddFB);
            this.Controls.Add(this.buttoncsv);
            this.Controls.Add(this.buttonXML);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonBAT);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1280, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IotDB功能块创建工具";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxlogin.ResumeLayout(false);
            this.groupBoxlogin.PerformLayout();
            this.paneldown.ResumeLayout(false);
            this.paneldown.PerformLayout();
            this.contextListMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBAT;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.GroupBox groupBoxlogin;
        private System.Windows.Forms.TextBox textBoxpw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddFB;
        private System.Windows.Forms.Panel paneldown;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ContextMenuStrip contextList;
        private System.Windows.Forms.ContextMenuStrip contextListMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIteminfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemdelete;
        private System.Windows.Forms.Button buttoncsv;
        private System.Windows.Forms.Button buttonclearselect;
        private System.Windows.Forms.Button buttonselectall;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEncoding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompression;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.TextBox labeltext;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiCSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiXML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Button buttonAddWFB;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadFB;
        private System.Windows.Forms.ToolStripMenuItem tsmiWriteFB;
    }
}

