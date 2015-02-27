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
            public int SSecond { get; set; }

            public ASSTime(int hour = 0, int minute = 0, int second = 0, int ssecond = 0)
            {
                this.Hour = hour; this.Minute = minute; this.Second = second; this.SSecond = ssecond;
            }


            public long GetMSecond()
            {
                return ((this.Hour * 3600 * 1000) + (this.Minute * 60 * 1000) + (this.Second * 1000) + ((this.SSecond + 1) * 10));
            }

            public long GetSecond()
            {
                return ((this.Hour * 3600) + (this.Minute * 60) + (this.Second) + ((this.SSecond + 1) * 10 / 1000));
            }

            public static ASSTime Parse(string stime)
            {
                ASSTime at = new ASSTime();
                int hour, minute, second, ssecond;

                string[] sa = stime.Split(new char[]{'.'}, 2);

                if (sa.Length != 2)
                    return null;

                string sl = sa[0];
                string sr = sa[1];

                string[] saa = sl.Split(new char[]{':'}, 3);

                if (saa.Length != 3)
                    return null;

                
                int.TryParse(saa[0], out hour);
                int.TryParse(saa[1], out minute);
                int.TryParse(saa[2], out second);
                int.TryParse(sr, out ssecond);
                at.Hour = hour;
                at.Minute = minute;
                at.Second = second;
                at.SSecond = ssecond;
                return at;
            }



            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (obj is ASSTime)
                {
                    var at = obj as ASSTime;
                    return at.GetMSecond() == this.GetMSecond();
                }
                else
                    return false;
            }

            public override int GetHashCode()
            {
                return this.GetMSecond().GetHashCode();
            }



            public static ASSTime operator+ (ASSTime lt, ASSTime rt)
            {
                ASSTime at = new ASSTime();

                at.Hour = lt.Hour + rt.Hour;
                at.Minute = lt.Minute + rt.Minute;
                at.Second = lt.Second + rt.Second;
                at.SSecond = lt.SSecond + rt.SSecond;

                if (at.SSecond >= 100)
                {
                    at.Second += at.SSecond / 100;
                    at.SSecond = at.SSecond % 100;
                }

                if (at.Second >= 60)
                {
                    at.Minute += at.Second / 60;
                    at.Second = at.Second % 60;
                }

                if (at.Minute >= 60)
                {
                    at.Hour += at.Minute / 60;
                    at.Minute = at.Minute % 60;
                }

                return at;
            }


            public static ASSTime operator- (ASSTime lt, ASSTime rt)
            {
                if (lt == rt || lt < rt)
                    return new ASSTime();

                ASSTime at = new ASSTime();

                at.Hour = lt.Hour - rt.Hour;
                at.Minute = lt.Minute - rt.Minute;
                at.Second = lt.Second - rt.Second;
                at.SSecond = lt.SSecond - rt.SSecond;

                if (at.SSecond < 0)
                {
                    at.SSecond = 100 - Math.Abs(at.SSecond);
                    at.Second -= 1;
                }

                if (at.Second < 0)
                {
                    at.Second = 60 - Math.Abs(at.Second);
                    at.Minute -= 1;
                }

                if (at.Minute < 0)
                {
                    at.Minute = 60 - Math.Abs(at.Minute);
                    at.Hour -= 1;
                }

                return at;
            }



            public static bool operator== (ASSTime lt, ASSTime rt)
            {
                if (lt.GetMSecond() == rt.GetMSecond())
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
                if (lt.GetMSecond() < rt.GetMSecond())
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
