using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XEditor.XML_Model
{
    class Stations
    {
        // Attributes
        public BindingList<Station> StationList { get; private set; }
        
        // Constructor
        public Stations()
        {
            StationList = new BindingList<Station>();
        }

        // Functionality

        // Get station by ID
        public Station getStation(int p_ID)
        {
            Station retStation = null;

            foreach(Station stat in StationList)
            {
                if(stat.ID == p_ID)
                {
                    retStation = stat;
                }
            }

            return retStation;
        }

        // Get station by Name
        public Station getStation(String p_Name)
        {
            Station retStation = null;

            foreach (Station stat in StationList)
            {
                if (stat.Name.Equals(p_Name))
                {
                    retStation = stat;
                }
            }

            return retStation;
        }

        // Add new Station
        public void addStation(Station newStation)
        {
            StationList.Add(newStation);
        }

        // Remove a Station from the list by reference
        public void removeStation(Station p_station)
        {
            string stname = p_station.Name;
            if(StationList.Remove(p_station))
            {
                xLogger.add("Station is removed: " + stname);
            }
        }

        // Remove a Station from the list by ID
        public void removeStation(int p_id)
        {
            StationList.Remove(getStation(p_id));
        }

        // Remove a Station from the list by Name
        public void removeStation(string p_name)
        {
            StationList.Remove(getStation(p_name));
        }


    }
}
