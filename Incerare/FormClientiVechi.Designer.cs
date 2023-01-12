
namespace Incerare
{
    partial class FormClientiVechi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRestaurareXML = new System.Windows.Forms.Button();
            this.buttonSalvareXML = new System.Windows.Forms.Button();
            this.panelStanga = new System.Windows.Forms.Panel();
            this.buttonbackXML = new System.Windows.Forms.Button();
            this.panelStanga.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderTelefon,
            this.columnHeaderAdresa});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(243, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 315);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 106;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 93;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 88;
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 127;
            // 
            // buttonRestaurareXML
            // 
            this.buttonRestaurareXML.BackColor = System.Drawing.Color.Black;
            this.buttonRestaurareXML.FlatAppearance.BorderSize = 0;
            this.buttonRestaurareXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurareXML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurareXML.ForeColor = System.Drawing.Color.White;
            this.buttonRestaurareXML.Image = global::Incerare.Properties.Resources.home_26px;
            this.buttonRestaurareXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestaurareXML.Location = new System.Drawing.Point(551, 462);
            this.buttonRestaurareXML.Name = "buttonRestaurareXML";
            this.buttonRestaurareXML.Size = new System.Drawing.Size(278, 61);
            this.buttonRestaurareXML.TabIndex = 8;
            this.buttonRestaurareXML.Text = "Restaurare XML";
            this.buttonRestaurareXML.UseVisualStyleBackColor = false;
            this.buttonRestaurareXML.Click += new System.EventHandler(this.buttonRestaurareXML_Click);
            // 
            // buttonSalvareXML
            // 
            this.buttonSalvareXML.BackColor = System.Drawing.Color.Black;
            this.buttonSalvareXML.FlatAppearance.BorderSize = 0;
            this.buttonSalvareXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvareXML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvareXML.ForeColor = System.Drawing.Color.White;
            this.buttonSalvareXML.Image = global::Incerare.Properties.Resources.home_26px;
            this.buttonSalvareXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvareXML.Location = new System.Drawing.Point(171, 462);
            this.buttonSalvareXML.Name = "buttonSalvareXML";
            this.buttonSalvareXML.Size = new System.Drawing.Size(278, 61);
            this.buttonSalvareXML.TabIndex = 9;
            this.buttonSalvareXML.Text = "Salvare XML";
            this.buttonSalvareXML.UseVisualStyleBackColor = false;
            this.buttonSalvareXML.Click += new System.EventHandler(this.buttonSalvareXML_Click);
            // 
            // panelStanga
            // 
            this.panelStanga.BackColor = System.Drawing.Color.Black;
            this.panelStanga.Controls.Add(this.buttonbackXML);
            this.panelStanga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStanga.Location = new System.Drawing.Point(0, 0);
            this.panelStanga.Name = "panelStanga";
            this.panelStanga.Size = new System.Drawing.Size(147, 564);
            this.panelStanga.TabIndex = 11;
            // 
            // buttonbackXML
            // 
            this.buttonbackXML.FlatAppearance.BorderSize = 0;
            this.buttonbackXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbackXML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackXML.ForeColor = System.Drawing.Color.White;
            this.buttonbackXML.Image = global::Incerare.Properties.Resources.backCumparaturi1;
            this.buttonbackXML.Location = new System.Drawing.Point(12, 12);
            this.buttonbackXML.Name = "buttonbackXML";
            this.buttonbackXML.Size = new System.Drawing.Size(34, 31);
            this.buttonbackXML.TabIndex = 10;
            this.buttonbackXML.UseVisualStyleBackColor = true;
            this.buttonbackXML.Click += new System.EventHandler(this.buttonbackXML_Click);
            // 
            // FormClientiVechi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(939, 564);
            this.Controls.Add(this.panelStanga);
            this.Controls.Add(this.buttonSalvareXML);
            this.Controls.Add(this.buttonRestaurareXML);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientiVechi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientiVechi";
            this.panelStanga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.Button buttonRestaurareXML;
        private System.Windows.Forms.Button buttonSalvareXML;
        private System.Windows.Forms.Panel panelStanga;
        private System.Windows.Forms.Button buttonbackXML;
    }
}