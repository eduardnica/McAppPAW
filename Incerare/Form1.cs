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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zonaAcasa1.BringToFront();

            

        }

        private void buttonInchide_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void buttonAcasa_Click(object sender, EventArgs e)
        {
            zonaAcasa1.BringToFront();
        }

        private void buttonClienti_Click(object sender, EventArgs e)
        {
            zonaClienti1.BringToFront();
        }

        private void buttonAngajati_Click(object sender, EventArgs e)
        {
            //FormAngajati a2 = new FormAngajati();
            //a2.ShowDialog();
            userControl11.BringToFront();
            
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic f=new FormGrafic();
            f.ShowDialog();
        }

        private void buttonSalveazaXML_Click(object sender, EventArgs e)
        {
            FormClientiVechi f = new FormClientiVechi();
            f.ShowDialog();
        }

        
    }
}
