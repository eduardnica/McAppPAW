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
    public partial class FormCumparaturi : Form
    {
        Produs BigTasty, BigMac, RoyalDeluxe, McToast;
        double total = 0;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Proiect;Integrated Security=True";



        public FormCumparaturi()
        {
            InitializeComponent();

            BigMac = new Produs("BigMac", "1",11.99);
            BigTasty = new Produs("BigTasty", "2", 9.99);
            RoyalDeluxe = new Produs("RoyalDeluxe", "3", 14.99);
            McToast = new Produs("McToast", "4", 6.99);
            
            
            

        }

        private void pictureBoxBigTasty_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBigTasty.DoDragDrop(BigTasty, DragDropEffects.Copy);
        }

        private void listViewProduse_DragEnter(object sender, DragEventArgs e)
        {
            

            if (e.Data.GetDataPresent(typeof(Produs)))
            {
                e.Effect = DragDropEffects.Copy;
                
            } else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void pictureBoxBigMac_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxBigMac.DoDragDrop(BigMac, DragDropEffects.Copy);
        }

        private void pictureBoxBigMac_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBigMac.DoDragDrop(BigMac, DragDropEffects.Copy);
        }

        private void pictureBoxRoyalDeluxe_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxRoyalDeluxe.DoDragDrop(RoyalDeluxe, DragDropEffects.Copy);
        }

        private void pictureBoxRoyalDeluxe_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRoyalDeluxe.DoDragDrop(RoyalDeluxe, DragDropEffects.Copy);
        }

        private void pictureBoxToast_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxToast.DoDragDrop(McToast, DragDropEffects.Copy);
        }

        private void pictureBoxToast_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxToast.DoDragDrop(McToast, DragDropEffects.Copy);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewProduse.SelectedItems.Count > 0)
            {
                toolStripMenuItemSterge.Enabled = true;


            }
            else
            {
                toolStripMenuItemSterge.Enabled = false;

            }
        }

        private void toolStripMenuItemSterge_Click(object sender, EventArgs e)
        {
            if (listViewProduse.SelectedItems.Count > 0)
            {
                //Produs p = (Produs)listViewProduse.SelectedItems[0].Tag;

                //DialogResult rezultat = MessageBox.Show("Confirmați ștergerea produsului " + p.denumireProdus + "?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                ListViewItem item = listViewProduse.SelectedItems[0];
                total -= Convert.ToDouble(item.SubItems[2].Text);
                textBoxTotal.Text = total.ToString();
                item.Remove();
        

            }


        }

        private void buttonPlateste_Click(object sender, EventArgs e)
        {
           
            SqlConnection conexiune = new SqlConnection(stringConexiune);

            conexiune.Open();

            //int idclient=0;
            //string cauta = "SELECT MAX(IDComanda) FROM dbo.Clienti) ";
            //SqlCommand cmd2 = new SqlCommand(cauta, conexiune);
            //SqlDataReader reader = cmd2.ExecuteReader();
            //while (reader.Read())
            //{
            //    idclient = reader.GetInt32(0);
            //}
           
            string adauga = "INSERT INTO dbo.Comenzi VALUES ('" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString()+ "' , '"+ textBoxTotal.Text.ToString()  + "'  )";





            SqlCommand cmd = new SqlCommand(adauga, conexiune);
            cmd.ExecuteNonQuery();

            conexiune.Close();

            string text = "Comanda a fost efectuata!";
            MessageBox.Show(text);
            this.Close();



        }

        private void buttonbackCumparaturi_Click_1(object sender, EventArgs e)
        {
            DialogResult rezultat;

            if (listViewProduse.Items.Count > 0)
            {
                rezultat = MessageBox.Show("Aveti produse in cos in valoare de " + total + " . Esti sigur ca doresti sa continui?", "Atentie!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
               
                if (rezultat == DialogResult.Yes)
                {

                    SqlConnection conexiune = new SqlConnection(stringConexiune);
                    conexiune.Open();




                    string stergeClient = "DELETE FROM  dbo.Client WHERE IDClient=(SELECT MAX(IDClient) FROM dbo.Client) ";
                    SqlCommand cmd2 = new SqlCommand(stergeClient, conexiune);
                    cmd2.ExecuteNonQuery();



                    conexiune.Close();




                    this.Close();
                }

            } else {



                SqlConnection conexiune = new SqlConnection(stringConexiune);
                conexiune.Open();





                string stergeClient = "DELETE FROM  dbo.Client WHERE IDClient=(SELECT MAX(IDClient) FROM dbo.Client) ";
                SqlCommand cmd2 = new SqlCommand(stergeClient, conexiune);
                cmd2.ExecuteNonQuery();


                conexiune.Close();


                this.Close();
            }

            
            
        }

        private void pictureBoxBigTasty_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxBigTasty.DoDragDrop(BigTasty, DragDropEffects.Copy);

        }

        private void listViewProduse_DragDrop(object sender, DragEventArgs e)
        {
            Produs p = (Produs)e.Data.GetData(typeof(Produs));
            ListViewItem lvi = new ListViewItem();
            lvi.Text = p.codProdus;
            lvi.SubItems.Add(p.denumireProdus);
            lvi.SubItems.Add(p.pretProdus.ToString());
            listViewProduse.Items.Add(lvi);
            total += p.pretProdus;
            textBoxTotal.Text = total.ToString();

        }

    }
    
}
