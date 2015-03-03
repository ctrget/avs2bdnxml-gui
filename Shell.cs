using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace avs2bdnxml_gui
{
    public class Shell
    {
        private string _filename;
        private string _args;
        private string _workdir;
        private bool _isrunning = false;
        private int _exitcode = 0;
        private Process _process;
        

        public string filename { get { return this._filename; } }
        public string args { get { return this._args; } }
        public string workdir { get { return this._workdir; } }
        public bool HasExited { get { return this._process.HasExited; } }
        public int exitcode { get { return this._exitcode; } }



        public Shell(string filename, string args, string workdir, DataReceivedEventHandler OutputDataReceived)
        {
            this._filename = filename;
            this._args = args;
            this._workdir = workdir;
            this._process = new Process();
            this._process.StartInfo.FileName = this._filename;
            this._process.StartInfo.Arguments = this._args;
            this._process.StartInfo.WorkingDirectory = this._workdir;
            this._process.StartInfo.RedirectStandardOutput = true;
            this._process.StartInfo.RedirectStandardError = true;
            this._process.StartInfo.UseShellExecute = false;
            this._process.StartInfo.CreateNoWindow = true;
            this._process.OutputDataReceived += OutputDataReceived;
            this._process.ErrorDataReceived += OutputDataReceived;
        }





        public void Start()
        {
            if (!this._process.Start())
            {
                this._exitcode = this._process.ExitCode;
                this._isrunning = false;
                return;
            }

            this._isrunning = true;
            this._process.BeginOutputReadLine();
            this._process.BeginErrorReadLine();

        }


        public void Stop()
        {
            this._process.Kill();
            this._isrunning = false;
        }






    }
}
