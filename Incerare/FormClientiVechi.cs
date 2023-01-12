using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Incerare
{
    public partial class FormClientiVechi : Form
    {

       
        
        public FormClientiVechi()
        {
            InitializeComponent();


            Client c1 = new Client("Dumitru", "Andrei", new DateTime(1999, 06, 22), "0720589880", "Blvd. Unirii nr 3", "1");



            ListViewItem lvi1 = new ListViewItem(c1.nume);
            lvi1.SubItems.Add(c1.prenume);
            lvi1.SubItems.Add(c1.nrTelefon);
            lvi1.SubItems.Add(c1.adresa);
            lvi1.Tag = c1;
            listView1.Items.Add(lvi1);

        }


        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Client c = (Client)lvi.Tag;
                lvi.Text = c.nume;
                lvi.SubItems[1].Text = c.prenume;
                lvi.SubItems[2].Text = c.nrTelefon;
                lvi.SubItems[3].Text = c.adresa;
                
            }
        }


        private void buttonSalvareXML_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Lista-Clienti");

            List<Client> lista = listView1.Items.Cast<ListViewItem>().Select(item => (Client)item.Tag).ToList();

            foreach (Client c in lista)
            {
                writer.WriteStartElement("Client");

                writer.WriteElementString("Nume", c.nume);
                writer.WriteElementString("Prenume", c.prenume);
                writer.WriteElementString("Data-Nasterii", c.dataNasterii.ToString());
                writer.WriteElementString("NrTelefon", c.nrTelefon);
                writer.WriteElementString("Adresa", c.adresa);
                writer.WriteElementString("ID", c.idClient);



                writer.WriteEndElement();

            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            string xmlstring = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("c:\\temp\\Salveaza.xml");
            sw.WriteLine(xmlstring);
            sw.Close();
        }

        private void buttonRestaurareXML_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("c:\\temp\\fisierrestaureaza.xml");
            string str = sr.ReadToEnd();
            List<Client> lista = new List<Client>();
            XmlReader reader = XmlReader.Create(new StringReader(str));
            while (reader.Read())
            {
                if (reader.Name == "Client" && reader.NodeType == XmlNodeType.Element)
                {
                    
                    while (reader.Read() && reader.Name != "Nume") { }
                    reader.Read();
                    string nume = reader.Value;

                    while (reader.Read() && reader.Name != "Prenume") { }
                    reader.Read();
                    string prenume = reader.Value;

                    while (reader.Read() && reader.Name != "Data-Nasterii") { }
                    reader.Read();
                    string dataNasterii = reader.Value;

                    while (reader.Read() && reader.Name != "NrTelefon") { }
                    reader.Read();
                    string nrTelefon = reader.Value;

                    while (reader.Read() && reader.Name != "Adresa") { }
                    reader.Read();
                    string adresa = reader.Value;

                    while (reader.Read() && reader.Name != "ID") { }
                    reader.Read();
                    string idClient = reader.Value;

                    


                    Client clocal = new Client(nume, prenume, DateTime.Parse(dataNasterii), nrTelefon, adresa, idClient);


                    lista.Add(clocal);
                }



            }

            listView1.Items.Clear();
            foreach (Client c in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }

            UpdateItems();
            sr.Close();
        }

        private void buttonbackXML_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
