using ClassLibrary;
using ClassLibrary.Models.Ausgänge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
    






        public Form1()
        {
            InitializeComponent();
            
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }



      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async Task ausgangbtn_ClickAsync(object sender, EventArgs e)
        {
            //var Pumpe_Solar = await Ausgaenge.LoadPumpeSolar();
            //var Pumpe_Zirku = await Ausgaenge.LoadPumpeZirku();
            //var Ventil_Sole1 = await Ausgaenge.LoadVentilSole1();
            //var Ventil_Solar1 = await Ausgaenge.LoadVentilSolar1();
            //var Heizband_ALM = await Ausgaenge.LoadHeizbandALM();
            //var Pumpe_Sole = await Ausgaenge.LoadPumpeSole();
            //var Ventil_WW = await Ausgaenge.LoadVentilWW();
            //var Pumpe_Hzkr = await Ausgaenge.LoadPumpeHzkr();
            //var Mischer_Auf = await Ausgaenge.LoadMischerAuf();
            //var Mischer_Zu = await Ausgaenge.LoadMischerZu();
            //var Ventil_Sole2 = await Ausgaenge.LoadVentilSole2();
            //// var Ventil_Solar2 = await Ausgaenge.LoadVentilSolar2();
            //var Wp_Anf = await Ausgaenge.LoadWPAnf();


            //AusgaengeModel ausgaenge = new AusgaengeModel();
            //ausgaenge.date = DateTime.Now.ToString();
            //ausgaenge.Heizband_ALM = Heizband_ALM.state;
            //ausgaenge.Mischer_Auf = Mischer_Auf.state;
            //ausgaenge.Mischer_Zu = Mischer_Zu.state;
            //ausgaenge.Pumpe_Hzkr = Pumpe_Hzkr.state;
            //ausgaenge.Pumpe_Solar = Pumpe_Solar.state;
            //ausgaenge.Pumpe_Sole = Pumpe_Sole.state;
            //ausgaenge.Pumpe_Zirku = Pumpe_Zirku.state;
            //ausgaenge.Ventil_Solar1 = Ventil_Solar1.state;
            //// ausgaenge.Ventil_Solar2 = Ventil_Solar2.state;
            //ausgaenge.Ventil_Sole1 = Ventil_Sole1.state;
            //ausgaenge.Ventil_Sole2 = Ventil_Sole2.state;
            //ausgaenge.Ventil_WW = Ventil_WW.state;
            //ausgaenge.Wp_Anf = Wp_Anf.state;

            //ausgang.Add(ausgaenge);
            //SqliteDataAccess.SaveAusgang(ausgaenge);


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
            loadform(new Eingang());

           




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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ausgangbtn_Click(object sender, EventArgs e)
        {
            loadform(new Ausgang());
        }

        //private async Task dateTimePicker1_ValueChangedAsync(object sender, EventArgs e)
        //{

        //    zisterne = SqliteDataAccess.LoadZist();


        //    var result = zisterne.Where(d =>
        //    {
        //        return d.date == dateTimePicker1.Value.ToString();
        //    }).ToList();


        //    ZisterneModel zz = new ZisterneModel();
        //    zz.Zist_unten = zisterne.Select(d => d.Zist_unten).First();
        //    zz.Zist_unten = zisterne.Select(d => d.Zist_oben).First();

        //    txtZisterneOben.Text = zz.Zist_oben.ToString() + "°C";
        //    txtZisterneUnten.Text = zz.Zist_unten.ToString() + "°C";

        //}
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