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
    public partial class UserControl1 : UserControl
    {

        DataSet DSAngajati = new DataSet();
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";
        string tabela = "dbo.Angajati";

        public UserControl1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            SqlConnection conexiune = new SqlConnection(connString);
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT Count(*) FROM " + tabela + " Where IDAngajat='" + textBoxUsername.Text + "' AND Parola='" + textBoxParola.Text + "';";
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                {
                   
                    FormAngajati a2 = new FormAngajati();
                    a2.ShowDialog();

                }

                else
                    MessageBox.Show("Angajatul nu exista!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }



        }

        private void textBoxParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn_Click(this, new EventArgs());
            }
        }
    }
}
