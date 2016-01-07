﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEditor.XML_Model
{
    class Stop
    {
        // Attributes
        public Station Station { get; private set; }
        public int Delay { get; private set; }

        // Constructor
        public Stop(Station p_stat, int p_del)
        {
            Station = p_stat;
            Delay = p_del;
        }
    }
}
