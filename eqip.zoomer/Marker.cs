using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eqip.zoomer
{
    public class Marker
    {
        string yes = "yes";
        string no = "no";

        [XmlAttribute]
        public int position_x { get; set; }

        [XmlAttribute]
        public int position_y { get; set; }

        [XmlAttribute]
        public int width { get; set; }

        [XmlAttribute]
        public float zoom_factor_percentage { get; set; }

        [XmlIgnore]
        public bool show_tool_tip { get; set; }

        [XmlAttribute("show_tool_tip"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string show_tool_tipString
        {
            get { return show_tool_tip ? yes : no; }
            set
            {
                if (value == yes)
                {
                    show_tool_tip = true;
                }
                else if (value == no)
                {
                    show_tool_tip = false;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        [XmlText]
        public string content { get; set; }
    }
}
