using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Tracks
    {
        // Attributes
        public BindingList<Track> TrackList { get; private set; }

        // Constructor
        public Tracks()
        {
            TrackList = new BindingList<Track>();
        }

        // Functionality
        
        // Return Track by ID
        public Track getTrack(int p_ID)
        {
            Track retTrack = null;

            foreach(Track track in TrackList)
            {
                if(track.ID == p_ID)
                {
                    retTrack = track;
                }
            }

            return retTrack;
        }

        // Add new Track to the list
        public void addTrack(Track p_track)
        {
            TrackList.Add(p_track);
        }

        // Remove a track from the list by reference
        public void removeTrack(Track p_track)
        {
            TrackList.Remove(p_track);
        }

        // Remove a track from the list by ID
        public void removeTrack(int p_ID)
        {
            TrackList.Remove(getTrack(p_ID));
        }
    }
}
