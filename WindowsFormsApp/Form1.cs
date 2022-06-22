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
