using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
    






        //Initialisierung des API Helpers
        public Form1()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

        }

        //Methode zum navigieren zwischen den einzelnen Seiten
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

        //Wenn der Button geklickt wird, soll er die Forms für die Ausgänge öffnen
        private void ausgangbtn_Click(object sender, EventArgs e)
        {
            loadform(new Ausgang());
        }

        //Wenn der Button geklickt wird, soll er die Forms für die Eingänge öffnen

        private void eingangbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new Eingang());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadform(new History());
        }

        //private async Task dateTimePicker1_ValueChangedAsync(object sender, EventArgs e)
        //{

    }

       
    }

