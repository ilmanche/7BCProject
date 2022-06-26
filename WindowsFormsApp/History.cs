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
        }

        private async void button1_Click(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WiredUpList()
        {
            listboxeingang.Items.Clear();

            var queryAllCustomers = (from a in ausgang
                                     where a.date.ToString() == dateTimePicker2.Text
                                     select a).ToList();
            foreach (var query in queryAllCustomers)
            {
                listboxeingang.Items.Add(query);


                listboxeingang.DisplayMember = "fullrow";
            }
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
    }
}
