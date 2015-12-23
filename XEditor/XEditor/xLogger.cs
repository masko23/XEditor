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
        public xLogger()
        {
            InitializeComponent();
        }

        public static void add(string text)
        {
            xLogger.logBox.AppendText(text+'\n');
        }

        public static void clear()
        {
            xLogger.logBox.Clear();
        }
    }
}
