
namespace Incerare
{
    partial class ZonaClienti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZonaClienti));
            this.labelDataNasterii = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeClient = new System.Windows.Forms.TextBox();
            this.textBoxTelefonClient = new System.Windows.Forms.TextBox();
            this.textBoxAdresaClient = new System.Windows.Forms.TextBox();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.buttonAcasa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._DB_ProiectDataSet1 = new Incerare._DB_ProiectDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProiectDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Incerare._DB_ProiectDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataNasterii
            // 
            this.labelDataNasterii.AutoSize = true;
            this.labelDataNasterii.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNasterii.Location = new System.Drawing.Point(25, 91);
            this.labelDataNasterii.Name = "labelDataNasterii";
            this.labelDataNasterii.Size = new System.Drawing.Size(88, 17);
            this.labelDataNasterii.TabIndex = 2;
            this.labelDataNasterii.Text = "DataNasterii";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(25, 130);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(53, 17);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresa.Location = new System.Drawing.Point(26, 167);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(52, 17);
            this.labelAdresa.TabIndex = 4;
            this.labelAdresa.Text = "Adresa";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(25, 14);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(47, 17);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.Location = new System.Drawing.Point(25, 52);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.BackColor = System.Drawing.Color.White;
            this.textBoxNumeClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeClient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNumeClient.Location = new System.Drawing.Point(155, 14);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(111, 22);
            this.textBoxNumeClient.TabIndex = 5;
            // 
            // textBoxPrenumeClient
            // 
            this.textBoxPrenumeClient.BackColor = System.Drawing.Color.White;
            this.textBoxPrenumeClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenumeClient.Location = new System.Drawing.Point(155, 47);
            this.textBoxPrenumeClient.Name = "textBoxPrenumeClient";
            this.textBoxPrenumeClient.Size = new System.Drawing.Size(111, 22);
            this.textBoxPrenumeClient.TabIndex = 6;
            // 
            // textBoxTelefonClient
            // 
            this.textBoxTelefonClient.BackColor = System.Drawing.Color.White;
            this.textBoxTelefonClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefonClient.Location = new System.Drawing.Point(155, 129);
            this.textBoxTelefonClient.Name = "textBoxTelefonClient";
            this.textBoxTelefonClient.Size = new System.Drawing.Size(111, 22);
            this.textBoxTelefonClient.TabIndex = 7;
            // 
            // textBoxAdresaClient
            // 
            this.textBoxAdresaClient.BackColor = System.Drawing.Color.White;
            this.textBoxAdresaClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresaClient.Location = new System.Drawing.Point(155, 167);
            this.textBoxAdresaClient.Name = "textBoxAdresaClient";
            this.textBoxAdresaClient.Size = new System.Drawing.Size(111, 22);
            this.textBoxAdresaClient.TabIndex = 8;
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerClient.Location = new System.Drawing.Point(155, 91);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerClient.TabIndex = 9;
            // 
            // buttonAcasa
            // 
            this.buttonAcasa.BackColor = System.Drawing.Color.Black;
            this.buttonAcasa.FlatAppearance.BorderSize = 0;
            this.buttonAcasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcasa.ForeColor = System.Drawing.Color.White;
            this.buttonAcasa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAcasa.Image")));
            this.buttonAcasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcasa.Location = new System.Drawing.Point(48, 218);
            this.buttonAcasa.Name = "buttonAcasa";
            this.buttonAcasa.Size = new System.Drawing.Size(218, 52);
            this.buttonAcasa.TabIndex = 10;
            this.buttonAcasa.Text = "Mergi la cumparaturi";
            this.buttonAcasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcasa.UseVisualStyleBackColor = false;
            this.buttonAcasa.Click += new System.EventHandler(this.buttonAcasa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // _DB_ProiectDataSet1
            // 
            this._DB_ProiectDataSet1.DataSetName = "_DB_ProiectDataSet";
            this._DB_ProiectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dBProiectDataSet1BindingSource;
            // 
            // dBProiectDataSet1BindingSource
            // 
            this.dBProiectDataSet1BindingSource.DataSource = this._DB_ProiectDataSet1;
            this.dBProiectDataSet1BindingSource.Position = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ZonaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonAcasa);
            this.Controls.Add(this.dateTimePickerClient);
            this.Controls.Add(this.textBoxAdresaClient);
            this.Controls.Add(this.textBoxTelefonClient);
            this.Controls.Add(this.textBoxPrenumeClient);
            this.Controls.Add(this.textBoxNumeClient);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelDataNasterii);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "ZonaClienti";
            this.Size = new System.Drawing.Size(787, 414);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDataNasterii;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.TextBox textBoxPrenumeClient;
        private System.Windows.Forms.TextBox textBoxTelefonClient;
        private System.Windows.Forms.TextBox textBoxAdresaClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.Button buttonAcasa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private _DB_ProiectDataSet _DB_ProiectDataSet1;
        private System.Windows.Forms.BindingSource dBProiectDataSet1BindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private _DB_ProiectDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}
