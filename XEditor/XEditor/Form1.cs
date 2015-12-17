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

        public Form1()
        {
            InitializeComponent();

            schedule = new Schedule("Veszprem");

            ScheduleParser parser = new ScheduleParser(schedule);
            parser.read();

            schedule.save();
        }
    }
}
