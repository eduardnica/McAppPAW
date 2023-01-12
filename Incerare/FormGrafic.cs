using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incerare
{
    public partial class FormGrafic : Form
    {
        Produs BigMac = new Produs("BigMac", "1",11.99);
        Produs BigTasty = new Produs("BigTasty", "2", 9.99);
        Produs RoyalDeluxe = new Produs("RoyalDeluxe", "3", 14.99);
        Produs McToast = new Produs("McToast", "4", 6.99);


        int nrobs;
        float[] x;
        float[] y;
        public FormGrafic()
        {

            float a1 = (float)(Convert.ToInt32(BigMac.codProdus));
            float a2 = (float)(Convert.ToInt32(BigTasty.codProdus));
            float a3 = (float)(Convert.ToInt32(RoyalDeluxe.codProdus));
            float a4 = (float)(Convert.ToInt32(McToast.codProdus));


            float b1 = (float)(BigMac.pretProdus);
            float b2 = (float)(BigTasty.pretProdus);
            float b3 = (float)(RoyalDeluxe.pretProdus);
            float b4 = (float)(McToast.pretProdus);



            InitializeComponent();
            nrobs = 4;
            x = new float[] { a1, a2, a3, a4 };
            y = new float[] { b1, b2, b3, b4 };



        }

      
       

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);
            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 2; zonaClient.Y += 2;
            zonaClient.Height -= 4; zonaClient.Width -= 4;

            Pen creionRosu = new Pen(Color.Red, 2);
            g.DrawRectangle(creionRosu, zonaClient);

            int vl = zonaClient.Left, vb = zonaClient.Bottom, vr = zonaClient.Right, vt = zonaClient.Top;

            float rap_dist_lat = 0.2f, max;

            int lat, dist;
            string denx = "";


            SolidBrush[] pensule = new SolidBrush[] {
            new SolidBrush(Color.Pink),
            new SolidBrush(Color.Moccasin),
            new SolidBrush(Color.DarkOrange),
            new SolidBrush(Color.DarkGray)};


            SolidBrush pensulacurenta;
            Pen creioncurent;


            int i = 1;
            max = y[0];
            for (i = 1; i < nrobs; i++)
            {
                if (max < y[i])
                    max = y[i];
            }
            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            dist = (int)(lat * rap_dist_lat);

            creioncurent = new Pen(Color.DarkMagenta);
            g.DrawLine(creioncurent, vl, vt, vl, vb);
            g.DrawLine(creioncurent, vl, vb, vr, vb);

            creioncurent = new Pen(Color.Fuchsia);
            for (i = 0; i < nrobs; i++)
            {
                pensulacurenta = pensule[(i + 2) % 4];
                PointF pnt = new PointF(vl + dist + i * (lat + dist), vb - y[i] * (vb - vt) / max);

                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pensulacurenta, new RectangleF(pnt, sz));

                textBox1.Text += "\r\n(" + Math.Round(pnt.X, 2) + ", " + Math.Round(pnt.Y, 2) + ")==>" + Math.Round(sz.Width, 2) +
                    ", " + Math.Round(sz.Height, 2);

                denx = x[i].ToString();
                g.DrawString(denx, Font, pensulacurenta, vl + dist + i * (lat + dist) + lat / 3, vb + 5);
            }

            textBox1.Text += "\r\n";


        }

        private void panel2_Resize_1(object sender, EventArgs e)
        {
            panel2.Invalidate();
        }
    }
}
