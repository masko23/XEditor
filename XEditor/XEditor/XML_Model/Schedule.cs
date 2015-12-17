using System;
using System.Collections.Generic;
using System.IO;
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

        public void save()
        {
            string xmlout;
            string outpath = Path.Combine(Directory.GetCurrentDirectory(),
                   "VeSchedule_new.xml"
                   );

            using(StreamWriter sw = new StreamWriter(outpath))
            {
                // write header tag in the file
                xmlout = "<Schedule>";
                sw.WriteLine(xmlout);

                // write Stations in the file
                xmlout = "\t<Stations>";
                sw.WriteLine(xmlout);
                foreach(Station stat in Stations.StationList)
                {
                    xmlout = "\t\t<Station id=\"" + stat.ID.ToString() +
                                "\">" + stat.Name + "<\\Station>";
                    sw.WriteLine(xmlout);
                }
                xmlout = "\t<\\Stations>";
                sw.WriteLine(xmlout);


                // write end header tag
                xmlout = "<\\Schedule>";
                sw.WriteLine(xmlout);

                // close file
                sw.Close();
            }
        }
    }
}
