using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //Klassenmodell für die Augänge 
    public class AusgaengeModel
    {

        public bool Heizband_ALM { get; set; }
        public bool Pumpe_Solar { get; set; }
        public bool Pumpe_Zirku { get; set; }
        public bool Ventil_Solar1 { get; set; }
        public bool Ventil_Solar2 { get; set; }
        public bool Ventil_WW { get; set; }
        public bool Pumpe_Hzkr { get; set; }
        public bool Ventil_Sole1 { get; set; }
        public bool Ventil_Sole2 { get; set; }
        public bool Wp_Anf { get; set; }
        public bool Pumpe_Sole { get; set; }
        public bool Mischer_Auf { get; set; }
        public bool Mischer_Zu { get; set; }
        public string date { get; set; }
        

        public string fullrow
        {
            get
            { return  $" {"" + Heizband_ALM +"          "}  {"           " + Pumpe_Solar + "          "} {"            " + Pumpe_Zirku + "          "}  {"           " + Ventil_Solar1+ "          "}  {"           " + Ventil_Solar2 + "          "} {"         " + Ventil_WW + "          "} {"           " + Pumpe_Hzkr + "           "} {"        " + Ventil_Sole1 + "          "} {"           " + Ventil_Sole2 + "        "} {"          " + Wp_Anf + "          "} {"          " + Pumpe_Sole + "           "} {"          " + Mischer_Auf + "         "} {"           " + Mischer_Zu + "           "} {"         " + date}"; }
             
        }
    }
}
