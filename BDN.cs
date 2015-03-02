using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace avs2bdnxml_gui
{
    public class BDN
    {
        private BDNXML _bdnxml;
        #region Constructor
        public BDN()
        {
            this._bdnxml = new BDNXML();
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



        #endregion


    }
}
