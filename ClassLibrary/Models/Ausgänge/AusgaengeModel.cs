using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Ausgänge
{
    public class AusgaengeModel
    {
        String stdDetails = " {0, -10} {1, -20} {2, -20} {3, -20} {4, -16}, {5, -16} {6, -16} {7, -16} {8, -16} {9, -16} {10, -16} {11, -16} {12, -16} {13, -16} ";

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
            { return  $" {Heizband_ALM}  {Pumpe_Solar} {Pumpe_Zirku}  {Ventil_Solar1}  {Ventil_Solar2} {Ventil_WW} {Pumpe_Hzkr} {Ventil_Sole1} {Ventil_Sole2} {Wp_Anf} {Pumpe_Sole} {Mischer_Auf} {Mischer_Zu} {date}"; }

        }
    }
}
