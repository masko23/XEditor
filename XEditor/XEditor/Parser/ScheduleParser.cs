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
                // read stations
                XmlDocument tagStations = new XmlDocument();
                string xmlStations = "<Stations>"+document.GetElementsByTagName("Stations")[0].InnerXml+"</Stations>";
                //Console.WriteLine(xmlStations
                tagStations.LoadXml(xmlStations);
                readStations(tagStations);

             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        // helper methods for parse()
        private void readStations(XmlDocument tagStations)
        {
            if(tagStations.HasChildNodes)
            {
                XmlNodeList stationlist = tagStations.GetElementsByTagName("Station");

                foreach(XmlNode node in stationlist)
                {
                    int id;
                    string name;
                    Station newstation;

                    // get ID
                    string attr = node.Attributes["id"].Value;
                    bool res = Int32.TryParse(attr, out id);
                    if(!res)
                    {
                        id = -1;
                    }

                    // get station name
                    name = node.InnerText;

                    // create Station
                    newstation = new Station(id, name);

                    // add to the database in memory
                    schedule.Stations.addStation(newstation);

                    //Console.WriteLine("new Station: " + newstation.ToString());
                }
            }
        }


    }
}
