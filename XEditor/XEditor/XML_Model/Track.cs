using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Track
    {
        // Attributes
        public int ID { get; }
        public List<Stop> Stops { get; }

        // Constructor
        public Track(int p_id)
        {
            ID = p_id;
            Stops = new List<Stop>();
        }

        // Functionality
        /* not needed yet */
    }
}
