using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XEditor
{
    public partial class xLogger : Form
    {
        public static bool LOGGING_ACTIVE { get; set; }
        
        public xLogger()
        {
            InitializeComponent();
            LOGGING_ACTIVE = false;
        }

        public static void add(string text)
        {
            if (LOGGING_ACTIVE)
            {
                xLogger.logBox.AppendText(text + '\n');
            }
        }

        public static void clear()
        {
            xLogger.logBox.Clear();
        }

        private void xLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            LOGGING_ACTIVE = false;
        }
    }
}
