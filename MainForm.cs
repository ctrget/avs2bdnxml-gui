using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace avs2bdnxml_gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                if (String.IsNullOrEmpty(e.Data) == false)
                    tbxlog.AppendText(e.Data + "\r\n");
            }));


        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            int i = "00:10:08,580 --> 00:10:14,220".IndexOf("-->");
            string[] sa = "00:10:08,580 --> 00:10:14,220".Split(new char[]{'-', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show(sa[1]);
            //ASSFile assfile = Subtitle.LoadFromFile(Directory.GetCurrentDirectory() + "\\1.ass");
            //int fcount = Subtitle.GetFrameCount(Directory.GetCurrentDirectory() + "\\1.ass", Common.FPSList[0], 0);
            //MessageBox.Show(fcount.ToString());
            
            //Subtitle.ASS_GetFrameCount(Directory.GetCurrentDirectory() + "\\2.ass", 0, 0);
            //shell = new Shell("xdelta3-3.0.8.x86-64.exe", @" -v -e -s D:\git\avs2bdnxml-gui\Debug\1.txt ""D:\ISO\zh-hans_windows_xp_professional_with_service_pack_3_x86_cd_vl_x14-74070 (ED2000.COM).iso"" D:\git\avs2bdnxml-gui\Debug\1.patch", Directory.GetCurrentDirectory(), this.OutputDataReceived);
            //shell.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            //shell.Stop();
        }






    }
}
