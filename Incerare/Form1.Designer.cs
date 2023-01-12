
namespace Incerare
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
            this.panelStanga = new System.Windows.Forms.Panel();
            this.buttonXML = new System.Windows.Forms.Button();
            this.buttonGrafic = new System.Windows.Forms.Button();
            this.buttonAngajati = new System.Windows.Forms.Button();
            this.buttonClienti = new System.Windows.Forms.Button();
            this.buttonAcasa = new System.Windows.Forms.Button();
            this.panelSus = new System.Windows.Forms.Panel();
            this.buttonInchide = new System.Windows.Forms.Button();
            this.userControl11 = new Incerare.UserControl1();
            this.zonaAcasa1 = new Incerare.zonaAcasa();
            this.zonaClienti1 = new Incerare.ZonaClienti();
            this.panelStanga.SuspendLayout();
            this.panelSus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStanga
            // 
            this.panelStanga.BackColor = System.Drawing.Color.Black;
            this.panelStanga.Controls.Add(this.buttonXML);
            this.panelStanga.Controls.Add(this.buttonGrafic);
            this.panelStanga.Controls.Add(this.buttonAngajati);
            this.panelStanga.Controls.Add(this.buttonClienti);
            this.panelStanga.Controls.Add(this.buttonAcasa);
            this.panelStanga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStanga.Location = new System.Drawing.Point(0, 0);
            this.panelStanga.Name = "panelStanga";
            this.panelStanga.Size = new System.Drawing.Size(174, 511);
            this.panelStanga.TabIndex = 0;
            // 
            // buttonXML
            // 
            this.buttonXML.FlatAppearance.BorderSize = 0;
            this.buttonXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXML.ForeColor = System.Drawing.Color.White;
            this.buttonXML.Image = ((System.Drawing.Image)(resources.GetObject("buttonXML.Image")));
            this.buttonXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXML.Location = new System.Drawing.Point(-3, 340);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(208, 52);
            this.buttonXML.TabIndex = 6;
            this.buttonXML.Text = "XML";
            this.buttonXML.UseVisualStyleBackColor = true;
            this.buttonXML.Click += new System.EventHandler(this.buttonSalveazaXML_Click);
            // 
            // buttonGrafic
            // 
            this.buttonGrafic.FlatAppearance.BorderSize = 0;
            this.buttonGrafic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrafic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrafic.ForeColor = System.Drawing.Color.White;
            this.buttonGrafic.Image = ((System.Drawing.Image)(resources.GetObject("buttonGrafic.Image")));
            this.buttonGrafic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrafic.Location = new System.Drawing.Point(-3, 282);
            this.buttonGrafic.Name = "buttonGrafic";
            this.buttonGrafic.Size = new System.Drawing.Size(208, 52);
            this.buttonGrafic.TabIndex = 5;
            this.buttonGrafic.Text = "Grafic";
            this.buttonGrafic.UseVisualStyleBackColor = true;
            this.buttonGrafic.Click += new System.EventHandler(this.buttonGrafic_Click);
            // 
            // buttonAngajati
            // 
            this.buttonAngajati.FlatAppearance.BorderSize = 0;
            this.buttonAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngajati.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAngajati.ForeColor = System.Drawing.Color.White;
            this.buttonAngajati.Image = global::Incerare.Properties.Resources.Angajat;
            this.buttonAngajati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAngajati.Location = new System.Drawing.Point(-3, 224);
            this.buttonAngajati.Name = "buttonAngajati";
            this.buttonAngajati.Size = new System.Drawing.Size(211, 52);
            this.buttonAngajati.TabIndex = 4;
            this.buttonAngajati.Text = "Zona Angajati";
            this.buttonAngajati.UseVisualStyleBackColor = true;
            this.buttonAngajati.Click += new System.EventHandler(this.buttonAngajati_Click);
            // 
            // buttonClienti
            // 
            this.buttonClienti.FlatAppearance.BorderSize = 0;
            this.buttonClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienti.ForeColor = System.Drawing.Color.White;
            this.buttonClienti.Image = global::Incerare.Properties.Resources.Client;
            this.buttonClienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienti.Location = new System.Drawing.Point(0, 166);
            this.buttonClienti.Name = "buttonClienti";
            this.buttonClienti.Size = new System.Drawing.Size(208, 52);
            this.buttonClienti.TabIndex = 3;
            this.buttonClienti.Text = "Zona Clienti";
            this.buttonClienti.UseVisualStyleBackColor = true;
            this.buttonClienti.Click += new System.EventHandler(this.buttonClienti_Click);
            // 
            // buttonAcasa
            // 
            this.buttonAcasa.FlatAppearance.BorderSize = 0;
            this.buttonAcasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcasa.ForeColor = System.Drawing.Color.White;
            this.buttonAcasa.Image = global::Incerare.Properties.Resources.home_26px;
            this.buttonAcasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcasa.Location = new System.Drawing.Point(-3, 108);
            this.buttonAcasa.Name = "buttonAcasa";
            this.buttonAcasa.Size = new System.Drawing.Size(208, 52);
            this.buttonAcasa.TabIndex = 2;
            this.buttonAcasa.Text = "Acasa";
            this.buttonAcasa.UseVisualStyleBackColor = true;
            this.buttonAcasa.Click += new System.EventHandler(this.buttonAcasa_Click);
            // 
            // panelSus
            // 
            this.panelSus.BackColor = System.Drawing.Color.DarkRed;
            this.panelSus.Controls.Add(this.buttonInchide);
            this.panelSus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSus.Location = new System.Drawing.Point(174, 0);
            this.panelSus.Name = "panelSus";
            this.panelSus.Size = new System.Drawing.Size(725, 48);
            this.panelSus.TabIndex = 1;
            // 
            // buttonInchide
            // 
            this.buttonInchide.FlatAppearance.BorderSize = 0;
            this.buttonInchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInchide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchide.ForeColor = System.Drawing.Color.White;
            this.buttonInchide.Image = global::Incerare.Properties.Resources.inchide;
            this.buttonInchide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInchide.Location = new System.Drawing.Point(669, 8);
            this.buttonInchide.Name = "buttonInchide";
            this.buttonInchide.Size = new System.Drawing.Size(37, 37);
            this.buttonInchide.TabIndex = 5;
            this.buttonInchide.UseVisualStyleBackColor = true;
            this.buttonInchide.Click += new System.EventHandler(this.buttonInchide_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(174, 98);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(725, 413);
            this.userControl11.TabIndex = 4;
            // 
            // zonaAcasa1
            // 
            this.zonaAcasa1.BackColor = System.Drawing.SystemColors.Control;
            this.zonaAcasa1.Location = new System.Drawing.Point(180, 108);
            this.zonaAcasa1.Name = "zonaAcasa1";
            this.zonaAcasa1.Size = new System.Drawing.Size(788, 414);
            this.zonaAcasa1.TabIndex = 3;
            // 
            // zonaClienti1
            // 
            this.zonaClienti1.BackColor = System.Drawing.SystemColors.Control;
            this.zonaClienti1.Location = new System.Drawing.Point(180, 108);
            this.zonaClienti1.Name = "zonaClienti1";
            this.zonaClienti1.Size = new System.Drawing.Size(718, 407);
            this.zonaClienti1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.zonaAcasa1);
            this.Controls.Add(this.zonaClienti1);
            this.Controls.Add(this.panelSus);
            this.Controls.Add(this.panelStanga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelStanga.ResumeLayout(false);
            this.panelSus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStanga;
        private System.Windows.Forms.Panel panelSus;
        private System.Windows.Forms.Button buttonAcasa;
        private System.Windows.Forms.Button buttonClienti;
        private System.Windows.Forms.Button buttonAngajati;
        private System.Windows.Forms.Button buttonInchide;
        private ZonaClienti zonaClienti1;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.Button buttonGrafic;
        private zonaAcasa zonaAcasa1;
        private UserControl1 userControl11;
    }
}

