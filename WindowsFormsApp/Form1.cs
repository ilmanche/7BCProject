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
           var aussenluftdata1 = await Aussenluft.LoadAlmAussen();
           var aussenluftdata2 = await Aussenluft.LoadTempAussen();


            SolarRLModel sol = new SolarRLModel();
            sol.Temperatur = solardata.val;
            solarPanels.Add(sol);
            SqliteDataAccess.SaveSolarPanel(sol);


            AussenluftModel alm = new AussenluftModel();
            alm.alm_aussen_temperatur = aussenluftdata1.val;
            alm.aussen_temperatur = aussenluftdata2.val;
            aussenLuft.Add(alm);
            SqliteDataAccess.SaveAußenluft(alm);


            txtsolar.Text = sol.Temperatur.ToString();
            txtaussen.Text = alm.aussen_temperatur.ToString();
            txtalm.Text = alm.alm_aussen_temperatur.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

//            FusbodenheizungModel fbh = new FusbodenheizungModel();
//            fbh.vl = fbhdata1.val;
//            fbh.rl = fbhdata2.val;

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