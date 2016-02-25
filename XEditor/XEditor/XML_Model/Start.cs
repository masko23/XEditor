using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Start
    {
        // Attributes
        public Track Track { get; set; }
        public string Active { get; set; }
        public string Time { get; set; }

        // Constructor
        public Start(Track p_track, string p_active, string p_time)
        {
            Track = p_track;
            Active = p_active;
            Time = p_time;
        }

        public override string ToString()
        {
            string retstr = Time + " - " + Active + " - " + Track.ID.ToString();

            return retstr;
        }

    }
}
