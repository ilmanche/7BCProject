using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Ausgang : Form
    {
        List<AusgaengeModel> ausgang = new List<AusgaengeModel>();

        //Initialisierung des API Clients 
        //Konstrukturaufruf für die Methode LoadAusgang(), die alle Ausgänge in einer Liste zurückliefert.
        public Ausgang()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadAusgang();
        }

        //Daten aus Ausgänge werden der Variable ausgang zugewiesen.
        private void LoadAusgang()
        {
            ausgang = SqliteDataAccess.LoadAusgang();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Button zum ausgeben der Temperaturdaten
        private async void button1_Click(object sender, EventArgs e)
        {
            var PumpeSolar = await Ausgaenge.LoadPumpeSolar();
            var pumpe_Zirku = await Ausgaenge.LoadPumpeZirku();
            var Ventil_Sole1 = await Ausgaenge.LoadVentilSole1();
            var Ventil_Solar1 = await Ausgaenge.LoadVentilSolar1();
            var Heizband_ALM = await Ausgaenge.LoadHeizbandALM();
            var Pumpe_Sole = await Ausgaenge.LoadPumpeSole();
            var Ventil_WW = await Ausgaenge.LoadVentilWW();
            var Pumpe_Hzkr = await Ausgaenge.LoadPumpeHzkr();
            var Mischer_Auf = await Ausgaenge.LoadMischerAuf();
            var Mischer_Zu = await Ausgaenge.LoadMischerZu();
            var Ventil_Sole2 = await Ausgaenge.LoadVentilSole2();
            var Ventil_Solar2 = await Ausgaenge.LoadVentilSolar2();
            var Wp_Anf = await Ausgaenge.LoadWPAnf();


            AusgaengeModel ausgaenge = new AusgaengeModel();
            ausgaenge.date = DateTime.Now.ToString();
            ausgaenge.Heizband_ALM = Heizband_ALM.val;
            ausgaenge.Mischer_Auf = Mischer_Auf.val;
            ausgaenge.Mischer_Zu = Mischer_Zu.val;
            ausgaenge.Pumpe_Hzkr = Pumpe_Hzkr.val;
            ausgaenge.Pumpe_Solar = PumpeSolar.val;
            ausgaenge.Pumpe_Sole = Pumpe_Sole.val;
            ausgaenge.Pumpe_Zirku = pumpe_Zirku.val;
            ausgaenge.Ventil_Solar1 = Ventil_Solar1.val;
            ausgaenge.Ventil_Solar2 = Ventil_Solar2.val;
            ausgaenge.Ventil_Sole1 = Ventil_Sole1.val;
            ausgaenge.Ventil_Sole2 = Ventil_Sole2.val;
            ausgaenge.Ventil_WW = Ventil_WW.val;
            ausgaenge.Wp_Anf = Wp_Anf.val;
            ausgaenge.date = DateTime.Now.ToString();

            //Ausgabe für die Textfelder auf dem Main Panel 
            txtalm.Text = ausgaenge.Heizband_ALM.ToString();
            txtMischerAuf.Text = ausgaenge.Mischer_Auf.ToString();  
            txtMischerzu.Text = ausgaenge.Mischer_Zu.ToString();
            txtPumpeHzkr.Text = ausgaenge.Pumpe_Hzkr.ToString();
            txtPumpeSole.Text = ausgaenge.Pumpe_Sole.ToString();
            txtPumpeZirku.Text = ausgaenge.Pumpe_Zirku.ToString();
            txtVentilSolar1.Text = ausgaenge.Ventil_Solar1.ToString();
            txtVentilSolar2.Text = ausgaenge.Ventil_Solar2.ToString();
            txtWPAnf.Text = ausgaenge.Wp_Anf.ToString();
            txtVentilWW.Text = ausgaenge.Ventil_WW.ToString();
            txtPumpeSole.Text = ausgaenge.Pumpe_Sole.ToString();
            txtVentilSole1.Text = ausgaenge.Ventil_Sole1.ToString();
            txtVentilSole2.Text = ausgaenge.Ventil_Sole2.ToString();
            txtPumpeSolar.Text = ausgaenge.Pumpe_Solar.ToString();  


            ausgang.Add(ausgaenge);
            SqliteDataAccess.SaveAusgang(ausgaenge);
        }

        private void lblfbhvl_Click(object sender, EventArgs e)
        {

        }

        private void lblZirku_Click(object sender, EventArgs e)
        {

        }

        private void Ausgang_Load(object sender, EventArgs e)
        {

        }
    }
}
