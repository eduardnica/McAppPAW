
namespace Incerare
{
    partial class FormAngajati
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
            this.components = new System.ComponentModel.Container();
            this.panelStanga = new System.Windows.Forms.Panel();
            this.buttonbackCumparaturi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DB_ProiectDataSet = new Incerare._DB_ProiectDataSet();
            this.clientTableAdapter = new Incerare._DB_ProiectDataSetTableAdapters.ClientTableAdapter();
            this.textBoxStergereClient = new System.Windows.Forms.TextBox();
            this.buttonStergereClient = new System.Windows.Forms.Button();
            this.labelStergere = new System.Windows.Forms.Label();
            this.dataGridViewComenzi = new System.Windows.Forms.DataGridView();
            this.iDComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlasareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLivrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DB_ProiectDataSet1 = new Incerare._DB_ProiectDataSet1();
            this.comenziTableAdapter = new Incerare._DB_ProiectDataSet1TableAdapters.ComenziTableAdapter();
            this.labelComanda = new System.Windows.Forms.Label();
            this.buttonStergeComanda = new System.Windows.Forms.Button();
            this.textBoxStergereComanda = new System.Windows.Forms.TextBox();
            this.panelStanga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStanga
            // 
            this.panelStanga.BackColor = System.Drawing.Color.Black;
            this.panelStanga.Controls.Add(this.buttonbackCumparaturi);
            this.panelStanga.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStanga.Location = new System.Drawing.Point(0, 0);
            this.panelStanga.Name = "panelStanga";
            this.panelStanga.Size = new System.Drawing.Size(106, 654);
            this.panelStanga.TabIndex = 10;
            // 
            // buttonbackCumparaturi
            // 
            this.buttonbackCumparaturi.FlatAppearance.BorderSize = 0;
            this.buttonbackCumparaturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbackCumparaturi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackCumparaturi.ForeColor = System.Drawing.Color.White;
            this.buttonbackCumparaturi.Image = global::Incerare.Properties.Resources.backCumparaturi1;
            this.buttonbackCumparaturi.Location = new System.Drawing.Point(12, 12);
            this.buttonbackCumparaturi.Name = "buttonbackCumparaturi";
            this.buttonbackCumparaturi.Size = new System.Drawing.Size(34, 31);
            this.buttonbackCumparaturi.TabIndex = 10;
            this.buttonbackCumparaturi.UseVisualStyleBackColor = true;
            this.buttonbackCumparaturi.Click += new System.EventHandler(this.buttonbackCumparaturi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zona Angajati";
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.AllowUserToAddRows = false;
            this.dataGridViewClienti.AllowUserToDeleteRows = false;
            this.dataGridViewClienti.AutoGenerateColumns = false;
            this.dataGridViewClienti.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridViewClienti.DataSource = this.clientBindingSource;
            this.dataGridViewClienti.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewClienti.Location = new System.Drawing.Point(103, 174);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.ReadOnly = true;
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.Size = new System.Drawing.Size(552, 350);
            this.dataGridViewClienti.TabIndex = 12;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "idClient";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Width = 80;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 80;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenumeDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNasteriiDataGridViewTextBoxColumn.Width = 80;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "nrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "nrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrTelefonDataGridViewTextBoxColumn.Width = 80;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Width = 80;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this._DB_ProiectDataSet;
            // 
            // _DB_ProiectDataSet
            // 
            this._DB_ProiectDataSet.DataSetName = "_DB_ProiectDataSet";
            this._DB_ProiectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxStergereClient
            // 
            this.textBoxStergereClient.Location = new System.Drawing.Point(256, 530);
            this.textBoxStergereClient.Name = "textBoxStergereClient";
            this.textBoxStergereClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxStergereClient.TabIndex = 13;
            // 
            // buttonStergereClient
            // 
            this.buttonStergereClient.Location = new System.Drawing.Point(375, 530);
            this.buttonStergereClient.Name = "buttonStergereClient";
            this.buttonStergereClient.Size = new System.Drawing.Size(75, 23);
            this.buttonStergereClient.TabIndex = 14;
            this.buttonStergereClient.Text = "Sterge Client";
            this.buttonStergereClient.UseVisualStyleBackColor = true;
            this.buttonStergereClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStergere
            // 
            this.labelStergere.AutoSize = true;
            this.labelStergere.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStergere.Location = new System.Drawing.Point(223, 532);
            this.labelStergere.Name = "labelStergere";
            this.labelStergere.Size = new System.Drawing.Size(27, 18);
            this.labelStergere.TabIndex = 15;
            this.labelStergere.Text = "ID:";
            // 
            // dataGridViewComenzi
            // 
            this.dataGridViewComenzi.AllowUserToAddRows = false;
            this.dataGridViewComenzi.AllowUserToDeleteRows = false;
            this.dataGridViewComenzi.AutoGenerateColumns = false;
            this.dataGridViewComenzi.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dataGridViewComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComenzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDComandaDataGridViewTextBoxColumn,
            this.dataPlasareDataGridViewTextBoxColumn,
            this.dataLivrareDataGridViewTextBoxColumn,
            this.pretComandaDataGridViewTextBoxColumn});
            this.dataGridViewComenzi.DataSource = this.comenziBindingSource;
            this.dataGridViewComenzi.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewComenzi.Location = new System.Drawing.Point(616, 174);
            this.dataGridViewComenzi.Name = "dataGridViewComenzi";
            this.dataGridViewComenzi.ReadOnly = true;
            this.dataGridViewComenzi.Size = new System.Drawing.Size(478, 350);
            this.dataGridViewComenzi.TabIndex = 16;
            // 
            // iDComandaDataGridViewTextBoxColumn
            // 
            this.iDComandaDataGridViewTextBoxColumn.DataPropertyName = "IDComanda";
            this.iDComandaDataGridViewTextBoxColumn.HeaderText = "IDComanda";
            this.iDComandaDataGridViewTextBoxColumn.Name = "iDComandaDataGridViewTextBoxColumn";
            this.iDComandaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPlasareDataGridViewTextBoxColumn
            // 
            this.dataPlasareDataGridViewTextBoxColumn.DataPropertyName = "DataPlasare";
            this.dataPlasareDataGridViewTextBoxColumn.HeaderText = "DataPlasare";
            this.dataPlasareDataGridViewTextBoxColumn.Name = "dataPlasareDataGridViewTextBoxColumn";
            this.dataPlasareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLivrareDataGridViewTextBoxColumn
            // 
            this.dataLivrareDataGridViewTextBoxColumn.DataPropertyName = "DataLivrare";
            this.dataLivrareDataGridViewTextBoxColumn.HeaderText = "DataLivrare";
            this.dataLivrareDataGridViewTextBoxColumn.Name = "dataLivrareDataGridViewTextBoxColumn";
            this.dataLivrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretComandaDataGridViewTextBoxColumn
            // 
            this.pretComandaDataGridViewTextBoxColumn.DataPropertyName = "PretComanda";
            this.pretComandaDataGridViewTextBoxColumn.HeaderText = "PretComanda";
            this.pretComandaDataGridViewTextBoxColumn.Name = "pretComandaDataGridViewTextBoxColumn";
            this.pretComandaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comenziBindingSource
            // 
            this.comenziBindingSource.DataMember = "Comenzi";
            this.comenziBindingSource.DataSource = this._DB_ProiectDataSet1;
            // 
            // _DB_ProiectDataSet1
            // 
            this._DB_ProiectDataSet1.DataSetName = "_DB_ProiectDataSet1";
            this._DB_ProiectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // labelComanda
            // 
            this.labelComanda.AutoSize = true;
            this.labelComanda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComanda.Location = new System.Drawing.Point(730, 532);
            this.labelComanda.Name = "labelComanda";
            this.labelComanda.Size = new System.Drawing.Size(27, 18);
            this.labelComanda.TabIndex = 19;
            this.labelComanda.Text = "ID:";
            // 
            // buttonStergeComanda
            // 
            this.buttonStergeComanda.Location = new System.Drawing.Point(882, 530);
            this.buttonStergeComanda.Name = "buttonStergeComanda";
            this.buttonStergeComanda.Size = new System.Drawing.Size(106, 23);
            this.buttonStergeComanda.TabIndex = 18;
            this.buttonStergeComanda.Text = "Sterge Comanda";
            this.buttonStergeComanda.UseVisualStyleBackColor = true;
            this.buttonStergeComanda.Click += new System.EventHandler(this.buttonStergeComanda_Click);
            // 
            // textBoxStergereComanda
            // 
            this.textBoxStergereComanda.Location = new System.Drawing.Point(763, 530);
            this.textBoxStergereComanda.Name = "textBoxStergereComanda";
            this.textBoxStergereComanda.Size = new System.Drawing.Size(100, 20);
            this.textBoxStergereComanda.TabIndex = 17;
            // 
            // FormAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 654);
            this.Controls.Add(this.labelComanda);
            this.Controls.Add(this.buttonStergeComanda);
            this.Controls.Add(this.textBoxStergereComanda);
            this.Controls.Add(this.dataGridViewComenzi);
            this.Controls.Add(this.labelStergere);
            this.Controls.Add(this.buttonStergereClient);
            this.Controls.Add(this.textBoxStergereClient);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelStanga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAngajati";
            this.Load += new System.EventHandler(this.FormAngajati_Load);
            this.panelStanga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_ProiectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelStanga;
        private System.Windows.Forms.Button buttonbackCumparaturi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private _DB_ProiectDataSet _DB_ProiectDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private _DB_ProiectDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxStergereClient;
        private System.Windows.Forms.Button buttonStergereClient;
        private System.Windows.Forms.Label labelStergere;
        private System.Windows.Forms.DataGridView dataGridViewComenzi;
        private _DB_ProiectDataSet1 _DB_ProiectDataSet1;
        private System.Windows.Forms.BindingSource comenziBindingSource;
        private _DB_ProiectDataSet1TableAdapters.ComenziTableAdapter comenziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlasareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLivrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelComanda;
        private System.Windows.Forms.Button buttonStergeComanda;
        private System.Windows.Forms.TextBox textBoxStergereComanda;
    }
}