using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Station
    {
        // Basic attributes
        public int ID { get; private set; }
        public String Name { get; set; }

        // Constructor
        public Station(int p_iId, String p_strName)
        {
            ID = p_iId;
            Name = p_strName;
        }

        // Functionality


        override public string ToString()
        {
            string ret = Name;

            return ret;
        }
    }
}
