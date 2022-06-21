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
        public Ausgang()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadTemp();
        }

    
        List<AusgaengeModel> ausgang = new List<AusgaengeModel>();

        private void LoadTemp()
        {
            ausgang = SqliteDataAccess.LoadAusgang();
       





        }


        private async Task btnStartAusgang_ClickAsync(object sender, EventArgs e)
        {
            var Pumpe_Solar = await Ausgaenge.LoadPumpeSolar();
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
            // var Ventil_Solar2 = await Ausgaenge.LoadVentilSolar2();
            var Wp_Anf = await Ausgaenge.LoadWPAnf();


            AusgaengeModel ausgaenge = new AusgaengeModel();
            ausgaenge.date = DateTime.Now.ToString();
            ausgaenge.Heizband_ALM = Heizband_ALM.state;
            ausgaenge.Mischer_Auf = Mischer_Auf.state;
            ausgaenge.Mischer_Zu = Mischer_Zu.state;
            ausgaenge.Pumpe_Hzkr = Pumpe_Hzkr.state;
            ausgaenge.Pumpe_Solar = Pumpe_Solar.state;
            ausgaenge.Pumpe_Sole = Pumpe_Sole.state;
            ausgaenge.Pumpe_Zirku = Pumpe_Zirku.state;
            ausgaenge.Ventil_Solar1 = Ventil_Solar1.state;
            // ausgaenge.Ventil_Solar2 = Ventil_Solar2.state;
            ausgaenge.Ventil_Sole1 = Ventil_Sole1.state;
            ausgaenge.Ventil_Sole2 = Ventil_Sole2.state;
            ausgaenge.Ventil_WW = Ventil_WW.state;
            ausgaenge.Wp_Anf = Wp_Anf.state;

            ausgang.Add(ausgaenge);
            SqliteDataAccess.SaveAusgang(ausgaenge);

        }
    }
}
