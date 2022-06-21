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
using ClassLibrary.Models.Ausgänge;

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
 
        


        private void Ausgangbtn_Click(object sender, EventArgs e)
        {
        }
        private void Eingangbtn_Click(object sender, EventArgs e)
        {

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

        private void eingangbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new Eingang());

        }
    }
}