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
using XEditor.ButtonHandlers;

namespace XEditor
{
    public partial class Form1 : Form
    {
        private Schedule schedule;
        private xLogger logger;

        private Panel editPanel; // store the currently showed panel

        public Form1()
        {
            InitializeComponent();
            logger = new xLogger();
            logger.Show();

            schedule = new Schedule("Veszprem");

            ScheduleParser parser = new ScheduleParser(schedule);
            parser.read();

            fillScheduleTree();

            scheduleTree.ExpandAll();

            this.listBox_stopstats.DataSource = schedule.Stations.StationList;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save&Exit", MessageBoxButtons.YesNoCancel);

            switch(result)
            {
                case DialogResult.Yes:
                    schedule.save();
                    logger.Hide();
                    break;
                case DialogResult.No:
                    logger.Hide();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }

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
                    editLine();
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
                            editTrack();
                        }
                        else
                        {
                            Stop stop;
                            if ((stop = e.Node.Tag as Stop) != null)
                            {
                                xLogger.add("Selected: " + stop.Station.Name);
                                editStop();
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
                                        editstart();
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
        }

        private void editStop()
        {
            if (editPanel != null) editPanel.Hide();

            Stop stop;
            if ((stop = scheduleTree.SelectedNode.Tag as Stop) != null)
            {
                editPanel = editpanel_stop;
                editPanel.Show();
                listBox_stopstats.SelectedItem = stop.Station;
                numericUpDown_stopdelay.Value = stop.Delay;
            }
        }

        private void editstop_savebutton_Click(object sender, EventArgs e)
        {
            Stop stop;
            if ((stop = scheduleTree.SelectedNode.Tag as Stop) != null)
            {
                stop.Station = (Station)listBox_stopstats.SelectedItem;

                stop.Delay = (int)numericUpDown_stopdelay.Value;

                scheduleTree.SelectedNode.Text = stop.Station.Name;

                editPanel.Hide();
                editPanel = null;

                scheduleTree.SelectedNode = null;
            }
        }

        private void editTrack()
        {
            if (editPanel != null) editPanel.Hide();

            Track track;
            if((track = scheduleTree.SelectedNode.Tag as Track) != null)
            {
                editPanel = editpanel_track;
                editPanel.Show();
                numericUpDown_TID.Value = track.ID;
            }
        }

        private void button_saveTrack_Click(object sender, EventArgs e)
        {
            Track track;
            if ((track = scheduleTree.SelectedNode.Tag as Track) != null)
            {
                Tracks parent = scheduleTree.SelectedNode.Parent.Tag as Tracks;

                foreach (Track t in parent.TrackList)
                {
                    if (t.ID == numericUpDown_TID.Value)
                    {
                        MessageBox.Show("Track ID is already taken.");
                        return;
                    }
                }

                track.ID = (int)numericUpDown_TID.Value;
                scheduleTree.SelectedNode.Text = track.ID.ToString();


                editPanel.Hide();
                editPanel = null;

                scheduleTree.SelectedNode = null;
            }
        }

        private void editstart()
        {
            if (editPanel != null) editPanel.Hide(); // hide previously used panel

            Start start;
            if ((start = scheduleTree.SelectedNode.Tag as Start) != null)
            {
                editPanel = editpanel_start;
                editPanel.Show();
                editstartActive.Text = start.Active;
                editstartTimepick.Value = DateTime.Parse(start.Time);
            }
        }

        private void button_saveStart_Click(object sender, EventArgs e)
        {
            Start start;
            if ((start = scheduleTree.SelectedNode.Tag as Start) != null)
            {
                start.Active = editstartActive.Text;
                
                start.Time = editstartTimepick.Value.ToString("HH:mm");

                scheduleTree.SelectedNode.Text = start.Time;

                editPanel.Hide();
                editPanel = null;

                scheduleTree.SelectedNode = null;
            }
        }

        private void editLine()
        {
            if (editPanel != null) editPanel.Hide(); // hide previously used panel

            Line line;
            if((line = scheduleTree.SelectedNode.Tag as Line) != null)
            {
                editPanel = editpanel_line;
                editPanel.Show();
                textedit_line.Text = line.Name;
            }
            
        }

        private void button_saveline_Click(object sender, EventArgs e)
        {
            Line line;
            if ((line = scheduleTree.SelectedNode.Tag as Line) != null)
            {
                Lines parent = scheduleTree.SelectedNode.Parent.Tag as Lines;
                foreach(Line l in parent.LineList)
                {
                    if(l.Name == textedit_line.Text)
                    {
                        MessageBox.Show("Line name is already taken.");
                        return;
                    }
                }

                line.Name = textedit_line.Text;
                scheduleTree.SelectedNode.Text = line.Name;

                editPanel.Hide();
                editPanel = null;

                scheduleTree.SelectedNode = null;
            }
        }



    }
}
