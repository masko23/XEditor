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
        public String Location { get; private set; }
        public Stations Stations { get; private set; }
        public Lines Lines { get; private set; }

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

        public void save(string path)
        {
            string xmlout;
            string outpath = path;

            using(StreamWriter sw = new StreamWriter(outpath))
            {
                // write xml declaration
                xmlout = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                sw.WriteLine(xmlout);

                // write header tag in the file
                xmlout = "<Schedule>";
                sw.WriteLine(xmlout);

                // write Stations in the file
                xmlout = "\t<Stations>";
                sw.WriteLine(xmlout);
                foreach(Station stat in Stations.StationList)
                {
                    xmlout = "\t\t<Station id=\"" + stat.ID.ToString() +
                                "\">" + stat.Name + "</Station>";
                    sw.WriteLine(xmlout);
                }
                xmlout = "\t</Stations>";
                sw.WriteLine(xmlout);

                // write Lines in the file
                xmlout = "\t<Lines>";
                sw.WriteLine(xmlout);
                foreach(Line line in Lines.LineList)
                {
                    // write Line start tag
                    xmlout = "\t\t<Line name=\"" + line.Name + "\">";
                    sw.WriteLine(xmlout);

                    // write tracks from line
                    xmlout = "\t\t\t<Tracks>";
                    sw.WriteLine(xmlout);
                    foreach(Track track in line.Tracks.TrackList)
                    {
                        xmlout = "\t\t\t\t<Track id = \"" + track.ID + "\">";
                        sw.WriteLine(xmlout);

                        foreach(Stop stop in track.Stops)
                        {
                           xmlout = "\t\t\t\t\t<Stop station=\"" + stop.Station.ID + "\">" + stop.Delay + "</Stop>";
                           sw.WriteLine(xmlout);
                        }

                        xmlout = "\t\t\t\t</Track>";
                        sw.WriteLine(xmlout);
                    }
                    xmlout = "\t\t\t</Tracks>";
                    sw.WriteLine(xmlout);

                    // write starts from line
                    xmlout = "\t\t\t<Starts>";
                    sw.WriteLine(xmlout);

                    foreach(Start start in line.Starts.StartList)
                    {// <Start track="0" active="work">05:03</Start>
                        xmlout = "\t\t\t\t<Start track=\"" + start.Track.ID + "\" active=\"" + start.Active + "\">"
                                    + start.Time + "</Start>";
                        sw.WriteLine(xmlout);
                    }

                    xmlout = "\t\t\t</Starts>";
                    sw.WriteLine(xmlout);

                    // write Line end tag
                    xmlout = "\t\t</Line>";
                    sw.WriteLine(xmlout);
                }
                xmlout = "\t</Lines>";
                sw.WriteLine(xmlout);


                // write end header tag
                xmlout = "</Schedule>";
                sw.Write(xmlout);

                // close file
                sw.Close();
            }
        }
    }
}
