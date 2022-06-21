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
            this.txtaussen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.lblWWZulauf = new System.Windows.Forms.Label();
            this.txtPSHeiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPSWW = new System.Windows.Forms.TextBox();
            this.txtWPInnen = new System.Windows.Forms.TextBox();
            this.txtSoleVl = new System.Windows.Forms.TextBox();
            this.txtSoleRl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblwpinnen = new System.Windows.Forms.Label();
            this.lblsolev = new System.Windows.Forms.Label();
            this.lblSoleRl = new System.Windows.Forms.Label();
            this.txtKollektor = new System.Windows.Forms.TextBox();
            this.txtsolar = new System.Windows.Forms.TextBox();
            this.txtPSOben = new System.Windows.Forms.TextBox();
            this.txtPSUnten = new System.Windows.Forms.TextBox();
            this.lblKollektor = new System.Windows.Forms.Label();
            this.lblsolarR = new System.Windows.Forms.Label();
            this.lblPSOben = new System.Windows.Forms.Label();
            this.lblPSUnten = new System.Windows.Forms.Label();
            this.txtZisterneOben = new System.Windows.Forms.TextBox();
            this.lblZisterneOben = new System.Windows.Forms.Label();
            this.txtZisterneUnten = new System.Windows.Forms.TextBox();
            this.txtfbhRL = new System.Windows.Forms.TextBox();
            this.txtfbhVL = new System.Windows.Forms.TextBox();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.lblSolarRL.Size = new System.Drawing.Size(67, 20);
            this.lblSolarRL.TabIndex = 1;
            this.lblSolarRL.Text = "SolarRL";
            // 
            // txtSolarRl
            // 
            this.txtSolarRl.Location = new System.Drawing.Point(655, 366);
            this.txtSolarRl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolarRl.Name = "txtSolarRl";
            this.txtSolarRl.Size = new System.Drawing.Size(192, 26);
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
            this.panel1.Controls.Add(this.txtWW);
            this.panel1.Controls.Add(this.lblWWZulauf);
            this.panel1.Controls.Add(this.txtPSHeiz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPSWW);
            this.panel1.Controls.Add(this.txtWPInnen);
            this.panel1.Controls.Add(this.txtSoleVl);
            this.panel1.Controls.Add(this.txtSoleRl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblwpinnen);
            this.panel1.Controls.Add(this.lblsolev);
            this.panel1.Controls.Add(this.lblSoleRl);
            this.panel1.Controls.Add(this.txtKollektor);
            this.panel1.Controls.Add(this.txtsolar);
            this.panel1.Controls.Add(this.txtPSOben);
            this.panel1.Controls.Add(this.txtPSUnten);
            this.panel1.Controls.Add(this.lblKollektor);
            this.panel1.Controls.Add(this.lblsolarR);
            this.panel1.Controls.Add(this.lblPSOben);
            this.panel1.Controls.Add(this.lblPSUnten);
            this.panel1.Controls.Add(this.txtZisterneOben);
            this.panel1.Controls.Add(this.lblZisterneOben);
            this.panel1.Controls.Add(this.txtZisterneUnten);
            this.panel1.Controls.Add(this.txtfbhRL);
            this.panel1.Controls.Add(this.txtfbhVL);
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
            // txtaussen
            // 
            this.txtaussen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaussen.Location = new System.Drawing.Point(1058, 319);
            this.txtaussen.Name = "txtaussen";
            this.txtaussen.Size = new System.Drawing.Size(100, 30);
            this.txtaussen.TabIndex = 36;
            this.txtaussen.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1062, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Aussen ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWW
            // 
            this.txtWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.Location = new System.Drawing.Point(250, 619);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(100, 30);
            this.txtWW.TabIndex = 34;
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
            // txtPSHeiz
            // 
            this.txtPSHeiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSHeiz.Location = new System.Drawing.Point(1051, 483);
            this.txtPSHeiz.Name = "txtPSHeiz";
            this.txtPSHeiz.Size = new System.Drawing.Size(100, 30);
            this.txtPSHeiz.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1053, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Puffer Heiz";
            // 
            // txtPSWW
            // 
            this.txtPSWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSWW.Location = new System.Drawing.Point(857, 483);
            this.txtPSWW.Name = "txtPSWW";
            this.txtPSWW.Size = new System.Drawing.Size(100, 30);
            this.txtPSWW.TabIndex = 27;
            // 
            // txtWPInnen
            // 
            this.txtWPInnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWPInnen.Location = new System.Drawing.Point(655, 483);
            this.txtWPInnen.Name = "txtWPInnen";
            this.txtWPInnen.Size = new System.Drawing.Size(100, 30);
            this.txtWPInnen.TabIndex = 26;
            // 
            // txtSoleVl
            // 
            this.txtSoleVl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoleVl.Location = new System.Drawing.Point(443, 483);
            this.txtSoleVl.Name = "txtSoleVl";
            this.txtSoleVl.Size = new System.Drawing.Size(100, 30);
            this.txtSoleVl.TabIndex = 25;
            // 
            // txtSoleRl
            // 
            this.txtSoleRl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoleRl.Location = new System.Drawing.Point(250, 483);
            this.txtSoleRl.Name = "txtSoleRl";
            this.txtSoleRl.Size = new System.Drawing.Size(100, 30);
            this.txtSoleRl.TabIndex = 24;
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
            // txtKollektor
            // 
            this.txtKollektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKollektor.Location = new System.Drawing.Point(857, 319);
            this.txtKollektor.Name = "txtKollektor";
            this.txtKollektor.Size = new System.Drawing.Size(100, 30);
            this.txtKollektor.TabIndex = 17;
            // 
            // txtsolar
            // 
            this.txtsolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolar.Location = new System.Drawing.Point(655, 319);
            this.txtsolar.Name = "txtsolar";
            this.txtsolar.Size = new System.Drawing.Size(100, 30);
            this.txtsolar.TabIndex = 16;
            // 
            // txtPSOben
            // 
            this.txtPSOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSOben.Location = new System.Drawing.Point(443, 319);
            this.txtPSOben.Name = "txtPSOben";
            this.txtPSOben.Size = new System.Drawing.Size(100, 30);
            this.txtPSOben.TabIndex = 15;
            // 
            // txtPSUnten
            // 
            this.txtPSUnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSUnten.Location = new System.Drawing.Point(250, 319);
            this.txtPSUnten.Name = "txtPSUnten";
            this.txtPSUnten.Size = new System.Drawing.Size(100, 30);
            this.txtPSUnten.TabIndex = 14;
            this.txtPSUnten.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
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
            // txtZisterneOben
            // 
            this.txtZisterneOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZisterneOben.Location = new System.Drawing.Point(1051, 177);
            this.txtZisterneOben.Name = "txtZisterneOben";
            this.txtZisterneOben.Size = new System.Drawing.Size(100, 30);
            this.txtZisterneOben.TabIndex = 9;
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
            // txtZisterneUnten
            // 
            this.txtZisterneUnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZisterneUnten.Location = new System.Drawing.Point(857, 177);
            this.txtZisterneUnten.Name = "txtZisterneUnten";
            this.txtZisterneUnten.Size = new System.Drawing.Size(100, 30);
            this.txtZisterneUnten.TabIndex = 7;
            // 
            // txtfbhRL
            // 
            this.txtfbhRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfbhRL.Location = new System.Drawing.Point(655, 177);
            this.txtfbhRL.Name = "txtfbhRL";
            this.txtfbhRL.Size = new System.Drawing.Size(100, 30);
            this.txtfbhRL.TabIndex = 6;
            this.txtfbhRL.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtfbhVL
            // 
            this.txtfbhVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfbhVL.Location = new System.Drawing.Point(443, 177);
            this.txtfbhVL.Name = "txtfbhVL";
            this.txtfbhVL.Size = new System.Drawing.Size(100, 30);
            this.txtfbhVL.TabIndex = 5;
            this.txtfbhVL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.NavPanel.Controls.Add(this.dateTimePicker1);
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
            this.pictureBox1.Location = new System.Drawing.Point(138, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headLabel.Location = new System.Drawing.Point(9, 9);
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
          //  this.ausgangbtn.Click += new System.EventHandler(this.ausgangbtn_ClickAsync);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 26);
            this.dateTimePicker1.TabIndex = 1;
           // this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChangedAsync);
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
        private System.Windows.Forms.TextBox txtZisterneUnten;
        private System.Windows.Forms.TextBox txtfbhRL;
        private System.Windows.Forms.TextBox txtfbhVL;
        private System.Windows.Forms.TextBox txtalm;
        private System.Windows.Forms.Label lblZisterneOben;
        private System.Windows.Forms.TextBox txtZisterneOben;
        private System.Windows.Forms.TextBox txtKollektor;
        private System.Windows.Forms.TextBox txtsolar;
        private System.Windows.Forms.TextBox txtPSOben;
        private System.Windows.Forms.TextBox txtPSUnten;
        private System.Windows.Forms.Label lblKollektor;
        private System.Windows.Forms.Label lblsolarR;
        private System.Windows.Forms.Label lblPSOben;
        private System.Windows.Forms.Label lblPSUnten;
        private System.Windows.Forms.TextBox txtPSHeiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPSWW;
        private System.Windows.Forms.TextBox txtWPInnen;
        private System.Windows.Forms.TextBox txtSoleVl;
        private System.Windows.Forms.TextBox txtSoleRl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblwpinnen;
        private System.Windows.Forms.Label lblsolev;
        private System.Windows.Forms.Label lblSoleRl;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Label lblWWZulauf;
        private System.Windows.Forms.TextBox txtaussen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

