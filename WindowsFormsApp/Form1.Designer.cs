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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.dashlbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headLabel = new System.Windows.Forms.Label();
            this.eingangbtn = new System.Windows.Forms.Button();
            this.ausgangbtn = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
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
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1200, 692);
            this.mainpanel.TabIndex = 4;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.flowLayoutPanel1.Controls.Add(this.btnHistory);
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
            this.pictureBox1.Location = new System.Drawing.Point(153, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
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
            this.eingangbtn.Click += new System.EventHandler(this.eingangbtn_Click_1);
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
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.BackColor = System.Drawing.Color.Teal;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistory.Location = new System.Drawing.Point(3, 197);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 38);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSolarRl);
            this.Controls.Add(this.lblSolarRL);
            this.Controls.Add(this.btnSolarRL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form2";
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
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label dashlbl;
        private System.Windows.Forms.Button eingangbtn;
        private System.Windows.Forms.Button ausgangbtn;
        private System.Windows.Forms.Button btnHistory;
    }
}

