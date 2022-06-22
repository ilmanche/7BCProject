using ClassLibrary;
using ClassLibrary.Models.Ausgänge;
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

        public Ausgang()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadAusgang();
        }
        private void LoadAusgang()
        {
            ausgang = SqliteDataAccess.LoadAusgang();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
         //   var PumpeSolar = await Ausgaenge.LoadPumpeSolar();
            var Pumpe_Zirku = await Ausgaenge.LoadPumpeZirku();
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
            ausgaenge.Heizband_ALM = Heizband_ALM.Heizband_ALM;
            ausgaenge.Mischer_Auf = Mischer_Auf.Mischer_Auf;
            ausgaenge.Mischer_Zu = Mischer_Zu.Mischer_Zu;
            ausgaenge.Pumpe_Hzkr = Pumpe_Hzkr.Pumpe_Hzkr;
           // ausgaenge.Pumpe_Solar = PumpeSolar.state;
            ausgaenge.Pumpe_Sole = Pumpe_Sole.Pumpe_Sole;
            ausgaenge.Pumpe_Zirku = Pumpe_Zirku.Pumpe_Zirku;
            ausgaenge.Ventil_Solar1 = Ventil_Solar1.Ventil_Solar1;
            ausgaenge.Ventil_Solar2 = Ventil_Solar2.Ventil_Solar2;
            ausgaenge.Ventil_Sole1 = Ventil_Sole1.Ventil_Sole1;
            ausgaenge.Ventil_Sole2 = Ventil_Sole2.Ventil_Sole2;
            ausgaenge.Ventil_WW = Ventil_WW.Ventil_WW;
            ausgaenge.Wp_Anf = Wp_Anf.Wp_Anf;
            ausgaenge.date = DateTime.Now.ToString();


            txtalm.Text = ausgaenge.Heizband_ALM.ToString();
            txtMischerAuf.Text = ausgaenge.Mischer_Auf.ToString();  
            txtMischerzu.Text = ausgaenge.Mischer_Zu.ToString();
            txtPumpeHzkr.Text = ausgaenge.Pumpe_Hzkr.ToString();
           // txtPumpeSolar.Text = ausgaenge.Pumpe_Solar.ToString();
            txtPumpeSole.Text = ausgaenge.Pumpe_Sole.ToString();
            txtPumpeZirku.Text = ausgaenge.Pumpe_Zirku.ToString();
            txtVentilSolar1.Text = ausgaenge.Ventil_Solar1.ToString();
            txtVentilSolar2.Text = ausgaenge.Ventil_Solar2.ToString();
            txtWPAnf.Text = ausgaenge.Wp_Anf.ToString();
            txtVentilWW.Text = ausgaenge.Ventil_WW.ToString();
            txtPumpeSole.Text = ausgaenge.Pumpe_Sole.ToString();


            ausgang.Add(ausgaenge);
            SqliteDataAccess.SaveAusgang(ausgaenge);
        }

        private void lblfbhvl_Click(object sender, EventArgs e)
        {

        }

        private void lblZirku_Click(object sender, EventArgs e)
        {

        }
    }
}
