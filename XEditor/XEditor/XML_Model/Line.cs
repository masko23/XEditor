using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Line
    {
        // Attributes
        public String Name { get; }
        public Tracks Tracks { get; }
        public Starts Starts { get; }

        // Constructor
        public Line(string p_name)
        {
            Name = p_name;
            Tracks = new Tracks();
            Starts = new Starts();
        }

        // Functionality

        // Get Track by ID
        public Track getTrack(int p_id)
        {
            Track retTrack = null;
            retTrack = Tracks.getTrack(p_id);

            return retTrack;
        }
    }
}
