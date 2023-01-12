using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incerare
{
    public partial class FormAngajati : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";

        public FormAngajati()
        {
            InitializeComponent();
        }

        private void buttonbackCumparaturi_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DB_ProiectDataSet1.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this._DB_ProiectDataSet1.Comenzi);

            // TODO: This line of code loads data into the '_DB_ProiectDataSet.Client' table. You can move, or remove it, as needed.
            _DB_ProiectDataSet.EnforceConstraints = false;
            this.clientTableAdapter.Fill(this._DB_ProiectDataSet.Client);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();



            string sterge = " delete from dbo.Client where idClient= '" + textBoxStergereClient.Text + "' ";
            SqlCommand cmd = new SqlCommand(sterge, conexiune);
            cmd.ExecuteNonQuery();



            conexiune.Close();
        }

        private void buttonStergeComanda_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();



            string sterge = " delete from dbo.Comenzi where IDComanda= '" + textBoxStergereComanda.Text + "' ";
            SqlCommand cmd = new SqlCommand(sterge, conexiune);
            cmd.ExecuteNonQuery();



            conexiune.Close();
        }
    }
}
