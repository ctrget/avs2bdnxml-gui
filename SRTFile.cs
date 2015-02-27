using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace avs2bdnxml_gui
{
    #region Class SRTFile
    public class SRTFile
    {
        #region Class SRT_File
        public class SRT_File
        {
            List<SRT_Line> Lines { get; set; }
            public SRT_File()
            {
                this.Lines = new List<SRT_Line>();
            }
        }
        #endregion
        #region Class SRT_Line
        public class SRT_Line
        {
            public int LineNO { get; set; }
            public Common.SUBTime Start { get; set; }
            public Common.SUBTime End { get; set; }
            public List<string> Texts { get; set; }
            
            public SRT_Line(int lineno, Common.SUBTime start, Common.SUBTime end)
            {
                this.Start = new Common.SUBTime();
                this.End = new Common.SUBTime();
                this.Texts = new List<string>();
            }

            public void AddText(string text)
            {
                this.Texts.Add(text);
            }
        }
        #endregion
        #region Methods
        public static SRT_File LoadFromFile(string filename)
        {
            List<string> ls = Common.ReadFile(filename);

            if (ls == null)
            {
                return null;
            }

            SRT_File srtfile = new SRT_File();

            foreach (string s in ls)
            {
                int index = s.IndexOf("-->");

                if (index < 0)
                {
                    continue;
                }
                
                string[] sa = s.Split(new char[] { ':' }, 2);

                if (sa.Length != 2)
                {
                    continue;
                }


                string sl = sa[0];
                string sr = sa[1].TrimStart(' ');

                

            }

            return srtfile;
        }
        #endregion

    }
    #endregion
}
