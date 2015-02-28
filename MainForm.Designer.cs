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
            this.lbxtask = new System.Windows.Forms.ListBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.grptaskdata = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxensup = new System.Windows.Forms.CheckBox();
            this.cbx_b = new System.Windows.Forms.CheckBox();
            this.cbx_p = new System.Windows.Forms.CheckBox();
            this.cbx_a = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.num_m = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num_s = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numstarty = new System.Windows.Forms.NumericUpDown();
            this.numstartx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxlang = new System.Windows.Forms.TextBox();
            this.lbltasksel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxfps = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxresolution = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proct = new System.Windows.Forms.ProgressBar();
            this.prbc = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.grptaskdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstarty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstartx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(64, 224);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(65, 34);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "开始";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lbxtask
            // 
            this.lbxtask.FormattingEnabled = true;
            this.lbxtask.ItemHeight = 12;
            this.lbxtask.Location = new System.Drawing.Point(5, 15);
            this.lbxtask.Name = "lbxtask";
            this.lbxtask.Size = new System.Drawing.Size(323, 124);
            this.lbxtask.TabIndex = 2;
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(213, 224);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(65, 34);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "停止";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // grptaskdata
            // 
            this.grptaskdata.Controls.Add(this.checkBox3);
            this.grptaskdata.Controls.Add(this.checkBox2);
            this.grptaskdata.Controls.Add(this.checkBox1);
            this.grptaskdata.Controls.Add(this.cbxensup);
            this.grptaskdata.Controls.Add(this.btnstop);
            this.grptaskdata.Controls.Add(this.cbx_b);
            this.grptaskdata.Controls.Add(this.btnstart);
            this.grptaskdata.Controls.Add(this.cbx_p);
            this.grptaskdata.Controls.Add(this.cbx_a);
            this.grptaskdata.Controls.Add(this.label11);
            this.grptaskdata.Controls.Add(this.num_m);
            this.grptaskdata.Controls.Add(this.label10);
            this.grptaskdata.Controls.Add(this.num_s);
            this.grptaskdata.Controls.Add(this.label9);
            this.grptaskdata.Controls.Add(this.label8);
            this.grptaskdata.Controls.Add(this.numstarty);
            this.grptaskdata.Controls.Add(this.numstartx);
            this.grptaskdata.Controls.Add(this.label7);
            this.grptaskdata.Controls.Add(this.tbxlang);
            this.grptaskdata.Controls.Add(this.lbltasksel);
            this.grptaskdata.Controls.Add(this.label6);
            this.grptaskdata.Controls.Add(this.label5);
            this.grptaskdata.Controls.Add(this.cbxfps);
            this.grptaskdata.Controls.Add(this.label4);
            this.grptaskdata.Controls.Add(this.cbxresolution);
            this.grptaskdata.Location = new System.Drawing.Point(348, 1);
            this.grptaskdata.Name = "grptaskdata";
            this.grptaskdata.Size = new System.Drawing.Size(318, 274);
            this.grptaskdata.TabIndex = 11;
            this.grptaskdata.TabStop = false;
            this.grptaskdata.Text = "任务属性";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(90, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 22);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "首帧黑屏";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxensup
            // 
            this.cbxensup.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxensup.Checked = true;
            this.cbxensup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxensup.Location = new System.Drawing.Point(8, 177);
            this.cbxensup.Name = "cbxensup";
            this.cbxensup.Size = new System.Drawing.Size(70, 22);
            this.cbxensup.TabIndex = 19;
            this.cbxensup.Text = "生成SUP";
            this.cbxensup.UseVisualStyleBackColor = true;
            // 
            // cbx_b
            // 
            this.cbx_b.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbx_b.Checked = true;
            this.cbx_b.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_b.Location = new System.Drawing.Point(241, 139);
            this.cbx_b.Name = "cbx_b";
            this.cbx_b.Size = new System.Drawing.Size(70, 22);
            this.cbx_b.TabIndex = 18;
            this.cbx_b.Text = "分双窗口";
            this.cbx_b.UseVisualStyleBackColor = true;
            // 
            // cbx_p
            // 
            this.cbx_p.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbx_p.Checked = true;
            this.cbx_p.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_p.Location = new System.Drawing.Point(166, 139);
            this.cbx_p.Name = "cbx_p";
            this.cbx_p.Size = new System.Drawing.Size(70, 22);
            this.cbx_p.TabIndex = 17;
            this.cbx_p.Text = "标准位宽";
            this.cbx_p.UseVisualStyleBackColor = true;
            // 
            // cbx_a
            // 
            this.cbx_a.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbx_a.Checked = true;
            this.cbx_a.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_a.Location = new System.Drawing.Point(90, 139);
            this.cbx_a.Name = "cbx_a";
            this.cbx_a.Size = new System.Drawing.Size(70, 22);
            this.cbx_a.TabIndex = 16;
            this.cbx_a.Text = "自动切割";
            this.cbx_a.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "最小轴长";
            // 
            // num_m
            // 
            this.num_m.Location = new System.Drawing.Point(8, 140);
            this.num_m.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_m.Name = "num_m";
            this.num_m.Size = new System.Drawing.Size(70, 21);
            this.num_m.TabIndex = 14;
            this.num_m.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "按帧分段";
            // 
            // num_s
            // 
            this.num_s.Location = new System.Drawing.Point(241, 96);
            this.num_s.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_s.Name = "num_s";
            this.num_s.Size = new System.Drawing.Size(70, 21);
            this.num_s.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "Y轴起始";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "X轴起始";
            // 
            // numstarty
            // 
            this.numstarty.Location = new System.Drawing.Point(166, 96);
            this.numstarty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numstarty.Name = "numstarty";
            this.numstarty.Size = new System.Drawing.Size(69, 21);
            this.numstarty.TabIndex = 9;
            // 
            // numstartx
            // 
            this.numstartx.Location = new System.Drawing.Point(90, 96);
            this.numstartx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numstartx.Name = "numstartx";
            this.numstartx.Size = new System.Drawing.Size(70, 21);
            this.numstartx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "流语言码";
            // 
            // tbxlang
            // 
            this.tbxlang.Location = new System.Drawing.Point(8, 94);
            this.tbxlang.Name = "tbxlang";
            this.tbxlang.Size = new System.Drawing.Size(70, 21);
            this.tbxlang.TabIndex = 6;
            this.tbxlang.Text = "zho";
            // 
            // lbltasksel
            // 
            this.lbltasksel.AutoSize = true;
            this.lbltasksel.Location = new System.Drawing.Point(67, 17);
            this.lbltasksel.Name = "lbltasksel";
            this.lbltasksel.Size = new System.Drawing.Size(53, 12);
            this.lbltasksel.TabIndex = 5;
            this.lbltasksel.Text = "全局设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "当前调整:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "帧速率";
            // 
            // cbxfps
            // 
            this.cbxfps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfps.FormattingEnabled = true;
            this.cbxfps.Items.AddRange(new object[] {
            "23.976",
            "29.970",
            "25",
            "24"});
            this.cbxfps.Location = new System.Drawing.Point(90, 50);
            this.cbxfps.Name = "cbxfps";
            this.cbxfps.Size = new System.Drawing.Size(70, 20);
            this.cbxfps.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "分辨率";
            // 
            // cbxresolution
            // 
            this.cbxresolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxresolution.FormattingEnabled = true;
            this.cbxresolution.Items.AddRange(new object[] {
            "1080p",
            "720p",
            "480p",
            "480i",
            "576i"});
            this.cbxresolution.Location = new System.Drawing.Point(6, 50);
            this.cbxresolution.Name = "cbxresolution";
            this.cbxresolution.Size = new System.Drawing.Size(70, 20);
            this.cbxresolution.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.proct);
            this.groupBox1.Controls.Add(this.prbc);
            this.groupBox1.Location = new System.Drawing.Point(8, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "总体进度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "当前进度";
            // 
            // proct
            // 
            this.proct.Location = new System.Drawing.Point(6, 61);
            this.proct.Name = "proct";
            this.proct.Size = new System.Drawing.Size(323, 16);
            this.proct.TabIndex = 9;
            // 
            // prbc
            // 
            this.prbc.Location = new System.Drawing.Point(6, 27);
            this.prbc.Name = "prbc";
            this.prbc.Size = new System.Drawing.Size(323, 16);
            this.prbc.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxtask);
            this.groupBox2.Location = new System.Drawing.Point(8, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 146);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(8, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 44);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "输出路径:";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(166, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 22);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "末尾黑屏";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(241, 177);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 22);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "使用VSMOD";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 283);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grptaskdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avs2bdnxml-gui";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grptaskdata.ResumeLayout(false);
            this.grptaskdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstarty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstartx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox lbxtask;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.GroupBox grptaskdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar proct;
        private System.Windows.Forms.ProgressBar prbc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxresolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxfps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltasksel;
        private System.Windows.Forms.TextBox tbxlang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numstarty;
        private System.Windows.Forms.NumericUpDown numstartx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_s;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_m;
        private System.Windows.Forms.CheckBox cbx_b;
        private System.Windows.Forms.CheckBox cbx_p;
        private System.Windows.Forms.CheckBox cbx_a;
        private System.Windows.Forms.CheckBox cbxensup;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

