using ClassLibrary;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class History : Form
    {
        //String Format für die Ausgabe der Daten im Panel
        String stdDetails = "{0, -20} {1, -20} {2, -20} {3, -20} {4, -20} {5, -20} {6, -20} {7, -20} {8, -20} {9, -20} {10, -20} {11, -20} {12, -20} {13, -20} ";
        String stdDetails2 = "{0, -20} {1, -25} {2, -25} {3, -25} {4, -25} {5, -25} {6, -25} {7, -25} {8, -25} {9, -25} {10, -25} {11, -25} {12, -25} {13, -25} {14, -25}  {15, -25}  {16, -25}";

        List<EingaengeModel> eingaenge = new List<EingaengeModel>();
        List<AusgaengeModel> ausgang = new List<AusgaengeModel>();

        //Initialisierung vom API Helper und Konstruktoraufruf für Eingänge und Ausgänge.
        public History()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadTemp();
            LoadAusgang();
        }

        //Laden der Temperatur in einem bestimmten StringFormat.
        private void LoadTemp()
        {
            eingaenge = SqliteDataAccess.LoadEingang();
            listboxeingang.Items.Add(String.Format(
           "aussen_temperatur",
           "alm_aussen_temperatur",
           "fbh_vl",
           "fbh_vr",
           "PS_oben",
           "PS_unten",
           "PS_WW",
           "PS_Heiz",
           "PS_WW_Zulauf",
           "SolarRLTemp",
           "Kollektor",
           "Pumpe_Zirku",
           "Sole_vl",
           "Sole_rl",
           "Zist_unten",
           "Zist_oben",
           "date"));

        }

        //Laden der Zustände in einem bestimmten StringFormat.

        private void LoadAusgang()
        {
           ausgang = SqliteDataAccess.LoadAusgang();
            listboxeingang.Items.Add(String.Format(
        "Heizband_ALM",
        "Pumpe_Solar",
        "Pumpe_Zirku",
        "Ventil_Solar1",
        "Ventil_Solar2",
        "Ventil_WW",
        "Pumpe_Hzkr",
        "Ventil_Sole1",
        "Ventil_Sole2",
        "Wp_Anf",
        "Pumpe_Sole",
        "Mischer_Auf",
        "Mischer_Zu",
        "date")

);
        }

    
     
        //MainPanel scrollbar machen
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxeingang.HorizontalScrollbar = true;

        }

        private void Compare1()
        {
            //Linq Abfrage zum vergleichen der 2 Daten 
            //Wenn das gleiche Datum für das ausgewählte Datum enthalten ist, soll eine Liste der Daten für den Tag zurückgegeben werden.
            var queryAllCustomers = (from a in ausgang
                                     where a.date.ToString().Contains(dateTimePicker2.Text)
                                     select a).ToList();
            foreach (var query in queryAllCustomers)
            {
                listboxeingang.Items.Add(query);
            }

        }

        private void Compare2()
        {
            //Linq Abfrage zum vergleichen der 2 Daten 
            //Wenn das gleiche Datum für das ausgewählte Datum enthalten ist, soll eine Liste der Daten für den Tag zurückgegeben werden.
            var queryAllCustomers = (from a in eingaenge
                                     where a.date.ToString().Contains(dateTimePicker2.Text)
                                     select a).ToList();
            foreach (var query in queryAllCustomers)
            {
                listboxeingang.Items.Add(query);
            }

        }
        private void WiredUpList2()
        {
            //Methode für das Auflisten der Daten in einem bestimmten StringFormat und mit Abgleich der Daten

            listboxeingang.Items.Clear();
            listboxeingang.Items.Add(String.Format(stdDetails2,
           "aussen_temperatur",
           "alm_aussen_temperatur",
           "fbh_vl",
           "fbh_vr",
           "PS_oben",
           "PS_unten",
           "PS_WW",
           "PS_Heiz",
           "PS_WW_Zulauf",
           "SolarRLTemp",
           "Kollektor",
           "Pumpe_Zirku",
           "Sole_vl",
           "Sole_rl",
           "Zist_unten",
           "Zist_oben",
           "date"));


            Compare2();
            listboxeingang.DisplayMember = "fullrow";


        }

        private void WiredUpList1()
        {
            //Methode für das Auflisten der Daten in einem bestimmten StringFormat und mit Abgleich der Daten



            listboxeingang.Items.Clear();
            listboxeingang.Items.Add(String.Format(stdDetails, 
           "Heizband_ALM", 
           "Pumpe_Solar",
           "Pumpe_Zirku",
           "Ventil_Solar1",
           "Ventil_Solar2",
           "Ventil_WW",
           "Pumpe_Hzkr",
           "Ventil_Sole1",
           "Ventil_Sole2",
           "Wp_Anf",
           "Pumpe_Sole",
           "Mischer_Auf",
           "Mischer_Zu",
           "date"));
 

            Compare1();
            listboxeingang.DisplayMember = "fullrow";


        }

       

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void History_Load(object sender, EventArgs e)
        {
            listboxeingang.Items.Clear();

            listboxeingang.HorizontalScrollbar = true;

          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnloadeingang_Click(object sender, EventArgs e)
        {
            listboxeingang.Items.Clear();

            WiredUpList2();
        }

        private void btnausgang_Click(object sender, EventArgs e)
        {
            listboxeingang.Items.Clear();

            WiredUpList1();
        }
    }
}
