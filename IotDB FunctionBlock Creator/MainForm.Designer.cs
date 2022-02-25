
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBAT
            // 
            this.buttonBAT.Location = new System.Drawing.Point(1147, 13);
            this.buttonBAT.Name = "buttonBAT";
            this.buttonBAT.Size = new System.Drawing.Size(146, 40);
            this.buttonBAT.TabIndex = 1;
            this.buttonBAT.Text = "读取数据库";
            this.buttonBAT.UseVisualStyleBackColor = true;
            this.buttonBAT.Click += new System.EventHandler(this.buttonBAT_Click);
            // 
            // dataGridView
            // 
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
            this.dataGridView.Size = new System.Drawing.Size(1128, 599);
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
            this.buttonXML.Location = new System.Drawing.Point(1148, 59);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(145, 40);
            this.buttonXML.TabIndex = 4;
            this.buttonXML.Text = "生成xml";
            this.buttonXML.UseVisualStyleBackColor = true;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 624);
            this.Controls.Add(this.buttonXML);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonBAT);
            this.Name = "MainForm";
            this.Text = "IotDB功能块创建工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}

