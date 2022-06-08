using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCLibrary
{
    public  class SolarRLModel
    {
        public int nummer { get; }
        public double solar_rl { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}