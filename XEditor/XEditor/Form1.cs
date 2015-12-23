using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XEditor.Parser;
using XEditor.XML_Model;

namespace XEditor
{
    public partial class Form1 : Form
    {
        private Schedule schedule;
        private xLogger logger;

        public Form1()
        {
            InitializeComponent();
            logger = new xLogger();
            logger.Show();

            schedule = new Schedule("Veszprem");

            ScheduleParser parser = new ScheduleParser(schedule);
            parser.read();

            fillStationsTree();
            fillScheduleTree();

            schedule.save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Hide();
        }

        private void fillStationsTree()
        {
            stationsTree.Nodes.Clear();

            TreeNode tStations = stationsTree.Nodes.Add("Stations");
            tStations.Tag = schedule.Stations;

            foreach(Station station in schedule.Stations.StationList)
            {
               TreeNode tNode = tStations.Nodes.Add(station.Name);
                tNode.Tag = station;
            }

            stationsTree.ExpandAll();
        }

        private void fillScheduleTree()
        {
            scheduleTree.Nodes.Clear();

            TreeNode tLines = scheduleTree.Nodes.Add("Lines");
            tLines.Tag = schedule.Lines;

            foreach(Line line in schedule.Lines.LineList)
            { 
                TreeNode tLine = tLines.Nodes.Add(line.Name);
                tLine.Tag = line;
                TreeNode tTracks = tLine.Nodes.Add("Tracks");
                tTracks.Tag = line.Tracks;
                TreeNode tStarts = tLine.Nodes.Add("Starts");
                tStarts.Tag = line.Starts;

                // add tracks and stops for them
                foreach (Track track in line.Tracks.TrackList)
                {
                    TreeNode tTrack = tTracks.Nodes.Add(track.ID.ToString());
                    tTrack.Tag = track;

                    foreach(Stop stop in track.Stops)
                    {
                        TreeNode node = new TreeNode(stop.Station.Name);
                        node.Tag = stop;
                        tTrack.Nodes.Add(node);
                    }
                }

                // add starts
                foreach(Start start in line.Starts.StartList)
                {
                    TreeNode node = new TreeNode(start.Time);
                    node.Tag = start;
                    tStarts.Nodes.Add(node);
                }
            }
        }

        private void stationsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Stations stations;
            if ((stations = e.Node.Tag as Stations) != null)
            { 
                xLogger.add("Selected: " + "Stations");
            }
            else
            {
                Station station;
                if ((station = e.Node.Tag as Station) != null)
                {
                    xLogger.add("Selected: " + station.Name);
                }
            }
        }

        private void scheduleTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*
                TODO: reduce depth of if-else tree? 
                pro: same branches as treeview  
                con: potential unnecessary if checks
            */

            Lines lines;
            if((lines = e.Node.Tag as Lines) != null)
            {
                xLogger.add("Selected: " + "Lines");
            }
            else
            {
                Line line; 
                if((line = e.Node.Tag as Line) != null)
                {
                    xLogger.add("Selected:" + line.Name);
                }
                else
                {
                    Tracks tracks;
                    if((tracks = e.Node.Tag as Tracks) != null)
                    {
                        xLogger.add("Selected: " + "Tracks");
                    }
                    else
                    {
                        Track track;
                        if ((track = e.Node.Tag as Track) != null)
                        {
                            xLogger.add("Selected: " + track.ID);
                        }
                        else
                        {
                            Stop stop;
                            if ((stop = e.Node.Tag as Stop) != null)
                            {
                                xLogger.add("Selected: " + stop.Station.Name);
                            }
                            else // bring out this part to same level as Tracks
                            {
                                Starts starts;
                                if ((starts = e.Node.Tag as Starts) != null)
                                {
                                    xLogger.add("Selected: " + "Starts");
                                }
                                else
                                {
                                    Start start;
                                    if ((start = e.Node.Tag as Start) != null)
                                    {
                                        xLogger.add("Selected: " + start.Time);
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
