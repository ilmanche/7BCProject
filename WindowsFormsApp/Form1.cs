using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<SolarRLModel> solarPanels = new List<SolarRLModel>();
        List<AussenluftModel> aussenLuft = new List<AussenluftModel>();
        List<FBHModel> fussboden = new List<FBHModel>();
        List<PSModel> pufferspeicher = new List<PSModel>();
        List<WPModel> waermepumpe = new List<WPModel>();
        List<ZisterneModel> zisterne = new List<ZisterneModel>();






        public Form1()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            LoadTemp();
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



        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    LoadSolarRl();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ausgangbtn_Click(object sender, EventArgs e)
        {

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAussenluft_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void eingangbtn_Click(object sender, EventArgs e)
        {

           
           var solardata = await SolarPanel.LoadSolarPanelData();
           var kollektor = await SolarPanel.LoadSolarPanelData();

           var aussenluftdata1 = await Aussenluft.LoadAlmAussen();
           var aussenluftdata2 = await Aussenluft.LoadTempAussen();
           var fbhdata1 = await FBH.LoadFbhRL();
           var fbhdata2 = await FBH.LoadFbhVL();

           var psobendata= await Pufferspeicher.LoadPSOben();
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
            solarPanels.Add(sol);
            SqliteDataAccess.SaveSolarPanel(sol);


            AussenluftModel alm = new AussenluftModel();
            alm.alm_aussen_temperatur = aussenluftdata1.val;
            alm.aussen_temperatur = aussenluftdata2.val;
            aussenLuft.Add(alm);
            SqliteDataAccess.SaveAußenluft(alm);


             FBHModel fbh = new FBHModel();
             fbh.FBH_VR = fbhdata1.val;
             fbh.FBH_VL = fbhdata2.val;
             fbh.date = DateTime.Now.ToString();
             fussboden.Add(fbh);
             SqliteDataAccess.SaveFBH(fbh);


            PSModel ps = new PSModel();
            ps.PS_unten = psobendata.val;
            ps.PS_oben = psuntendata.val;
            ps.PS_WW = psww.val;
            ps.PS_WW_Zulauf = wwzulauf.val;
            ps.PS_Heiz = psheiz.val;
            fbh.date = DateTime.Now.ToString();
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
            wp.date = DateTime.Now.ToString();
            zisterne.Add(zz);
            SqliteDataAccess.SaveZisterne(zz);


            txtsolar.Text = sol.Temperatur.ToString() + "°C";
            txtKollektor.Text = sol.Kollektor.ToString() + "°C";

            txtaussen.Text = alm.aussen_temperatur.ToString() + "°C";
            txtalm.Text = alm.alm_aussen_temperatur.ToString() + "°C";

            txtfbhVL.Text = fbh.FBH_VL.ToString() + "°C";
            txtfbhRL.Text = fbh.FBH_VR.ToString() + "°C";

            txtPSOben.Text = ps.PS_oben.ToString() + "°C";
            txtPSUnten.Text = ps.PS_unten.ToString() + "°C";
            txtPSHeiz.Text = ps.PS_Heiz.ToString() + "°C";
            txtPSWW.Text = ps.PS_WW.ToString() + "°C";
            txtWW.Text = ps.PS_WW_Zulauf.ToString() + "°C";



            txtSoleRl.Text = wp.Sole_rl.ToString() + "°C";
            txtSoleVl.Text = wp.Sole_vl.ToString() + "°C";
            txtWPInnen.Text  = wp.Wp_innen.ToString() + "°C";   

            txtZisterneOben.Text = zz.Zist_oben.ToString() + "°C";
            txtZisterneUnten.Text = zz.Zist_unten.ToString() + "°C";





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//Solaranlage
//            

//            //Aussenluftmodul
//            var aussenluftdata1 = await Aussenluft.LoadAlmAussen();
//            var aussenluftdata2 = await Aussenluft.LoadTempAussen();

//            AussenluftModel alm = new AussenluftModel();
//            alm.alm_aussen = aussenluftdata1.val;
//            alm.temperature = aussenluftdata2.val;

//            //Fussbodenheizung
//            var fbhdata1 = await Fussbodenheizung.LoadFbhVL();
//            var fbhdata2 = await Fussbodenheizung.LoadFbhRL();


//            //Waermepumpe
//            var wpdata1 = await Waermepumpe.LoadWPinnen();
//            var wpdata2 = await Waermepumpe.LoadSoleVL();
//            var wpdata3 = await Waermepumpe.LoadSoleRL();

//            WaermepumpeModel wp = new WaermepumpeModel();
//            wp.innen = wpdata1.val;
//            wp.sole_vl = wpdata2.val;
//            wp.sole_rl = wpdata3.val;

//            //Zisterne
//            var zisdata1 = await Zisterne.LoadZisUnten();
//            var zisdata2 = await Zisterne.LoadZisOben();

//            ZisterneModel zis = new ZisterneModel();
//            zis.unten = zisdata1.val;
//            zis.oben = zisdata2.val;

//            //Prozessspeicher
//            var psdata1 = await Prozessspeicher.LoadProzOben();
//            var psdata2 = await Prozessspeicher.LoadProzUnten();

//            ProzessspeicherModel ps = new ProzessspeicherModel();
//            ps.oben = psdata1.val;
//            ps.unten = psdata2.val;

//            resultText.Text = $" Solar {sol.Temperatur} \n ALM {alm.alm_aussen} and {alm.temperature} \n FBH {fbh.vl} and {fbh.rl} \n WP {wp.innen} and {wp.sole_vl} and {wp.sole_rl} \n Zis {zis.unten} and {zis.oben} \n PS {ps.oben} and {ps.unten}";