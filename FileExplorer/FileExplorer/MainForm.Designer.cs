namespace FileExplorer
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
            this.btnGetScanDirectory = new System.Windows.Forms.Button();
            this.txtScanDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.btnGetSaveDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetScanDirectory
            // 
            this.btnGetScanDirectory.Location = new System.Drawing.Point(612, 43);
            this.btnGetScanDirectory.Name = "btnGetScanDirectory";
            this.btnGetScanDirectory.Size = new System.Drawing.Size(31, 23);
            this.btnGetScanDirectory.TabIndex = 0;
            this.btnGetScanDirectory.Text = "...";
            this.btnGetScanDirectory.UseVisualStyleBackColor = true;
            this.btnGetScanDirectory.Click += new System.EventHandler(this.btnGetDirectory_Click);
            // 
            // txtScanDirectory
            // 
            this.txtScanDirectory.Location = new System.Drawing.Point(77, 45);
            this.txtScanDirectory.Name = "txtScanDirectory";
            this.txtScanDirectory.Size = new System.Drawing.Size(529, 21);
            this.txtScanDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "扫描路径：";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(668, 62);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "扫描";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存路径：";
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(77, 81);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.Size = new System.Drawing.Size(529, 21);
            this.txtSaveFilePath.TabIndex = 5;
            // 
            // btnGetSaveDirectory
            // 
            this.btnGetSaveDirectory.Location = new System.Drawing.Point(612, 79);
            this.btnGetSaveDirectory.Name = "btnGetSaveDirectory";
            this.btnGetSaveDirectory.Size = new System.Drawing.Size(31, 23);
            this.btnGetSaveDirectory.TabIndex = 6;
            this.btnGetSaveDirectory.Text = "...";
            this.btnGetSaveDirectory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 293);
            this.Controls.Add(this.btnGetSaveDirectory);
            this.Controls.Add(this.txtSaveFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanDirectory);
            this.Controls.Add(this.btnGetScanDirectory);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetScanDirectory;
        private System.Windows.Forms.TextBox txtScanDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.Button btnGetSaveDirectory;
    }
}

