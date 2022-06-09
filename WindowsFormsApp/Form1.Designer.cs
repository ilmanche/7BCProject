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
            this.btnSolarRL = new System.Windows.Forms.Button();
            this.lblSolarRL = new System.Windows.Forms.Label();
            this.txtSolarRl = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolarRL
            // 
            this.btnSolarRL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSolarRL.Location = new System.Drawing.Point(54, 91);
            this.btnSolarRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolarRL.Name = "btnSolarRL";
            this.btnSolarRL.Size = new System.Drawing.Size(194, 57);
            this.btnSolarRL.TabIndex = 0;
            this.btnSolarRL.Text = "Temperatur anzeigen";
            this.btnSolarRL.UseVisualStyleBackColor = false;
            this.btnSolarRL.Click += new System.EventHandler(this.btnSolarRL_Click);
            // 
            // lblSolarRL
            // 
            this.lblSolarRL.AutoSize = true;
            this.lblSolarRL.Location = new System.Drawing.Point(110, 51);
            this.lblSolarRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolarRL.Name = "lblSolarRL";
            this.lblSolarRL.Size = new System.Drawing.Size(67, 20);
            this.lblSolarRL.TabIndex = 1;
            this.lblSolarRL.Text = "SolarRL";
            // 
            // txtSolarRl
            // 
            this.txtSolarRl.Location = new System.Drawing.Point(54, 157);
            this.txtSolarRl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolarRl.Name = "txtSolarRl";
            this.txtSolarRl.Size = new System.Drawing.Size(192, 26);
            this.txtSolarRl.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(276, 91);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 57);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSolarRl);
            this.Controls.Add(this.lblSolarRL);
            this.Controls.Add(this.btnSolarRL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form2";
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
    }
}

