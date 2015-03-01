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
            cbxresolution.SelectedIndex = 0;
            cbxfps.SelectedIndex = 0;
        }


        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                ParseProgress(e.Data);
                /*
                if (String.IsNullOrEmpty(e.Data) == false)
                    tbxlog.AppendText(e.Data + "\r\n");
                 */
            }));


        }

        private void ParseProgress(string str)
        {

            if (str.IndexOf("Progress") < 0)
                return;

            string[] sa = str.Split(' ');

            if (sa.Length >= 5)
            {
                string tstr = sa[1];
                int fi = Int32.Parse(tstr.Split('/')[0]);
                int ti = Int32.Parse(tstr.Split('/')[1]);

                this.Invoke(new MethodInvoker(() =>
                {
                    prbc.Maximum = ti;
                    prbc.Value = fi;
                }));

            }

        }


        private void MakeAvs(Common.TaskData ta)
        {
            List<string> olst = new List<string>();

            int fcount = 0;
            double fps;
            Common.Resolution res;
            fps = Common.FPSList[ta.FPSIndex];
            res = Common.ResolutionList[ta.ResolutionIndex];
            Common.FileType ftype = Common.GetFileType(ta.FileFullPath);

            if (ftype == Common.FileType.ASS)
            {
                fcount = ASSFile.GetFrameCount(ta.FileFullPath, fps);
            }
            else if (ftype == Common.FileType.SSA)
            {
                fcount = SSAFile.GetFrameCount(ta.FileFullPath, fps);
            }

            if (ta.UseVSMod)
            {
                olst.Add("LoadPlugin(\"" + Directory.GetCurrentDirectory() + "\\core\\VSFilter.dll\")");
            }
            else
            {
                olst.Add("LoadPlugin(\"" + Directory.GetCurrentDirectory() + "\\core\\VSFilterMod.dll\")");
            }

            olst.Add("MaskSub(\"" + ta.FileFullPath + "\", " + res.X.ToString() + ", " + res.Y.ToString() + ", " + fps.ToString() + ", " + fcount.ToString() + ")");


            if (ta.ResolutionIndex == 3)
            {
                olst.Add("LanczosResize(720,480)");
            }
            else if (ta.ResolutionIndex == 4)
            {
                olst.Add("LanczosResize(720,576)");
            }
            else
            {
                olst.Add("LanczosResize(" + res.X.ToString() + ", " + res.Y.ToString() + ")");
            }
                

        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            ParseProgress("Progress: 33067/33067 - Lines: 549 - Done");
            string[] sa = "avis [info]: 1920x1080 @ 23.98 fps (33067 frames)".Split(' ');

            return;


            Shell shell = new Shell("D:\\git\\avs2bdnxml-gui\\Debug\\avs2bdnxml.exe", "-t Title -l zho -v 720p -f 23.976 -a1 -p1 -b1 -m3 -o x:\\ss\\1\\1.xml -o x:\\ss\\1\\1.sup X:\\ss\\1\\1.avs", "X:\\ss\\1\\", this.OutputDataReceived);
            shell.Start();

            //int i = "00:10:08,580 --> 00:10:14,220".IndexOf("-->");
            //string[] sa = "00:10:08,580 --> 00:10:14,220".Split(new char[]{'-', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            //MessageBox.Show(sa[1]);
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

        private void MainForm_Load(object sender, EventArgs e)
        {

            

            //
        }






    }
}
