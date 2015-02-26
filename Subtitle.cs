using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace avs2bdnxml_gui
{
    public partial class Subtitle
    {

    
        private static List<string> ReadFile(string filename)
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

                        if (s.Trim() == "" || s[0] == ';' || s.ToUpper().IndexOf("COMMENT") >= 0)
                        {
                            continue;
                        }

                        ls.Add(s);

                    } while (!sr.EndOfStream);
                }
            }

            return ls;
        }



        public static int ASS_GetFrameCount(string filename, double fps, int filetype)
        {
            List<string> ls = ReadFile(filename);

            if (ls == null)
            {
                return 0;
            }




            return 0;
        }



        public static ASSFile ASS_LoadFromFile(string filename)
        {
            List<string> ls = ReadFile(filename);

            if (ls == null)
            {
                return null;
            }

            ASSFile assfile = new ASSFile();

            foreach (string s in ls)
            {
                string[] sa = s.Split(new char[] { ':' }, 2);



                if (sa.Length != 2)
                    continue;

                string sl = sa[0];
                string sr = sa[1].TrimStart(' ');
    
                switch (sl.ToUpper())
                {
                    case "TITLE": assfile.Header.Title = sr; break;
                    case "ORIGINAL_SCRIPT": assfile.Header.Original_Script = sr; break;
                    case "ORIGINAL_TRANSLATION": assfile.Header.Original_Translation = sr; break;
                    case "ORIGINAL_EDITING": assfile.Header.Original_Editing = sr; break;
                    case "Original_Timing": assfile.Header.Original_Timing = sr; break;
                    case "SCRIPT_UPDATED_BY": assfile.Header.Script_Updated_By = sr; break;
                    case "UPDATE_DETAILS": assfile.Header.Update_Details = sr; break;
                    case "SCRIPTTYPE": assfile.Header.ScriptType = sr; break;
                    case "WRAPSTYLE": assfile.Header.WrapStyle = sr; break;
                    case "SCALEDBORDERANDSHADOW": assfile.Header.ScaledBorderAndShadow = sr; break;
                    case "SYNCH_POINT": assfile.Header.Synch_Point = sr; break;
                    case "COLLISIONS": assfile.Header.Collisions = sr; break;
                    case "PLAYDEPTH": assfile.Header.PlayDepth = sr; break;
                    case "PLAYRESX": assfile.Header.PlayResX = sr; break;
                    case "PLAYRESY": assfile.Header.PlayResY = sr; break;
                    case "TIMER": assfile.Header.Timer = sr; break;

                    case "STYLE":

                        string[] sas = sr.Split(new char[] { ',' }, 23);

                        if (sas.Length != 23)
                            break;

                        assfile.Styles.Add(new ASSFile.ASS_Style(sas[0], sas[1], sas[2], sas[3], sas[4], sas[5], sas[6], sas[7], sas[8],
                        sas[9], sas[10], sas[11], sas[12], sas[13], sas[14], sas[15], sas[16], sas[17], sas[18], sas[19], sas[20], sas[21], sas[22]));
                        break;

                    case "DIALOGUE":
                        string[] sae = sr.Split(new char[] { ',' }, 10);

                        if (sae.Length != 10)
                            break;

                        assfile.Events.Add(new ASSFile.ASS_Event(sae[0], sae[1], sae[2], sae[3], sae[4], sae[5], sae[6], sae[7], sae[8], sae[9]));
                        break;

                }





            }

            return assfile;

        }


        public static List<ASSFile.ASS_Style> ASS_GetStyles(string filename)
        {
            List<string> ls = ReadFile(filename);

            if (ls == null)
            {
                return null;
            }





            return null;
        }



    }
}
