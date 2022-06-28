namespace WindowsFormsApp
{
    partial class History
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
            this.listboxeingang = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnloadeingang = new System.Windows.Forms.Button();
            this.btnausgang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxeingang
            // 
            this.listboxeingang.ColumnWidth = 4;
            this.listboxeingang.FormattingEnabled = true;
            this.listboxeingang.HorizontalScrollbar = true;
            this.listboxeingang.ItemHeight = 20;
            this.listboxeingang.Location = new System.Drawing.Point(274, 201);
            this.listboxeingang.Name = "listboxeingang";
            this.listboxeingang.ScrollAlwaysVisible = true;
            this.listboxeingang.Size = new System.Drawing.Size(1077, 504);
            this.listboxeingang.TabIndex = 1;
            this.listboxeingang.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "M/dd/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(755, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2022, 6, 26, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnloadeingang
            // 
            this.btnloadeingang.Location = new System.Drawing.Point(262, 89);
            this.btnloadeingang.Name = "btnloadeingang";
            this.btnloadeingang.Size = new System.Drawing.Size(112, 71);
            this.btnloadeingang.TabIndex = 3;
            this.btnloadeingang.Text = "Eingänge laden";
            this.btnloadeingang.UseVisualStyleBackColor = true;
            this.btnloadeingang.Click += new System.EventHandler(this.btnloadeingang_Click);
            // 
            // btnausgang
            // 
            this.btnausgang.Location = new System.Drawing.Point(403, 89);
            this.btnausgang.Name = "btnausgang";
            this.btnausgang.Size = new System.Drawing.Size(112, 71);
            this.btnausgang.TabIndex = 4;
            this.btnausgang.Text = "Ausgänge laden";
            this.btnausgang.UseVisualStyleBackColor = true;
            this.btnausgang.Click += new System.EventHandler(this.btnausgang_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 750);
            this.Controls.Add(this.btnausgang);
            this.Controls.Add(this.btnloadeingang);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.listboxeingang);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxeingang;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnloadeingang;
        private System.Windows.Forms.Button btnausgang;
    }
}