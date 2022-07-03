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
    public partial class Eingang : Form
    {
       
        List<EingaengeModel> eingaenge = new List<EingaengeModel>();


        //Initialisierung des API Clients 
        //Konstrukturaufruf für die Methode LoadEingang(), die alle Ausgänge in einer Liste zurückliefert.
        public Eingang()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadEingang();
            
            
            
        }

        private void txtalm_TextChanged(object sender, EventArgs e)
        {

        }
        //Daten aus Ausgänge werden der Variable eingang zugewiesen.
        private void LoadEingang()
        {

            eingaenge = SqliteDataAccess.LoadEingang();

            
        }



    
        //Button mit dem die Zustände der einzelnen Geräte zurückgeliefert werden.
        private async void btnStart_Click(object sender, EventArgs e)
        {
            var solar = await Eingaenge.LoadSolarPanelData();


            var solardata = await Eingaenge.LoadSolarPanelData();
            var kollektor = await Eingaenge.LoadKollektor();
            var aussenluftdata1 = await Eingaenge.LoadAlmAussen();
            var aussenluftdata2 = await Eingaenge.LoadTempAussen();
            var fbhdata1 = await Eingaenge.LoadFbhRL();
            var fbhdata2 = await Eingaenge.LoadFbhVL();

            var psobendata = await Eingaenge.LoadPSOben();
            var psuntendata = await Eingaenge.LoadPSUnten();
            var psww = await Eingaenge.LoadPSWW();
            var psheiz = await Eingaenge.LoadPSHeiz();
            var wwzulauf = await Eingaenge.LoadWWZulauf();



            var wp_sole_rl = await Eingaenge.LoadSoleRL();
            var wp_sole_vl = await Eingaenge.LoadSoleVL();
            var wp_innen = await Eingaenge.LoadWPinnen();




            var zisterne_oben = await Eingaenge.LoadZisOben();
            var zisterne_unten = await Eingaenge.LoadZisUnten();

            Console.WriteLine(solardata.val);





            EingaengeModel eingang = new EingaengeModel();


            eingang.SolarRLTemp = solar.val;
            eingang.Kollektor = kollektor.val;

            eingang.alm_aussen_temperatur = aussenluftdata1.val;
            eingang.aussen_temperatur = aussenluftdata2.val;

            eingang.fbh_vr = fbhdata1.val;
            eingang.fbh_vl = fbhdata2.val;

            eingang.PS_unten = psobendata.val;
            eingang.PS_oben = psuntendata.val;
            eingang.PS_WW = psww.val;
            eingang.PS_WW_Zulauf = wwzulauf.val;
            eingang.PS_Heiz = psheiz.val;

            eingang.Sole_rl = wp_sole_rl.val;
            eingang.Sole_vl = wp_sole_vl.val;
            eingang.Wp_innen = wp_innen.val;

            eingang.Zist_unten = zisterne_unten.val;
            eingang.Zist_oben = zisterne_oben.val;
            eingang.date = DateTime.Now.ToString();
            eingaenge.Add(eingang);
            SqliteDataAccess.SaveEingang(eingang);



            //Ausgabe für die Textfelder auf dem Main Panel 
            txtsolar.Text = solar.val.ToString() + "°C";
            txtKollektor.Text = eingang.Kollektor.ToString() + "°C";
            txtaussen.Text = eingang.aussen_temperatur.ToString() + "°C";
            txtalm.Text = eingang.alm_aussen_temperatur.ToString() + "°C";
            txtfbhVL.Text = eingang.fbh_vl.ToString() + "°C";
            txtfbhRL.Text = eingang.fbh_vr.ToString() + "°C";
            txtPSOben.Text = eingang.PS_oben.ToString() + "°C";
            txtPSUnten.Text = eingang.PS_unten.ToString() + "°C";
            txtPSHeiz.Text = eingang.PS_Heiz.ToString() + "°C";
            txtPSWW.Text = eingang.PS_WW.ToString() + "°C";
            txtwwZulauf.Text = eingang.PS_WW_Zulauf.ToString() + "°C";
            txtSoleRl.Text = eingang.Sole_rl.ToString() + "°C";
            txtSoleVl.Text = eingang.Sole_vl.ToString() + "°C";
            txtWPInnen.Text = eingang.Wp_innen.ToString() + "°C";
            txtZisterneOben.Text = eingang.Zist_oben.ToString() + "°C";
            txtZisterneUnten.Text = eingang.Zist_unten.ToString() + "°C";
        }
    }
}
