namespace avs2bdnxml_gui
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnstart = new System.Windows.Forms.Button();
            this.tbxlog = new System.Windows.Forms.TextBox();
            this.lbxtask = new System.Windows.Forms.ListBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(73, 333);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(65, 34);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "button1";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // tbxlog
            // 
            this.tbxlog.Location = new System.Drawing.Point(21, 202);
            this.tbxlog.Multiline = true;
            this.tbxlog.Name = "tbxlog";
            this.tbxlog.Size = new System.Drawing.Size(334, 110);
            this.tbxlog.TabIndex = 1;
            // 
            // lbxtask
            // 
            this.lbxtask.FormattingEnabled = true;
            this.lbxtask.ItemHeight = 12;
            this.lbxtask.Location = new System.Drawing.Point(21, 12);
            this.lbxtask.Name = "lbxtask";
            this.lbxtask.Size = new System.Drawing.Size(334, 184);
            this.lbxtask.TabIndex = 2;
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(226, 333);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(65, 34);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "button1";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 379);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lbxtask);
            this.Controls.Add(this.tbxlog);
            this.Controls.Add(this.btnstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox tbxlog;
        private System.Windows.Forms.ListBox lbxtask;
        private System.Windows.Forms.Button btnstop;
    }
}

