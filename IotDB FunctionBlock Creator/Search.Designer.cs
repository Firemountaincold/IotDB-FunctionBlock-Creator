
namespace IotDB_FunctionBlock_Creator
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkBoxFuzzy = new System.Windows.Forms.CheckBox();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 32);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(236, 21);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBoxFuzzy
            // 
            this.checkBoxFuzzy.AutoSize = true;
            this.checkBoxFuzzy.Location = new System.Drawing.Point(12, 9);
            this.checkBoxFuzzy.Name = "checkBoxFuzzy";
            this.checkBoxFuzzy.Size = new System.Drawing.Size(72, 16);
            this.checkBoxFuzzy.TabIndex = 2;
            this.checkBoxFuzzy.Text = "模糊查询";
            this.checkBoxFuzzy.UseVisualStyleBackColor = true;
            this.checkBoxFuzzy.CheckedChanged += new System.EventHandler(this.checkBoxFuzzy_CheckedChanged);
            // 
            // checkBoxUpper
            // 
            this.checkBoxUpper.AutoSize = true;
            this.checkBoxUpper.Location = new System.Drawing.Point(116, 9);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(84, 16);
            this.checkBoxUpper.TabIndex = 3;
            this.checkBoxUpper.Text = "区分大小写";
            this.checkBoxUpper.UseVisualStyleBackColor = true;
            this.checkBoxUpper.CheckedChanged += new System.EventHandler(this.checkBoxUpper_CheckedChanged);
            // 
            // buttonclose
            // 
            this.buttonclose.BackgroundImage = global::IotDB_FunctionBlock_Creator.Properties.Resources.x;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonclose.Location = new System.Drawing.Point(253, 2);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(25, 25);
            this.buttonclose.TabIndex = 4;
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::IotDB_FunctionBlock_Creator.Properties.Resources.search;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(253, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(25, 25);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(282, 58);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.checkBoxUpper);
            this.Controls.Add(this.checkBoxFuzzy);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxFuzzy;
        private System.Windows.Forms.CheckBox checkBoxUpper;
        private System.Windows.Forms.Button buttonclose;
    }
}