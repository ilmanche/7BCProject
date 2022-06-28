using ClassLibrary;
using ClassLibrary.Models.Ausgänge;
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
        String stdDetails = "{0, -20} {1, -20} {2, -20} {3, -20} {4, -20}, {5, -20} {6, -20} {7, -20} {8, -20} {9, -20} {10, -20} {11, -20} {12, -20} {13, -20}";
        List<SolarRLModel> solarPanels = new List<SolarRLModel>();
        // List<AusgaengeModel> ausgang = new List<AusgaengeModel>();
         List<AusgaengeModel> ausgang = new List<AusgaengeModel>();


        public History()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadTemp();
            LoadAusgang();
        }

        private void LoadTemp()
        {
            solarPanels = SqliteDataAccess.LoadSolarPanel();

        }

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

        private async void button1_Click(object sender, EventArgs e)
        {
            listboxeingang.Items.Clear();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxeingang.HorizontalScrollbar = true;

        }
        private void WiredUpList()
        {

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
 

             var queryAllCustomers = (from a in ausgang
                                     where a.date.ToString().Contains(dateTimePicker2.Text)
                                     select a).ToList();
            foreach (var query in queryAllCustomers)
            {
                listboxeingang.Items.Add(query);
            }
            listboxeingang.DisplayMember = "fullrow";

            //LoadAusgang();

            //listboxeingang.DataSource = null;
            //listboxeingang.DataSource = ausgang;
            //listboxeingang.DisplayMember = "fullrow";


            // draw back color and text 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           WiredUpList();
          


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            listboxeingang.HorizontalScrollbar = true;

          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
