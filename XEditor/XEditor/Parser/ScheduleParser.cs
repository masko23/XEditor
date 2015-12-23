using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using XEditor.XML_Model;

namespace XEditor.Parser
{
    class ScheduleParser
    {
        private XmlTextReader reader;
        private XmlDocument document;
        private string path;
        private Schedule schedule;

        public ScheduleParser(Schedule pschedule)
        {
            schedule = pschedule;

            path = Path.Combine(Directory.GetCurrentDirectory(),
                   "VeSchedule.xml"
                   );

            try
            { 
                reader = new XmlTextReader(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public void read()
        {
            try
            {
                reader.Read();
                parse();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void parse()
        {
            document = new XmlDocument();
            document.Load(reader);

            try
            {
                XmlNodeList nList = document.DocumentElement.ChildNodes;

                foreach(XmlNode node in nList)
                {
                    switch(node.Name)
                    {
                        case "Stations":
                            parseStations(node);
                            break;
                        case "Lines":
                            parseLines(node);
                            break;
                        default:
                            /* do nothing */
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void parseLines(XmlNode node)
        {
            XmlNodeList lines = node.ChildNodes;

            foreach(XmlNode lNode in lines)
            {
                parseLine(lNode);
            }
        }

        private void parseLine(XmlNode lNode)
        {
            string lName = lNode.Attributes["name"].Value;
            Line line = new Line(lName);

            XmlNodeList nList = lNode.ChildNodes;

            foreach(XmlNode node in nList)
            {
                switch(node.Name)
                {
                    case "Tracks":
                        parseTracks(node,line);
                        break;
                    case "Starts":
                        parseStarts(node,line);
                        break;
                    default:
                        break;
                }
            }

            schedule.Lines.addLine(line);
        }

        private void parseTracks(XmlNode node,Line line)
        { 
            XmlNodeList tracks = node.ChildNodes;

            Track track;

            foreach(XmlNode tNode in tracks)
            {
                int tId;
                bool idOk = Int32.TryParse(tNode.Attributes["id"].Value,out tId);
                if(!idOk)
                {
                    tId = -1;
                }

                track = new Track(tId);
                parseStops(tNode, track);

                line.Tracks.addTrack(track);

            }
        }

        private void parseStops(XmlNode tNode, Track track)
        {
            XmlNodeList stopList = tNode.ChildNodes;

            Stop stop;
            int delay;
            int stId;
            Station station;
            bool parOk;
            foreach(XmlNode sNode in stopList)
            {
                parOk = Int32.TryParse(sNode.Attributes["station"].Value, out delay);
                if(!parOk)
                {
                    delay = -1;
                }

                parOk = Int32.TryParse(sNode.InnerText, out stId);
                if(!parOk)
                {
                    stId = -1;
                }

                station = schedule.Stations.getStation(stId);
                stop = new Stop(station, delay);

                track.Stops.Add(stop);
            }
        }

        private void parseStarts(XmlNode node,Line line)
        {
           
        }

        private void parseStations(XmlNode node)
        {
            XmlNodeList stations = node.ChildNodes;

            foreach (XmlNode sNode in stations)
            {
                string sName = sNode.InnerText;
                int sId;
                bool idOk = Int32.TryParse(sNode.Attributes["id"].Value, out sId);

                if(!idOk)
                {
                    sId = -1;
                }

                Station station = new Station(sId, sName);
                schedule.Stations.addStation(station);
                /*
                xLogger.add("New Station:"
                              + Environment.NewLine + "\tName: " + station.Name
                              + Environment.NewLine + "\tID: " + station.ID
                              + Environment.NewLine);
                              */
            }
        }
    }
}
