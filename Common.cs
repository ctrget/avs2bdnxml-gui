using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace avs2bdnxml_gui
{
    public partial class MainForm : Form
    {
        public static Resolution[] ResolutionList = new Resolution[] { new Resolution(1920, 1080), new Resolution(1280, 720), new Resolution(720, 480), new Resolution(854, 480), new Resolution(1024, 576) };

        public static double[] FPSList = new double[] { 23.976, 29.970, 25, 24 };
        public enum FileType
        {
            ASS,
            SRT
        }

        public class Resolution
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Resolution(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
        
        public class TaskData
        {
            public string FileName { get; set; }
            public string FileFullPath { get; set; }
            public string OutputPath { get; set; }
            public int ResolutionIndex { get; set; }
            public int FPSIndex { get; set; }
            public bool UseVSMod { get; set; }

        }




    }
}
