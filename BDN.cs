using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace avs2bdnxml_gui
{
    public class BDN
    {
        private XmlDocument _bdnxml;
        private string _bdnfile;
        private Common.Resolution _res;
        private double _fps;
        #region Constructor
        public BDN(string fname, double fps, Common.Resolution res)
        {
            this._bdnxml = new XmlDocument();
            this._bdnxml.Load(fname);
            this._bdnfile = fname;
            this._fps = fps;
            this._res = res;
        }
        #endregion
        #region Class BDNXML
        public class BDNXML
        {
            
            public BDNHeader BDNHeader { get; set; }
            public List<BDNEvent> BDNEvents { get; set; }

            public BDNXML()
            {
                this.BDNHeader = new BDNHeader();
                this.BDNEvents = new List<BDNEvent>();
            }

        }
        #endregion

        #region Class BDNHeader
        public class BDNHeader
        {
            public string Titile { get; set; }
            public string Content { get; set; }
            public string Code { get; set; }
            public string VideoFormat { get; set; }
            public double FrameRate { get; set; }
            public string DropFrame { get; set; }
            public string FirstEventInTC { get; set; }
            public string LastEventOutTC { get; set; }
            public string ContentInTC { get; set; }
            public string ContentOutTC { get; set; }
            public int NumberofEvents { get; set; }
            public string Type { get; set; }

        }
        #endregion
        #region Class BDNEvent
        public class BDNEvent
        {
            public string Forced { get; set; }
            public string InTC { get; set; }
            public string OutTC { get; set; }
            public string Width { get; set; }
            public string Height { get; set; }
            public string X { get; set; }
            public string Y { get; set; }
            public string Graphic_File { get; set; }

        }
        #endregion
        #region Methods

        /*
        public void LoadBDNXML(string fname)
        {
            if(!File.Exists(fname))
            {
                return;
            }

            XElement xe = XElement.Load(fname);
            

            IEnumerable<XElement> h_nodes = from target in xe.Elements("Description")
                                                .Descendants()
                                                select target;

            IEnumerable<XElement> e_nodes = from target in xe.Elements("Events")
                                                .Descendants("Event")
                                            select target;


            foreach(var hnode in h_nodes)
            {
                if (hnode.Name.LocalName == "Name")
                {
                    this._bdnxml.BDNHeader.Titile = hnode.Attribute("Title").Value;
                    this._bdnxml.BDNHeader.Content = hnode.Attribute("Content").Value;
                }

                if (hnode.Name.LocalName == "Language")
                {
                    this._bdnxml.BDNHeader.Code = hnode.Attribute("Code").Value;
                }

                if (hnode.Name.LocalName == "Format")
                {
                    this._bdnxml.BDNHeader.VideoFormat = hnode.Attribute("VideoFormat").Value;
                    double fps = 0;
                    double.TryParse(hnode.Attribute("FrameRate").Value, out fps);
                    this._bdnxml.BDNHeader.FrameRate = fps;
                    this._bdnxml.BDNHeader.DropFrame = hnode.Attribute("DropFrame").Value;
                }

                if (hnode.Name.LocalName == "Events")
                {
                    this._bdnxml.BDNHeader.FirstEventInTC = hnode.Attribute("FirstEventInTC").Value;
                    this._bdnxml.BDNHeader.LastEventOutTC = hnode.Attribute("LastEventOutTC").Value;
                    this._bdnxml.BDNHeader.ContentInTC = hnode.Attribute("ContentInTC").Value;
                    this._bdnxml.BDNHeader.ContentOutTC = hnode.Attribute("ContentOutTC").Value;
                    int ne = 0;
                    Int32.TryParse(hnode.Attribute("NumberofEvents").Value, out ne);
                    this._bdnxml.BDNHeader.NumberofEvents = ne;
                    this._bdnxml.BDNHeader.Type = hnode.Attribute("Type").Value;

                }

            }

            
            foreach(var enode in e_nodes)
            {
                BDNEvent be = new BDNEvent();
                XElement g_node = enode.Element("Graphic");
                be.Forced = enode.Attribute("Forced").Value;
                be.InTC = enode.Attribute("InTC").Value;
                be.OutTC = enode.Attribute("OutTC").Value;
                be.Width = g_node.Attribute("Width").Value;
                be.Height = g_node.Attribute("Height").Value;
                be.X = g_node.Attribute("X").Value;
                be.Y = g_node.Attribute("Y").Value;
                be.Graphic_File = g_node.Value;
                this._bdnxml.BDNEvents.Add(be);
            }
        }
  
         
        */



        public void SaveBDN()
        {
            this._bdnxml.Save(this._bdnfile);
        }


        public void SetBDNEventCount(int pi)
        {
            XmlNode HeadNode = this._bdnxml.SelectSingleNode("/BDN/Description/Events");
            XmlNode EventCountNode = HeadNode.Attributes.GetNamedItem("NumberofEvents");
            Int64 ecount = 0;
            Int64.TryParse(EventCountNode.Value, out ecount);
            ecount += pi;
            EventCountNode.Value = ecount.ToString();
        }

        public string GetBDNLastOut()
        {
            XmlNode HeadNode = this._bdnxml.SelectSingleNode("/BDN/Description/Events");
            XmlNode LastOutNode = HeadNode.Attributes.GetNamedItem("LastEventOutTC");
            return LastOutNode.Value;
        }


        public void InsertBDNEvent(string intc, string outtc)
        {
            XmlNode EventRoot = this._bdnxml.SelectSingleNode("/BDN/Events");
            XmlElement NewEvent = this._bdnxml.CreateElement("Event");
            NewEvent.SetAttribute("Forced", "False");
            NewEvent.SetAttribute("InTC", intc);
            NewEvent.SetAttribute("OutTC", outtc);
            XmlElement EventImg = this._bdnxml.CreateElement("Graphic");
            EventImg.InnerText = "0.png";
            EventImg.SetAttribute("Width", this._res.X.ToString());
            EventImg.SetAttribute("Height", this._res.Y.ToString());
            EventImg.SetAttribute("X", "0");
            EventImg.SetAttribute("Y", "0");
            NewEvent.AppendChild(EventImg);
            EventRoot.AppendChild(NewEvent);
            this.SetBDNEventCount(1);
        }


        public void InsertBlack(bool bfirst, string pngfile)
        {
            if (!File.Exists(pngfile))
            {
                Common.SavePng(pngfile);
            }

            if (bfirst)
            {
                this.InsertBDNEvent("00:00:00:00", "00:00:00:08");

            }
            else
            {
                string lastout = this.GetBDNLastOut();
                string lastblkin = Common.PlusTC(lastout, this._fps, 1500);
                string lastblkout = Common.PlusTC(lastblkin, this._fps, 200);
                this.InsertBDNEvent(lastblkin, lastblkout);
            }

        }

        #endregion


    }
}
