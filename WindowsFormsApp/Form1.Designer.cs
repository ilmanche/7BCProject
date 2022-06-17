using System;
namespace WindowsFormsApp
{
    partial class Form1

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSolarRL = new System.Windows.Forms.Button();
            this.lblSolarRL = new System.Windows.Forms.Label();
            this.txtSolarRl = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.lblWWZulauf = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblwpinnen = new System.Windows.Forms.Label();
            this.lblsolev = new System.Windows.Forms.Label();
            this.lblSoleRl = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblSoleVl = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtsolar = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblKollektor = new System.Windows.Forms.Label();
            this.lblsolarR = new System.Windows.Forms.Label();
            this.lblPSOben = new System.Windows.Forms.Label();
            this.lblPSUnten = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblZisterneOben = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtalm = new System.Windows.Forms.TextBox();
            this.lblZisterneUnten = new System.Windows.Forms.Label();
            this.lblfbhrl = new System.Windows.Forms.Label();
            this.lblfbhvl = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.dashlbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headLabel = new System.Windows.Forms.Label();
            this.eingangbtn = new System.Windows.Forms.Button();
            this.ausgangbtn = new System.Windows.Forms.Button();
            this.txtaussen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolarRL
            // 
            this.btnSolarRL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSolarRL.Location = new System.Drawing.Point(655, 300);
            this.btnSolarRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolarRL.Name = "btnSolarRL";
            this.btnSolarRL.Size = new System.Drawing.Size(194, 57);
            this.btnSolarRL.TabIndex = 0;
            this.btnSolarRL.Text = "Temperatur anzeigen";
            this.btnSolarRL.UseVisualStyleBackColor = false;
            // 
            // lblSolarRL
            // 
            this.lblSolarRL.AutoSize = true;
            this.lblSolarRL.Location = new System.Drawing.Point(711, 260);
            this.lblSolarRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolarRL.Name = "lblSolarRL";
            this.lblSolarRL.Size = new System.Drawing.Size(45, 13);
            this.lblSolarRL.TabIndex = 1;
            this.lblSolarRL.Text = "SolarRL";
            // 
            // txtSolarRl
            // 
            this.txtSolarRl.Location = new System.Drawing.Point(655, 366);
            this.txtSolarRl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolarRl.Name = "txtSolarRl";
            this.txtSolarRl.Size = new System.Drawing.Size(192, 20);
            this.txtSolarRl.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(877, 300);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 57);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtaussen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.lblWWZulauf);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblwpinnen);
            this.panel1.Controls.Add(this.lblsolev);
            this.panel1.Controls.Add(this.lblSoleRl);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.lblSoleVl);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.txtsolar);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.lblKollektor);
            this.panel1.Controls.Add(this.lblsolarR);
            this.panel1.Controls.Add(this.lblPSOben);
            this.panel1.Controls.Add(this.lblPSUnten);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.lblZisterneOben);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtalm);
            this.panel1.Controls.Add(this.lblZisterneUnten);
            this.panel1.Controls.Add(this.lblfbhrl);
            this.panel1.Controls.Add(this.lblfbhvl);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 692);
            this.panel1.TabIndex = 4;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(250, 619);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 30);
            this.textBox20.TabIndex = 34;
            // 
            // lblWWZulauf
            // 
            this.lblWWZulauf.AutoSize = true;
            this.lblWWZulauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWWZulauf.Location = new System.Drawing.Point(245, 570);
            this.lblWWZulauf.Name = "lblWWZulauf";
            this.lblWWZulauf.Size = new System.Drawing.Size(120, 25);
            this.lblWWZulauf.TabIndex = 30;
            this.lblWWZulauf.Text = "WW Zulauf";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(1051, 483);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 30);
            this.textBox11.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1062, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Puffer Heiz";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(857, 483);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 30);
            this.textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(655, 483);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 30);
            this.textBox13.TabIndex = 26;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(443, 483);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 30);
            this.textBox14.TabIndex = 25;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(250, 483);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 30);
            this.textBox15.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Puffer WW";
            // 
            // lblwpinnen
            // 
            this.lblwpinnen.AutoSize = true;
            this.lblwpinnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwpinnen.Location = new System.Drawing.Point(659, 437);
            this.lblwpinnen.Name = "lblwpinnen";
            this.lblwpinnen.Size = new System.Drawing.Size(107, 25);
            this.lblwpinnen.TabIndex = 22;
            this.lblwpinnen.Text = "WP Innen";
            this.lblwpinnen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsolev
            // 
            this.lblsolev.AutoSize = true;
            this.lblsolev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolev.Location = new System.Drawing.Point(447, 437);
            this.lblsolev.Name = "lblsolev";
            this.lblsolev.Size = new System.Drawing.Size(89, 25);
            this.lblsolev.TabIndex = 21;
            this.lblsolev.Text = "Sole VL";
            // 
            // lblSoleRl
            // 
            this.lblSoleRl.AutoSize = true;
            this.lblSoleRl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoleRl.Location = new System.Drawing.Point(245, 434);
            this.lblSoleRl.Name = "lblSoleRl";
            this.lblSoleRl.Size = new System.Drawing.Size(88, 25);
            this.lblSoleRl.TabIndex = 20;
            this.lblSoleRl.Text = "Sole RL";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(1051, 319);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 19;
            // 
            // lblSoleVl
            // 
            this.lblSoleVl.AutoSize = true;
            this.lblSoleVl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoleVl.Location = new System.Drawing.Point(1062, 270);
            this.lblSoleVl.Name = "lblSoleVl";
            this.lblSoleVl.Size = new System.Drawing.Size(89, 25);
            this.lblSoleVl.TabIndex = 18;
            this.lblSoleVl.Text = "Sole VL";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(857, 319);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 30);
            this.textBox7.TabIndex = 17;
            // 
            // txtsolar
            // 
            this.txtsolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolar.Location = new System.Drawing.Point(655, 319);
            this.txtsolar.Name = "txtsolar";
            this.txtsolar.Size = new System.Drawing.Size(100, 30);
            this.txtsolar.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(443, 319);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 30);
            this.textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(250, 319);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 30);
            this.textBox10.TabIndex = 14;
            // 
            // lblKollektor
            // 
            this.lblKollektor.AutoSize = true;
            this.lblKollektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKollektor.Location = new System.Drawing.Point(860, 270);
            this.lblKollektor.Name = "lblKollektor";
            this.lblKollektor.Size = new System.Drawing.Size(97, 25);
            this.lblKollektor.TabIndex = 13;
            this.lblKollektor.Text = "Kollektor";
            // 
            // lblsolarR
            // 
            this.lblsolarR.AutoSize = true;
            this.lblsolarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolarR.Location = new System.Drawing.Point(659, 273);
            this.lblsolarR.Name = "lblsolarR";
            this.lblsolarR.Size = new System.Drawing.Size(95, 25);
            this.lblsolarR.TabIndex = 12;
            this.lblsolarR.Text = "Solar RL";
            this.lblsolarR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPSOben
            // 
            this.lblPSOben.AutoSize = true;
            this.lblPSOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSOben.Location = new System.Drawing.Point(447, 273);
            this.lblPSOben.Name = "lblPSOben";
            this.lblPSOben.Size = new System.Drawing.Size(100, 25);
            this.lblPSOben.TabIndex = 11;
            this.lblPSOben.Text = "PS Oben";
            // 
            // lblPSUnten
            // 
            this.lblPSUnten.AutoSize = true;
            this.lblPSUnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSUnten.Location = new System.Drawing.Point(245, 270);
            this.lblPSUnten.Name = "lblPSUnten";
            this.lblPSUnten.Size = new System.Drawing.Size(104, 25);
            this.lblPSUnten.TabIndex = 10;
            this.lblPSUnten.Text = "PS Unten";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1051, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 9;
            // 
            // lblZisterneOben
            // 
            this.lblZisterneOben.AutoSize = true;
            this.lblZisterneOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZisterneOben.Location = new System.Drawing.Point(1026, 128);
            this.lblZisterneOben.Name = "lblZisterneOben";
            this.lblZisterneOben.Size = new System.Drawing.Size(149, 25);
            this.lblZisterneOben.TabIndex = 8;
            this.lblZisterneOben.Text = "Zisterne Oben";
            this.lblZisterneOben.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(857, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 30);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(655, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 30);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(443, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 5;
            // 
            // txtalm
            // 
            this.txtalm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalm.Location = new System.Drawing.Point(250, 177);
            this.txtalm.Name = "txtalm";
            this.txtalm.Size = new System.Drawing.Size(100, 30);
            this.txtalm.TabIndex = 4;
            this.txtalm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblZisterneUnten
            // 
            this.lblZisterneUnten.AutoSize = true;
            this.lblZisterneUnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZisterneUnten.Location = new System.Drawing.Point(841, 128);
            this.lblZisterneUnten.Name = "lblZisterneUnten";
            this.lblZisterneUnten.Size = new System.Drawing.Size(153, 25);
            this.lblZisterneUnten.TabIndex = 3;
            this.lblZisterneUnten.Text = "Zisterne Unten";
            this.lblZisterneUnten.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblfbhrl
            // 
            this.lblfbhrl.AutoSize = true;
            this.lblfbhrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfbhrl.Location = new System.Drawing.Point(659, 131);
            this.lblfbhrl.Name = "lblfbhrl";
            this.lblfbhrl.Size = new System.Drawing.Size(86, 25);
            this.lblfbhrl.TabIndex = 2;
            this.lblfbhrl.Text = "FBH RL";
            // 
            // lblfbhvl
            // 
            this.lblfbhvl.AutoSize = true;
            this.lblfbhvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfbhvl.Location = new System.Drawing.Point(447, 131);
            this.lblfbhvl.Name = "lblfbhvl";
            this.lblfbhvl.Size = new System.Drawing.Size(87, 25);
            this.lblfbhvl.TabIndex = 1;
            this.lblfbhvl.Text = "FBH VL";
            this.lblfbhvl.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(232, 128);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(136, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "ALM Aussen";
            this.lbl.Click += new System.EventHandler(this.lblAussenluft_Click);
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.NavPanel.Controls.Add(this.dashlbl);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(206, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(994, 100);
            this.NavPanel.TabIndex = 5;
            // 
            // dashlbl
            // 
            this.dashlbl.AutoSize = true;
            this.dashlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashlbl.Location = new System.Drawing.Point(18, 34);
            this.dashlbl.Name = "dashlbl";
            this.dashlbl.Size = new System.Drawing.Size(119, 25);
            this.dashlbl.TabIndex = 0;
            this.dashlbl.Text = "Dashboard: ";
            this.dashlbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Controls.Add(this.headPanel);
            this.flowLayoutPanel1.Controls.Add(this.eingangbtn);
            this.flowLayoutPanel1.Controls.Add(this.ausgangbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 692);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Teal;
            this.headPanel.Controls.Add(this.pictureBox1);
            this.headPanel.Controls.Add(this.headLabel);
            this.headPanel.Location = new System.Drawing.Point(3, 3);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(200, 100);
            this.headPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headLabel.Location = new System.Drawing.Point(3, 19);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(121, 17);
            this.headLabel.TabIndex = 1;
            this.headLabel.Text = "7BC Dashboard";
            this.headLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // eingangbtn
            // 
            this.eingangbtn.AutoSize = true;
            this.eingangbtn.BackColor = System.Drawing.Color.Teal;
            this.eingangbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eingangbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eingangbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eingangbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingangbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eingangbtn.Location = new System.Drawing.Point(3, 109);
            this.eingangbtn.Name = "eingangbtn";
            this.eingangbtn.Size = new System.Drawing.Size(200, 38);
            this.eingangbtn.TabIndex = 0;
            this.eingangbtn.Text = "Eingänge";
            this.eingangbtn.UseVisualStyleBackColor = false;
            this.eingangbtn.Click += new System.EventHandler(this.eingangbtn_Click);
            // 
            // ausgangbtn
            // 
            this.ausgangbtn.AutoSize = true;
            this.ausgangbtn.BackColor = System.Drawing.Color.Teal;
            this.ausgangbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgangbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ausgangbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgangbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ausgangbtn.Location = new System.Drawing.Point(3, 153);
            this.ausgangbtn.Name = "ausgangbtn";
            this.ausgangbtn.Size = new System.Drawing.Size(200, 38);
            this.ausgangbtn.TabIndex = 1;
            this.ausgangbtn.Text = "Ausgänge";
            this.ausgangbtn.UseVisualStyleBackColor = false;
            this.ausgangbtn.Click += new System.EventHandler(this.ausgangbtn_Click);
            // 
            // txtaussen
            // 
            this.txtaussen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaussen.Location = new System.Drawing.Point(443, 619);
            this.txtaussen.Name = "txtaussen";
            this.txtaussen.Size = new System.Drawing.Size(100, 30);
            this.txtaussen.TabIndex = 36;
            this.txtaussen.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Aussen ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSolarRl);
            this.Controls.Add(this.lblSolarRL);
            this.Controls.Add(this.btnSolarRL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolarRL;
        private System.Windows.Forms.Label lblSolarRL;
        private System.Windows.Forms.TextBox txtSolarRl;

        private void BtnSolarRL_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label dashlbl;
        private System.Windows.Forms.Button eingangbtn;
        private System.Windows.Forms.Button ausgangbtn;
        private System.Windows.Forms.Label lblfbhvl;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblZisterneUnten;
        private System.Windows.Forms.Label lblfbhrl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtalm;
        private System.Windows.Forms.Label lblZisterneOben;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblSoleVl;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtsolar;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblKollektor;
        private System.Windows.Forms.Label lblsolarR;
        private System.Windows.Forms.Label lblPSOben;
        private System.Windows.Forms.Label lblPSUnten;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblwpinnen;
        private System.Windows.Forms.Label lblsolev;
        private System.Windows.Forms.Label lblSoleRl;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label lblWWZulauf;
        private System.Windows.Forms.TextBox txtaussen;
        private System.Windows.Forms.Label label3;
    }
}

