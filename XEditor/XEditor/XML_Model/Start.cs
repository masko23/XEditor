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
        public Track Track { get; private set; }
        public string Active { get; private set; }
        public string Time { get; private set; }

        // Constructor
        public Start(Track p_track, string p_active, string p_time)
        {
            Track = p_track;
            Active = p_active;
            Time = p_time;
        }
    }
}
