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
        public int ID { get; set; }
        public List<Stop> Stops { get; private set; }

        // Constructor
        public Track(int p_id)
        {
            ID = p_id;
            Stops = new List<Stop>();
        }

        public override string ToString()
        {
            return ID.ToString();
        }

        // Functionality
        /* not needed yet */
    }
}
