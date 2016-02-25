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

        public ScheduleParser(Schedule pschedule,string _path)
        {
            schedule = pschedule;

            path = _path;

            try
            {
                if (File.Exists(path))
                {
                    reader = new XmlTextReader(path);
                }
                else
                { 
                    path = null;
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public bool read()
        {
            if (path == null) return false;

            try
            {
                reader.Read();
                parse();
                reader.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;

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
                parOk = Int32.TryParse(sNode.Attributes["station"].Value, out stId);
                if(!parOk)
                {
                    stId = -1;
                }

                parOk = Int32.TryParse(sNode.InnerText, out delay);
                if (!parOk)
                {
                    delay = -1;
                }

                station = schedule.Stations.getStation(stId);
                /*
                // fail check
                if(station == null)
                {
                    xLogger.add("station is null:\r\nstId:" + stId+"\r\ntracknum:"+track.ID
                                    +"\r\ninner: " + sNode.InnerText);
                }
                else
                {
                    xLogger.add("new station: \r\nstId:" + stId + "\r\nname:" + station.Name + "-" + station.ID
                                    +"\r\ninner: "+ sNode.InnerText);
                }   
                */
                stop = new Stop(station, delay);

                track.Stops.Add(stop);
            }
        }

        private void parseStarts(XmlNode node,Line line)
        {// <Start track="0" active="work">05:03</Start>
            XmlNodeList starts = node.ChildNodes;

            int tracknum;
            string active;
            string time;
            Track track;
            Start start;

            foreach(XmlNode sNode in starts)
            {
                bool pOk = Int32.TryParse(sNode.Attributes["track"].Value, out tracknum);
                if(!pOk)
                {
                    tracknum = -1;
                }

                active = sNode.Attributes["active"].Value;
                time = sNode.InnerText;

                track = line.Tracks.getTrack(tracknum);
                /*
                if(track == null)
                {
                    xLogger.add("track is null:"+tracknum+" - "+time);
                }      
                */
                start = new Start(track, active, time);
                line.Starts.addStart(start);
                    
            }

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
