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

            schedule.save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Hide();
        }
    }
}
