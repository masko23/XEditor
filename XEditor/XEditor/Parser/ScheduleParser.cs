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

            // read stations
            try
            {
                XmlNodeList stations_node = document.GetElementsByTagName("Stations");
                if(stations_node[0].HasChildNodes)
                {
                    XmlNodeList stations = stations_node[0].ChildNodes;
                    for(int i = 0; i < stations.Count; i++)
                    {
                        int id;
                        string name;
                        string strId;

                        strId = stations[i].Attributes["id"].Value;
                        name = stations[i].InnerText;

                        bool parseok = Int32.TryParse(strId, out id);
                        if (!parseok) id = -1;

                        Station station = new Station(id, name);
                        schedule.Stations.addStation(station);

                        Console.WriteLine("new station: " + station.ToString());
                           
                    }
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
