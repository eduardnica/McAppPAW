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
    public partial class ZonaClienti : UserControl
    {

        
        DataSet DSClient = new DataSet();
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";
        



        public ZonaClienti()
        {
            InitializeComponent();


        }



        private void buttonAcasa_Click(object sender, EventArgs e)
        {

            ///////////////////////////               COD CORECT PT FORMULAR PRODUSEE!!   ///////////////////

            bool eroare = false;

            if (textBoxNumeClient.Text.Length == 0)
            {
                errorProvider1.SetError(textBoxNumeClient, "Nu ati completat numele");
                textBoxNumeClient.BackColor = Color.LightCoral;
                eroare = true;
            }
            else
            {
                errorProvider1.SetError(textBoxNumeClient, null);
                textBoxNumeClient.BackColor = Color.White;
            }

            if (textBoxPrenumeClient.Text.Length == 0)
            {
                errorProvider1.SetError(textBoxPrenumeClient, "Nu ati completat prenumele");
                textBoxPrenumeClient.BackColor = Color.LightCoral;
                eroare = true;
            }
            else
            {
                errorProvider1.SetError(textBoxPrenumeClient, null);
                textBoxPrenumeClient.BackColor = Color.White;
            }


            //if (textBoxTelefonClient.Text.Length != 10)
            //{
            //    errorProvider1.SetError(textBoxTelefonClient, "Numar Telefon Incorect!");
            //    textBoxTelefonClient.BackColor = Color.LightCoral;
            //    eroare = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(textBoxTelefonClient, null);
            //    textBoxTelefonClient.BackColor = Color.White;
            //}


            if (textBoxAdresaClient.Text.Length == 0)
            {
                errorProvider1.SetError(textBoxAdresaClient, "Nu ati completat adresa");
                textBoxAdresaClient.BackColor = Color.LightCoral;
                eroare = true;
            }
            else
            {
                errorProvider1.SetError(textBoxAdresaClient, null);
                textBoxAdresaClient.BackColor = Color.White;
            }


            if (!eroare)
            {

                SqlConnection conexiune = new SqlConnection(stringConexiune);
                conexiune.Open();

                string adauga = "INSERT INTO dbo.Client VALUES ('" + textBoxNumeClient.Text + "','" + textBoxPrenumeClient.Text + "','" + dateTimePickerClient.Value.ToShortDateString() + "' ,'" + textBoxTelefonClient.Text + "','" + textBoxAdresaClient.Text + "'  )";
                SqlCommand cmd = new SqlCommand(adauga, conexiune);
                cmd.ExecuteNonQuery();

                conexiune.Close();



                FormCumparaturi f2 = new FormCumparaturi();
                f2.ShowDialog();

            }
        }
    }
}
