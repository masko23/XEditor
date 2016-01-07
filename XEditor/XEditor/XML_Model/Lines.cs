using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Lines
    {
        // Attributes
        public List<Line> LineList { get; private set; }

        // Constructor
        public Lines()
        {
            LineList = new List<Line>();
        }

        // Functionality
        
        // Get a Line by Name
        public Line getLine(string p_name)
        {
            Line retLine = null;

            foreach(Line line in LineList)
            {
                if(line.Name.Equals(p_name))
                {
                    retLine = line;
                }
            }

            return retLine;
        }

        // add a Line to the list
        public void addLine(Line line)
        {
            LineList.Add(line);
        }

        // Remove a Line by reference
        public void removeLine(Line p_line)
        {
            LineList.Remove(p_line);
        }

        // Remove a Line by Name
        public void removeLine(string p_name)
        {
            LineList.Remove(getLine(p_name));
        }
    }
}
