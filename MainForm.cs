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
using System.Threading;

namespace avs2bdnxml_gui
{
    public partial class MainForm : Form
    {
        private static HashConfig _config = new HashConfig(Directory.GetCurrentDirectory() + "\\config.dat");
        private static string _avs2bdnxmlpath = Directory.GetCurrentDirectory() + "\\core\\avs2bdnxml.exe";
        private static string _vsfilterpath = Directory.GetCurrentDirectory() + "\\core\\VSFilter.dll";
        private static string _vsfiltermodpath = Directory.GetCurrentDirectory() + "\\core\\VSFilterMod.dll";
        private static Thread _procthread;
        private static Shell _shell;
        private static List<Common.TaskData> Task_Data_List = new List<Common.TaskData>();
        private static bool _bexit = false;
        private static int _last_task_index = -1;
        public MainForm()
        {
            InitializeComponent();
            cbxresolution.SelectedIndex = 0;
            cbxfps.SelectedIndex = 0;
            LoadConfig();
            _procthread = new Thread(ProcTaskList);
        }


        private void LoadConfig()
        {
            _config.LoadFromFile();
            Common.ConfigData cdata = (Common.ConfigData)_config.ReadKeyO("Config", "Default");

            if (cdata != null)
            {
                UpdateUI(cdata);
            }
        }

        private void SaveConfig()
        {
            Common.ConfigData cdata = GetCurrentConfig();
            _config.WriteKey("Config", "Default", cdata);
            _config.SaveFromFile();
        }

