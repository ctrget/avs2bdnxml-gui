using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace avs2bdnxml_gui
{
    #region Class Common
    public class Common
    {
        #region Members
        public static Resolution[] ResolutionList = new Resolution[] { new Resolution(1920, 1080), new Resolution(1280, 720), new Resolution(720, 480), new Resolution(854, 480), new Resolution(1024, 576) };

        public static double[] FPSList = new double[] { 23.976, 29.970, 25, 24 };
        public enum FileType
        {
            ASS,
            SSA,
            SRT,
            REC
        }
        #endregion
        #region Class Resolution
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
        #endregion
        #region Class TaskData
        public class TaskData
        {
            public string FileName { get; set; }
            public string FileFullPath { get; set; }
            public string OutputPath { get; set; }
            public int ResolutionIndex { get; set; }
            public int FPSIndex { get; set; }
            public bool UseVSMod { get; set; }

        }
        #endregion
        #region Methods
        public static FileType GetFileType(string filename)
        {
            string ext = Path.GetExtension(filename).ToUpper();

            switch (ext)
            {
                case ".ASS": return FileType.ASS;
                case ".SSA": return FileType.SSA;
                case ".SRT": return FileType.SRT;
                default: return FileType.REC;
            }

        }

        public static List<string> ReadFile(string filename)
        {
            if (!File.Exists(filename))
            {
                return null;
            }

            List<string> ls = new List<string>();

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    do
                    {
                        string s = sr.ReadLine();

                        if (s.Trim() == "")
                        {
                            continue;
                        }

                        ls.Add(s);

                    } while (!sr.EndOfStream);
                }
            }

            return ls;
        }


        public static string PlusTC(string tc, double fps, int flong)
        {
            int hour, minute, second, frame;
            string shour, sminute, ssecond, sframe;
            string[] sa = tc.Split(':');
            int.TryParse(sa[0], out hour);
            int.TryParse(sa[1], out minute);
            int.TryParse(sa[2], out second);
            int.TryParse(sa[3], out frame);
            frame += flong;

            if (frame > fps)
            {
                second += (int)(frame / fps);
                frame = (int)(frame % fps);
            }

            if (second > 59)
            {
                minute += (int)(second / 60);
                second = second % 60;
            }

            if (minute > 59)
            {
                hour += (int)(minute / 60);
                minute = minute % 60;
            }

            shour = hour.ToString(); sminute = minute.ToString(); ssecond = second.ToString(); sframe = frame.ToString();

            if (hour < 10)
            {
                shour = "0" + shour;
            }

            if (minute < 10)
            {
                sminute = "0" + sminute;
            }

            if (second < 10)
            {
                ssecond = "0" + ssecond;
            }

            if (frame < 10)
            {
                sframe = "0" + sframe;
            }

            return shour + ":" + sminute + ":" + ssecond + ":" + sframe;
        }


        #endregion
        #region Class SUBTime
        public class SUBTime
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Second { get; set; }
            public int SSecond { get; set; }

            public SUBTime(int hour = 0, int minute = 0, int second = 0, int ssecond = 0)
            {
                this.Hour = hour; this.Minute = minute; this.Second = second; this.SSecond = ssecond;
            }


            public long GetMSecond()
            {
                return ((this.Hour * 3600 * 1000) + (this.Minute * 60 * 1000) + (this.Second * 1000) + ((this.SSecond)));
            }


            public long GetSecond()
            {
                return ((this.Hour * 3600) + (this.Minute * 60) + (this.Second) + ((this.SSecond) / 1000));
            }


            public static SUBTime Parse(string stime)
            {
                SUBTime at = new SUBTime();
                int hour, minute, second, ssecond;

                string[] sa = stime.Split(new char[] { '.' }, 2);

                if (sa.Length != 2)
                    return null;

                string sl = sa[0];
                string sr = sa[1];

                string[] saa = sl.Split(new char[] { ':' }, 3);

                if (saa.Length != 3)
                    return null;


                int.TryParse(saa[0], out hour);
                int.TryParse(saa[1], out minute);
                int.TryParse(saa[2], out second);
                int.TryParse(sr, out ssecond);
                at.Hour = hour;
                at.Minute = minute;
                at.Second = second;

                if (sr.Length == 2)
                {
                    ssecond *= 10;
                }

                at.SSecond = ssecond;
                return at;
            }



            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (obj is SUBTime)
                {
                    var at = obj as SUBTime;
                    return at.GetMSecond() == this.GetMSecond();
                }
                else
                    return false;
            }

            public override int GetHashCode()
            {
                return this.GetMSecond().GetHashCode();
            }


            public SUBTime GetAssTime()
            {
                this.SSecond /= 10;
                return this;
            }

            public static SUBTime operator +(SUBTime lt, SUBTime rt)
            {
                SUBTime at = new SUBTime();

                at.Hour = lt.Hour + rt.Hour;
                at.Minute = lt.Minute + rt.Minute;
                at.Second = lt.Second + rt.Second;
                at.SSecond = lt.SSecond + rt.SSecond;

                if (at.SSecond >= 1000)
                {
                    at.Second += at.SSecond / 1000;
                    at.SSecond = at.SSecond % 1000;
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


            public static SUBTime operator -(SUBTime lt, SUBTime rt)
            {
                if (lt == rt || lt < rt)
                    return new SUBTime();

                SUBTime at = new SUBTime();

                at.Hour = lt.Hour - rt.Hour;
                at.Minute = lt.Minute - rt.Minute;
                at.Second = lt.Second - rt.Second;
                at.SSecond = lt.SSecond - rt.SSecond;

                if (at.SSecond < 0)
                {
                    at.SSecond = 1000 - Math.Abs(at.SSecond);
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



            public static bool operator ==(SUBTime lt, SUBTime rt)
            {
                if (lt.GetMSecond() == rt.GetMSecond())
                {
                    return true;
                }

                return false;
            }

            public static bool operator !=(SUBTime lt, SUBTime rt)
            {
                if (!(lt == rt))
                {
                    return true;
                }

                return false;
            }

            public static bool operator <(SUBTime lt, SUBTime rt)
            {
                if (lt.GetMSecond() < rt.GetMSecond())
                {
                    return true;
                }

                return false;
            }

            public static bool operator >(SUBTime lt, SUBTime rt)
            {
                if (!(lt < rt) && lt != rt)
                {
                    return true;
                }

                return false;
            }


        }

        #endregion
    }
    #endregion

}
