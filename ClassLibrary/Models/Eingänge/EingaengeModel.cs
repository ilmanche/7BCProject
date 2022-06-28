using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EingaengeModel
    {

        public double aussen_temperatur { get; set; }
        public double alm_aussen_temperatur { get; set; }
        public double fbh_vl { get; set; }
        public double fbh_vr { get; set; }
        public double PS_oben { get; set; }
        public double PS_unten { get; set; }
        public double PS_WW { get; set; }
        public double PS_Heiz { get; set; }
        public double PS_WW_Zulauf { get; set; }
        public double SolarRLTemp { get; set; }
        public double Kollektor { get; set; }
        public double Pumpe_Zirku { get; set; }
        public double Wp_innen { get; set; }
        public double Sole_vl { get; set; }
        public double Sole_rl { get; set; }
        public double Zist_unten { get; set; }
        public double Zist_oben { get; set; }
        public string date { get; set; }

        public string fullrow
        {
            get
            { return $" {"" + aussen_temperatur + "             "}  {"             " + alm_aussen_temperatur + "              "} {"              " + fbh_vl + "               "}  {"             " + fbh_vr + "            "}  {"           " + PS_oben + "            "} {"           " + PS_unten + "              "} {"               " + PS_WW + "             "} {"          " + PS_Heiz + "          "} {"           " + PS_WW_Zulauf + "          "} {"          " + SolarRLTemp + "            "} {"            " + Kollektor + "           "} {"          " + Pumpe_Zirku + "           "} {"             " + Wp_innen + "             "}   {"             " + Sole_vl + "          "}  {"              " + Sole_rl + "            "}  {"             " + Zist_unten + "              "}{"           " + Zist_oben + "            "}{"           " + date}"; }
              
        }
    }
}
