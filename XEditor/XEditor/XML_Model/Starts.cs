using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Starts
    {
        // Attributes
        public List<Start> StartList { get; private set; }

        // Constructor
        public Starts()
        {
            StartList = new List<Start>();
        }

        // Functionality
        
        // add new Start
        public void addStart(Start p_start)
        {
            StartList.Add(p_start);
        }

        // remove a Start by reference
        public void removeStart(Start p_start)
        {
            StartList.Remove(p_start);
        }
    }
}
