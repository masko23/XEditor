using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Schedule
    {
        // Attributes
        public String Location { get; }
        public Stations Stations { get; }
        public Lines Lines { get; }

        // Constructor
        public Schedule(String p_Loc)
        {
            Location = p_Loc;
            Stations = new Stations();
            Lines = new Lines();
        }

        // Functionality

        /* For easier accessibility and faster solution
           Stations and Lines are accessible as properties.
           Therefor add/get/remove functions are unnecessary */
    }
}
