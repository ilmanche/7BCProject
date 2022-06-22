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
    public partial class Eingang : Form
    {
        List<SolarRLModel> solarPanels = new List<SolarRLModel>();
        List<AussenluftModel> aussenLuft = new List<AussenluftModel>();
        List<FBHModel> fussboden = new List<FBHModel>();
        List<PSModel> pufferspeicher = new List<PSModel>();
        List<WPModel> waermepumpe = new List<WPModel>();
        List<ZisterneModel> zisterne = new List<ZisterneModel>();
        public Eingang()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadTemp();
        }

        private void txtalm_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadTemp()
        {
            solarPanels = SqliteDataAccess.LoadSolarPanel();
            aussenLuft = SqliteDataAccess.LoadAussenLuftTemp();
            fussboden = SqliteDataAccess.LoadFBH();
            pufferspeicher = SqliteDataAccess.LoadPS();
            waermepumpe = SqliteDataAccess.LoadWPModel();
            zisterne = SqliteDataAccess.LoadZist();





        }



        private async void btnStart_Click(object sender, EventArgs e)
        {
            var solardata = await SolarPanel.LoadSolarPanelData();
            var kollektor = await SolarPanel.LoadSolarPanelData();
            var aussenluftdata1 = await Aussenluft.LoadAlmAussen();
            var aussenluftdata2 = await Aussenluft.LoadTempAussen();
            var fbhdata1 = await FBH.LoadFbhRL();
            var fbhdata2 = await FBH.LoadFbhVL();

            var psobendata = await Pufferspeicher.LoadPSOben();
            var psuntendata = await Pufferspeicher.LoadPSUnten();
            var psww = await Pufferspeicher.LoadPSWW();
            var psheiz = await Pufferspeicher.LoadPSHeiz();
            var wwzulauf = await Pufferspeicher.LoadWWZulauf();



            var wp_sole_rl = await Waermepumpe.LoadSoleRL();
            var wp_sole_vl = await Waermepumpe.LoadSoleVL();
            var wp_innen = await Waermepumpe.LoadWPinnen();




            var zisterne_oben = await Zisterne.LoadZisOben();
            var zisterne_unten = await Zisterne.LoadZisUnten();











            SolarRLModel sol = new SolarRLModel();
            sol.Temperatur = solardata.val;
            sol.Kollektor = kollektor.val;
            sol.date = DateTime.Now.ToString();
            solarPanels.Add(sol);
            SqliteDataAccess.SaveSolarPanel(sol);


            AussenluftModel alm = new AussenluftModel();
            alm.alm_aussen_temperatur = aussenluftdata1.val;
            alm.aussen_temperatur = aussenluftdata2.val;
            alm.date = DateTime.Now.ToString(); 
            aussenLuft.Add(alm);
            SqliteDataAccess.SaveAußenluft(alm);


            FBHModel fbh = new FBHModel();
            fbh.fbh_vr = fbhdata1.val;
            fbh.fbh_vl = fbhdata2.val;
            fbh.date = DateTime.Now.ToString();
            fussboden.Add(fbh);
            SqliteDataAccess.SaveFBH(fbh);


            PSModel ps = new PSModel();
            ps.PS_unten = psobendata.val;
            ps.PS_oben = psuntendata.val;
            ps.PS_WW = psww.val;
            ps.PS_WW_Zulauf = wwzulauf.val;
            ps.PS_Heiz = psheiz.val;
            ps.date = DateTime.Now.ToString();
            pufferspeicher.Add(ps);
            SqliteDataAccess.SavePS(ps);

            WPModel wp = new WPModel();
            wp.Sole_rl = wp_sole_rl.val;
            wp.Sole_vl = wp_sole_vl.val;
            wp.Wp_innen = wp_innen.val;
            wp.date = DateTime.Now.ToString();
            waermepumpe.Add(wp);
            SqliteDataAccess.SavePS(ps);

            ZisterneModel zz = new ZisterneModel();
            zz.Zist_unten = zisterne_unten.val;
            zz.Zist_oben = zisterne_oben.val;
            zz.date = DateTime.Now.ToString();
            zisterne.Add(zz);
            SqliteDataAccess.SaveZisterne(zz);


            txtsolar.Text = sol.Temperatur.ToString() + "°C";
            txtKollektor.Text = sol.Kollektor.ToString() + "°C";
            txtaussen.Text = alm.aussen_temperatur.ToString() + "°C";
            txtalm.Text = alm.alm_aussen_temperatur.ToString() + "°C";
            txtfbhVL.Text = fbh.fbh_vl.ToString() + "°C";
            txtfbhRL.Text = fbh.fbh_vr.ToString() + "°C";
            txtPSOben.Text = ps.PS_oben.ToString() + "°C";
            txtPSUnten.Text = ps.PS_unten.ToString() + "°C";
            txtPSHeiz.Text = ps.PS_Heiz.ToString() + "°C";
            txtPSWW.Text = ps.PS_WW.ToString() + "°C";
            txtwwZulauf.Text = ps.PS_WW_Zulauf.ToString() + "°C";
            txtSoleRl.Text = wp.Sole_rl.ToString() + "°C";
            txtSoleVl.Text = wp.Sole_vl.ToString() + "°C";
            txtWPInnen.Text = wp.Wp_innen.ToString() + "°C";
            txtZisterneOben.Text = zz.Zist_oben.ToString() + "°C";
            txtZisterneUnten.Text = zz.Zist_unten.ToString() + "°C";

        }
    }
}
