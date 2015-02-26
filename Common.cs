using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace avs2bdnxml_gui
{
    public class Common
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


        public class ASSTime
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Second { get; set; }
            public int MSecond { get; set; }

            public ASSTime Parse(string stime)
            {

                string[] sa = stime.Split(new char[]{'.'}, 2);

                if (sa.Length != 2)
                    return null;

                string sl = sa[0];
                string sr = sa[1];

                string[] saa = sl.Split(new char[]{':'}, 3);

                if (saa.Length != 3)
                    return null;

                int hour, minute, second, msecond;

                Int32.TryParse(saa[0], out hour);
                Int32.TryParse(saa[1], out minute);
                Int32.TryParse(saa[2], out second);
                Int32.TryParse(sr, out msecond);
                this.Hour = hour;
                this.Minute = minute;
                this.Second = second;
                this.MSecond = msecond;
                return this;
            }


            public static bool operator== (ASSTime lt, ASSTime rt)
            {
                if ((lt.Hour + lt.Minute + lt.Second + lt.MSecond) == rt.Hour + rt.Minute + rt.Second + rt.MSecond)
                {
                    return true;
                }

                return false;
            }

            public static bool operator!= (ASSTime lt, ASSTime rt)
            {
                if (!(lt == rt))
                {
                    return true;
                }

                return false;
            }

            public static bool operator< (ASSTime lt, ASSTime rt)
            {
                if ((lt.Hour + lt.Minute + lt.Second + lt.MSecond ) < (rt.Hour + rt.Minute + rt.Second + rt.MSecond))
                {
                    return true;
                }

                return false;
            }

            public static bool operator> (ASSTime lt, ASSTime rt)
            {
                if (!(lt < rt) && lt != rt)
                {
                    return true;
                }

                return false;
            }


        }

    }
}
