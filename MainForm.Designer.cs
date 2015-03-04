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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbxtask = new System.Windows.Forms.ListBox();
            this.contextMenuStripTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmnuremove = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuclear = new System.Windows.Forms.ToolStripMenuItem();
            this.grbtaskdata = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.tbxoutpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxenvsmod = new System.Windows.Forms.CheckBox();
            this.cbxeblk = new System.Windows.Forms.CheckBox();
            this.cbxfblk = new System.Windows.Forms.CheckBox();
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
            this.num_y = new System.Windows.Forms.NumericUpDown();
            this.num_x = new System.Windows.Forms.NumericUpDown();
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
            this.procc = new System.Windows.Forms.ProgressBar();
            this.grbtasklst = new System.Windows.Forms.GroupBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.nicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmnushow = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTask.SuspendLayout();
            this.grbtaskdata.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbtasklst.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxtask
            // 
            this.lbxtask.AllowDrop = true;
            this.lbxtask.ContextMenuStrip = this.contextMenuStripTask;
            this.lbxtask.FormattingEnabled = true;
            this.lbxtask.ItemHeight = 12;
            this.lbxtask.Location = new System.Drawing.Point(5, 15);
            this.lbxtask.Name = "lbxtask";
            this.lbxtask.Size = new System.Drawing.Size(323, 196);
            this.lbxtask.TabIndex = 2;
            this.lbxtask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxtask_MouseClick);
            this.lbxtask.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxtask_DragDrop);
            this.lbxtask.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxtask_DragEnter);
            // 
            // contextMenuStripTask
            // 
            this.contextMenuStripTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuremove,
            this.tmnuclear});
            this.contextMenuStripTask.Name = "contextMenuStrip1";
            this.contextMenuStripTask.Size = new System.Drawing.Size(125, 48);
            // 
            // tmnuremove
            // 
            this.tmnuremove.Name = "tmnuremove";
            this.tmnuremove.Size = new System.Drawing.Size(124, 22);
            this.tmnuremove.Text = "移除选定";
            this.tmnuremove.Click += new System.EventHandler(this.tmnuremove_Click);
            // 
            // tmnuclear
            // 
            this.tmnuclear.Name = "tmnuclear";
            this.tmnuclear.Size = new System.Drawing.Size(124, 22);
            this.tmnuclear.Text = "清空任务";
            this.tmnuclear.Click += new System.EventHandler(this.tmnuclear_Click);
            // 
            // grbtaskdata
            // 
            this.grbtaskdata.Controls.Add(this.groupBox3);
            this.grbtaskdata.Controls.Add(this.cbxenvsmod);
            this.grbtaskdata.Controls.Add(this.cbxeblk);
            this.grbtaskdata.Controls.Add(this.cbxfblk);
            this.grbtaskdata.Controls.Add(this.cbxensup);
            this.grbtaskdata.Controls.Add(this.cbx_b);
            this.grbtaskdata.Controls.Add(this.cbx_p);
            this.grbtaskdata.Controls.Add(this.cbx_a);
            this.grbtaskdata.Controls.Add(this.label11);
            this.grbtaskdata.Controls.Add(this.num_m);
            this.grbtaskdata.Controls.Add(this.label10);
            this.grbtaskdata.Controls.Add(this.num_s);
            this.grbtaskdata.Controls.Add(this.label9);
            this.grbtaskdata.Controls.Add(this.label8);
            this.grbtaskdata.Controls.Add(this.num_y);
            this.grbtaskdata.Controls.Add(this.num_x);
            this.grbtaskdata.Controls.Add(this.label7);
            this.grbtaskdata.Controls.Add(this.tbxlang);
            this.grbtaskdata.Controls.Add(this.lbltasksel);
            this.grbtaskdata.Controls.Add(this.label6);
            this.grbtaskdata.Controls.Add(this.label5);
            this.grbtaskdata.Controls.Add(this.cbxfps);
            this.grbtaskdata.Controls.Add(this.label4);
            this.grbtaskdata.Controls.Add(this.cbxresolution);
            this.grbtaskdata.Location = new System.Drawing.Point(348, 1);
            this.grbtaskdata.Name = "grbtaskdata";
            this.grbtaskdata.Size = new System.Drawing.Size(318, 267);
            this.grbtaskdata.TabIndex = 11;
            this.grbtaskdata.TabStop = false;
            this.grbtaskdata.Text = "任务属性";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbrowser);
            this.groupBox3.Controls.Add(this.tbxoutpath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 44);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(254, 15);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(46, 21);
            this.btnbrowser.TabIndex = 13;
            this.btnbrowser.Text = "浏览";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // tbxoutpath
            // 
            this.tbxoutpath.Location = new System.Drawing.Point(67, 15);
            this.tbxoutpath.Name = "tbxoutpath";
            this.tbxoutpath.Size = new System.Drawing.Size(181, 21);
            this.tbxoutpath.TabIndex = 12;
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
            // cbxenvsmod
            // 
            this.cbxenvsmod.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxenvsmod.Checked = true;
            this.cbxenvsmod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxenvsmod.Location = new System.Drawing.Point(241, 219);
            this.cbxenvsmod.Name = "cbxenvsmod";
            this.cbxenvsmod.Size = new System.Drawing.Size(70, 22);
            this.cbxenvsmod.TabIndex = 22;
            this.cbxenvsmod.Text = "使用VSMOD";
            this.cbxenvsmod.UseVisualStyleBackColor = true;
            // 
            // cbxeblk
            // 
            this.cbxeblk.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxeblk.Checked = true;
            this.cbxeblk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxeblk.Location = new System.Drawing.Point(166, 219);
            this.cbxeblk.Name = "cbxeblk";
            this.cbxeblk.Size = new System.Drawing.Size(70, 22);
            this.cbxeblk.TabIndex = 21;
            this.cbxeblk.Text = "末尾黑屏";
            this.cbxeblk.UseVisualStyleBackColor = true;
            // 
            // cbxfblk
            // 
            this.cbxfblk.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxfblk.Checked = true;
            this.cbxfblk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxfblk.Location = new System.Drawing.Point(90, 219);
            this.cbxfblk.Name = "cbxfblk";
            this.cbxfblk.Size = new System.Drawing.Size(70, 22);
            this.cbxfblk.TabIndex = 20;
            this.cbxfblk.Text = "首帧黑屏";
            this.cbxfblk.UseVisualStyleBackColor = true;
            // 
            // cbxensup
            // 
            this.cbxensup.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxensup.Checked = true;
            this.cbxensup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxensup.Location = new System.Drawing.Point(8, 219);
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
            this.cbx_b.Location = new System.Drawing.Point(241, 181);
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
            this.cbx_p.Location = new System.Drawing.Point(166, 181);
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
            this.cbx_a.Location = new System.Drawing.Point(90, 181);
            this.cbx_a.Name = "cbx_a";
            this.cbx_a.Size = new System.Drawing.Size(70, 22);
            this.cbx_a.TabIndex = 16;
            this.cbx_a.Text = "自动切割";
            this.cbx_a.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "最小轴长";
            // 
            // num_m
            // 
            this.num_m.Location = new System.Drawing.Point(8, 182);
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
            this.label10.Location = new System.Drawing.Point(257, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "按帧分段";
            // 
            // num_s
            // 
            this.num_s.Location = new System.Drawing.Point(241, 138);
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
            this.label9.Location = new System.Drawing.Point(170, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "Y轴起始";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "X轴起始";
            // 
            // num_y
            // 
            this.num_y.Location = new System.Drawing.Point(166, 138);
            this.num_y.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_y.Name = "num_y";
            this.num_y.Size = new System.Drawing.Size(69, 21);
            this.num_y.TabIndex = 9;
            // 
            // num_x
            // 
            this.num_x.Location = new System.Drawing.Point(90, 138);
            this.num_x.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(70, 21);
            this.num_x.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "流语言码";
            // 
            // tbxlang
            // 
            this.tbxlang.Location = new System.Drawing.Point(8, 136);
            this.tbxlang.Name = "tbxlang";
            this.tbxlang.Size = new System.Drawing.Size(70, 21);
            this.tbxlang.TabIndex = 6;
            this.tbxlang.Text = "zho";
            // 
            // lbltasksel
            // 
            this.lbltasksel.Location = new System.Drawing.Point(67, 17);
            this.lbltasksel.Name = "lbltasksel";
            this.lbltasksel.Size = new System.Drawing.Size(238, 12);
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
            this.label5.Location = new System.Drawing.Point(88, 77);
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
            this.cbxfps.Location = new System.Drawing.Point(90, 92);
            this.cbxfps.Name = "cbxfps";
            this.cbxfps.Size = new System.Drawing.Size(70, 20);
            this.cbxfps.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 77);
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
            this.cbxresolution.Location = new System.Drawing.Point(6, 92);
            this.cbxresolution.Name = "cbxresolution";
            this.cbxresolution.Size = new System.Drawing.Size(70, 20);
            this.cbxresolution.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.proct);
            this.groupBox1.Controls.Add(this.procc);
            this.groupBox1.Location = new System.Drawing.Point(8, 225);
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
            // procc
            // 
            this.procc.Location = new System.Drawing.Point(6, 27);
            this.procc.Name = "procc";
            this.procc.Size = new System.Drawing.Size(323, 16);
            this.procc.TabIndex = 8;
            // 
            // grbtasklst
            // 
            this.grbtasklst.Controls.Add(this.lbxtask);
            this.grbtasklst.Location = new System.Drawing.Point(8, 1);
            this.grbtasklst.Name = "grbtasklst";
            this.grbtasklst.Size = new System.Drawing.Size(334, 218);
            this.grbtasklst.TabIndex = 13;
            this.grbtasklst.TabStop = false;
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(556, 276);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(65, 34);
            this.btnstop.TabIndex = 15;
            this.btnstop.Text = "停止";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(407, 276);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(65, 34);
            this.btnstart.TabIndex = 14;
            this.btnstart.Text = "开始";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            // 
            // nicon
            // 
            this.nicon.ContextMenuStrip = this.contextMenuStripIcon;
            this.nicon.Text = "avs2bdnxml-gui";
            this.nicon.Visible = true;
            this.nicon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nicon_MouseClick);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnushow,
            this.tmnuexit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(101, 48);
            // 
            // tmnushow
            // 
            this.tmnushow.Name = "tmnushow";
            this.tmnushow.Size = new System.Drawing.Size(100, 22);
            this.tmnushow.Text = "显示";
            this.tmnushow.Click += new System.EventHandler(this.tmnushow_Click);
            // 
            // tmnuexit
            // 
            this.tmnuexit.Name = "tmnuexit";
            this.tmnuexit.Size = new System.Drawing.Size(100, 22);
            this.tmnuexit.Text = "退出";
            this.tmnuexit.Click += new System.EventHandler(this.tmnuexit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 316);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.grbtasklst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbtaskdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avs2bdnxml-gui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStripTask.ResumeLayout(false);
            this.grbtaskdata.ResumeLayout(false);
            this.grbtaskdata.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbtasklst.ResumeLayout(false);
            this.contextMenuStripIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxtask;
        private System.Windows.Forms.GroupBox grbtaskdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar proct;
        private System.Windows.Forms.ProgressBar procc;
        private System.Windows.Forms.GroupBox grbtasklst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox tbxoutpath;
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
        private System.Windows.Forms.NumericUpDown num_y;
        private System.Windows.Forms.NumericUpDown num_x;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_s;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_m;
        private System.Windows.Forms.CheckBox cbx_b;
        private System.Windows.Forms.CheckBox cbx_p;
        private System.Windows.Forms.CheckBox cbx_a;
        private System.Windows.Forms.CheckBox cbxensup;
        private System.Windows.Forms.CheckBox cbxfblk;
        private System.Windows.Forms.CheckBox cbxeblk;
        private System.Windows.Forms.CheckBox cbxenvsmod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTask;
        private System.Windows.Forms.ToolStripMenuItem tmnuremove;
        private System.Windows.Forms.ToolStripMenuItem tmnuclear;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.NotifyIcon nicon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem tmnushow;
        private System.Windows.Forms.ToolStripMenuItem tmnuexit;
    }
}