        private void UpdateUI(Common.ConfigData cdata)
        {
            cbxresolution.SelectedIndex = cdata.ResolutionIndex;
            cbxfps.SelectedIndex = cdata.FPSIndex;
            tbxlang.Text = cdata.Lang;
            num_x.Value = cdata.X_;
            num_y.Value = cdata.Y_;
            num_s.Value = cdata.S_;
            num_m.Value = cdata.M_;
            cbx_a.Checked = cdata.A_;
            cbx_p.Checked = cdata.P_;
            cbx_b.Checked = cdata.B_;
            cbxensup.Checked = cdata.BSup;
            cbxfblk.Checked = cdata.BFirstBlack;
            cbxeblk.Checked = cdata.BEndBlack;
            cbxenvsmod.Checked = cdata.BVSMod;
            tbxoutpath.Text = cdata.OutputPath;
        }


        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                ParseProgress(e.Data);
            }));


        }


        private void ParseProgress(string str)
        {

            if (str == null)
            {
                return;
            }

            if (str.IndexOf("Progress") < 0)
            {
                return;
            }

            string[] sa = str.Split(' ');

            if (sa.Length >= 5)
            {
                string tstr = sa[1];
                int fi = Int32.Parse(tstr.Split('/')[0]);
                int ti = Int32.Parse(tstr.Split('/')[1]);

                this.Invoke(new MethodInvoker(() =>
                {
                    procc.Maximum = ti;
                    procc.Value = fi;
                }));

            }

        }

        private void SetTotalProgress(int i)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                proct.Value = i;
            }));
        }


        private void LockUI(bool b)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (b)
                {
                    btnstart.Enabled = false;
                    btnstop.Enabled = true;
                    grbtaskdata.Enabled = false;
                    grbtasklst.Enabled = false;
                }
                else
                {
                    btnstart.Enabled = true;
                    btnstop.Enabled = false;
                    grbtaskdata.Enabled = true;
                    grbtasklst.Enabled = true;
                }
            }));

        }




        private Common.ConfigData GetCurrentConfig()
        {
            Common.ConfigData cdata = new Common.ConfigData();

            if (tbxoutpath.Text.Trim() == "")
            {
                tbxoutpath.Text = Directory.GetCurrentDirectory() + "\\";
            }

            cdata.ResolutionIndex = cbxresolution.SelectedIndex;
            cdata.FPSIndex = cbxfps.SelectedIndex;
            cdata.Lang = tbxlang.Text;
            cdata.X_ = (int)num_x.Value;
            cdata.Y_ = (int)num_y.Value;
            cdata.S_ = (int)num_s.Value;
            cdata.M_ = (int)num_m.Value;
            cdata.A_ = cbx_a.Checked;
            cdata.P_ = cbx_p.Checked;
            cdata.B_ = cbx_b.Checked;
            cdata.BSup = cbxensup.Checked;
            cdata.BFirstBlack = cbxfblk.Checked;
            cdata.BEndBlack = cbxeblk.Checked;
            cdata.BVSMod = cbxenvsmod.Checked;
            cdata.OutputPath = tbxoutpath.Text;
            return cdata;
        }

        private void MakeAvs(int index)
        {
            Common.TaskData tdata = Task_Data_List[index];
            List<string> olst = new List<string>();

            int fcount = 0;
            double fps;
            Common.Resolution res;
            string filemainname = Path.GetFileNameWithoutExtension(tdata.FileName);
            string outputpath = tdata.CData.OutputPath + "\\" + filemainname + "\\";
            fps = Common.FPSList[tdata.CData.FPSIndex];
            res = Common.ResolutionList[tdata.CData.ResolutionIndex];
            Common.FileType ftype = Common.GetFileType(tdata.FileFullPath);

            if (ftype == Common.FileType.ASS)
            {
                fcount = ASSFile.GetFrameCount(tdata.FileFullPath, fps);
            }
            else if (ftype == Common.FileType.SSA)
            {
                fcount = SSAFile.GetFrameCount(tdata.FileFullPath, fps);
            }

            fcount += 100;

            if (tdata.CData.BVSMod)
            {
                olst.Add("LoadPlugin(\"" + _vsfilterpath + "\")");
            }
            else
            {
                olst.Add("LoadPlugin(\"" + _vsfiltermodpath + "\")");
            }

            olst.Add("MaskSub(\"" + tdata.FileFullPath + "\", " + res.X.ToString() + ", " + res.Y.ToString() + ", " + fps.ToString() + ", " + fcount.ToString() + ")");


            if (tdata.CData.ResolutionIndex == 3)
            {
                olst.Add("LanczosResize(720,480)");
            }
            else if (tdata.CData.ResolutionIndex == 4)
            {
                olst.Add("LanczosResize(720,576)");
            }
            else
            {
                olst.Add("LanczosResize(" + res.X.ToString() + ", " + res.Y.ToString() + ")");
            }

            if (!Directory.Exists(tdata.CData.OutputPath))
            {
                Directory.CreateDirectory(tdata.CData.OutputPath);
            }

            string avsfile = outputpath + filemainname + ".avs";

            if (!Directory.Exists(outputpath))
            {
                Directory.CreateDirectory(outputpath);
            }

            if (File.Exists(avsfile))
            {
                File.Delete(avsfile);
            }

            FileStream fs = File.Create(avsfile);
            StreamWriter sr = new StreamWriter(fs);
            sr.AutoFlush = true;

            foreach (string s in olst)
            {
                sr.WriteLine(s);
            }

            sr.Close();
            fs.Close();

        }



        private void AddTask(string fname)
        {
            lbxtask.Items.Add(Path.GetFileName(fname));
            Common.TaskData tdata = new Common.TaskData();
            tdata.CData = GetCurrentConfig();
            tdata.FileFullPath = fname;
            tdata.FileName = Path.GetFileName(fname);
            Task_Data_List.Add(tdata);
        }

        private void RemoveTask(int index)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                Task_Data_List.RemoveAt(index);


                lbxtask.Items.RemoveAt(index);

            }));
        }


        private void ProcTaskList()
        {
            int i = 0;

            while (lbxtask.Items.Count > 0)
            {
                if (_bexit)
                {
                    break;
                }

                ProcTask(0);
                ++i;
                SetTotalProgress(i);
            }

            LockUI(false);
        }

        private void ProcTask(int index)
        {
            Common.TaskData tdata = Task_Data_List[index];
            MakeAvs(index);
            string workpath = tdata.CData.OutputPath;
            string filemainname = Path.GetFileNameWithoutExtension(tdata.FileName);
            string resolution = (string)cbxresolution.Items[tdata.CData.ResolutionIndex];
            string fps = (string)cbxfps.Items[tdata.CData.FPSIndex];
            string _x = "", _y = "", _s = "", _m = "", _a = "", _b = "", _p = "", sup = "";

            if (tdata.CData.X_ > 0)
            {
                _x = " -x" + tdata.CData.X_.ToString() + " ";
            }

            if (tdata.CData.Y_ > 0)
            {
                _x = " -y" + tdata.CData.Y_.ToString() + " ";
            }

            if (tdata.CData.S_ > 0)
            {
                _s = " -s" + tdata.CData.S_.ToString() + " ";
            }

            if (tdata.CData.M_ > 0)
            {
                _m = " -m" + tdata.CData.M_.ToString() + " ";
            }

            if (tdata.CData.A_)
            {
                _a = " -a1 ";
            }

            if (tdata.CData.B_)
            {
                _b = " -b1 ";
            }

            if (tdata.CData.P_)
            {
                _p = " -p1 ";
            }

            if (tdata.CData.BSup)
            {
                sup = " -o \"" + workpath + "\\" + filemainname + "\\" + filemainname + ".sup\" ";
            }

            string param = "-t \"" + filemainname + "\" -l " + tdata.CData.Lang + " -v " + resolution + " -f " + fps + _x + _y + _s + _m + _a + _b + _p + "-o \"" + workpath + "\\" + filemainname + "\\" + filemainname + ".xml\"" + sup + "\"" + workpath + "\\" + filemainname + "\\" + filemainname + ".avs\"";
            _shell = new Shell(_avs2bdnxmlpath, param, workpath, OutputDataReceived);
            _shell.Start();

            while (!_shell.HasExited)
            {
                if (_bexit)
                {
                    _shell.Stop();
                    return;
                }
                Thread.Sleep(10);
            }


            RemoveTask(index);


        }


        private void btnstart_Click(object sender, EventArgs e)
        {
            if (lbxtask.Items.Count == 0)
            {
                return;
            }

            if (!File.Exists(_avs2bdnxmlpath) || !File.Exists(_vsfilterpath) || !File.Exists(_vsfiltermodpath))
            {
                MessageBox.Show(this, "找不到核心文件!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _bexit = false;
            proct.Maximum = lbxtask.Items.Count;
            LockUI(true);
            _procthread.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            _bexit = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
        }



        private void lbxtask_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }


        private void lbxtask_DragDrop(object sender, DragEventArgs e)
        {
            string[] sa = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string s in sa)
            {
                string ext = Path.GetExtension(s).ToUpper();

                if (ext == ".ASS" || ext == ".SSA")
                {
                    AddTask(s);
                }

            }
        }


        private void lbxtask_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (lbxtask.SelectedItems.Count > 0)
                {
        

                    SaveConfig();

                    if (_last_task_index >= 0)
                    {
                        Task_Data_List[_last_task_index].CData = GetCurrentConfig();
                    }


                    lbltasksel.Text = (string)lbxtask.Items[lbxtask.SelectedIndex];
                    Common.TaskData tdata = Task_Data_List[lbxtask.SelectedIndex];
                    UpdateUI(tdata.CData);
                    _last_task_index = lbxtask.SelectedIndex;
                }
                else
                {
                    lbltasksel.Text = "全局设置";
                }
            }
        }

        private void tmnuremove_Click(object sender, EventArgs e)
        {
            if (lbxtask.Items.Count > 0 && lbxtask.SelectedItems.Count > 0)
            {
                RemoveTask(lbxtask.SelectedIndex);
            }
        }

        private void tmnuclear_Click(object sender, EventArgs e)
        {
            lbxtask.Items.Clear();
            Task_Data_List.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }







    }
}
