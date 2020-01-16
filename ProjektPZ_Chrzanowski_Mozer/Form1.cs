using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPZ_Chrzanowski_Mozer
{
    public partial class Form1 : Form
    {
        Bitmap mapa = new Bitmap(@"..\..\mapa.png");
        Bitmap mapaOrginal = new Bitmap(@"..\..\mapa.png");
        Wierzcholek[] punkty = new Wierzcholek[3000];
        Pen blackPen = new Pen(Color.Black, 3);
        Pen bluePen = new Pen(Color.Pink, 3);
        Pen greenPen = new Pen(Color.Green, 1);
        Pen blue2Pen = new Pen(Color.Blue, 3);
        int[] wspolrzedne = new int[10] {926, 255, 1584, 729, 580, 320, 1012, 236, 1584, 347};
        String cel;
        String start;
        // Londyn 926, 255 Sydney - 1584, 729 NY - 1859, 1079 GD 1012, 236

        public class point
        {
            public int x;
            public int y;
            public bool odwiedzonyW = false;
            public bool odwiedzonyS = false;
            public int[,] dystans;
            public int[] sasiad;

        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = mapa;
            punkty[0] = new Wierzcholek();
            punkty[1] = new Wierzcholek();
            blackPen.Width = 8;
            greenPen.Width = 8;
            bluePen.Width = 8;
        }

        public int Odleglosc(Wierzcholek poczatek, Wierzcholek koniec) // int odl = Odleglosc(wierzcholki[z], wierzcholki[i]);
        {
            float dx = Math.Abs(koniec.x - poczatek.x);
            float dy = Math.Abs(koniec.y - poczatek.y);
            int r = (int)Math.Sqrt(dx * dx + dy * dy);
            return r;
        }

        void kropka(int x, int y)
        {
            mapa.SetPixel(x - 1, y - 1, Color.Red);
            mapa.SetPixel(x, y - 1, Color.Red);
            mapa.SetPixel(x + 1, y - 1, Color.Red);
            mapa.SetPixel(x - 1, y, Color.Red);
            mapa.SetPixel(x + 1, y, Color.Red);
            mapa.SetPixel(x - 1, y + 1, Color.Red);
            mapa.SetPixel(x, y + 1, Color.Red);
            mapa.SetPixel(x + 1, y + 1, Color.Red);
            mapa.SetPixel(x - 2, y - 2, Color.Red);
            mapa.SetPixel(x - 1, y - 2, Color.Red);
            mapa.SetPixel(x, y - 2, Color.Red);
            mapa.SetPixel(x + 1, y - 2, Color.Red);
            mapa.SetPixel(x + 2, y - 2, Color.Red);
            mapa.SetPixel(x - 2, y - 1, Color.Red);
            mapa.SetPixel(x + 2, y - 1, Color.Red);
            mapa.SetPixel(x - 2, y, Color.Red);
            mapa.SetPixel(x + 2, y, Color.Red);
            mapa.SetPixel(x - 2, y + 1, Color.Red);
            mapa.SetPixel(x + 2, y + 1, Color.Red);
            mapa.SetPixel(x - 2, y + 2, Color.Red);
            mapa.SetPixel(x - 1, y + 2, Color.Red);
            mapa.SetPixel(x, y + 2, Color.Red);
            mapa.SetPixel(x + 1, y + 2, Color.Red);
            mapa.SetPixel(x + 2, y + 2, Color.Red);
            mapa.SetPixel(x, y, Color.Red);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grafButton.Enabled = true;
            sciezkaButton.Enabled = true;
            wierzcholkiButton.Enabled = true;
            pictureBox1.Image = mapaOrginal;
            mapa = new Bitmap(@"..\..\mapa.png");
            punkty[0] = new Wierzcholek();
            punkty[1] = new Wierzcholek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cel = listBox1.SelectedItem.ToString();
                start = listBox2.SelectedItem.ToString();
            }
            catch { }
        }

        private void AlgorytmAGwiazdka(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            Button btn = (Button)sender;

            if (btn == null)
                return;

            int hBoost;
            int refreshTime;

            //sprawdź który guzik został nacisnięty
            if (btn.Name == "fastA")
            {
                hBoost = 100;
                refreshTime = 75;
            }
            else if (btn.Name == "mediumA")
            {
                hBoost = 5;
                refreshTime = 100;
            }
            else
            {
                hBoost = 1;
                refreshTime = 450;
            }

            /*
            Point tokyo = new Point(1584, 347);
            Point london = new Point(926, 255); - Sydney - 1584, 729 NY - 1859, 1079 GD 1012, 236
            */
            Point tokyo = new Point();
            Point london = new Point();

                switch (cel)
                {
                    case "Londyn":
                        london.X = wspolrzedne[0];
                        london.Y = wspolrzedne[1];
                        break;
                    case "Sydney":
                        london.X = wspolrzedne[2];
                        london.Y = wspolrzedne[3];
                        break;
                    case "NY":
                        london.X = wspolrzedne[4];
                        london.Y = wspolrzedne[5];
                        break;
                    case "Gdansk":
                        london.X = wspolrzedne[6];
                        london.Y = wspolrzedne[7];
                        break;
                    case "Tokyo":
                        london.X = wspolrzedne[8];
                        london.Y = wspolrzedne[9];
                        break;
                    default:
                        london.X = wspolrzedne[0];
                        london.Y = wspolrzedne[1];
                        break;
                }

            switch (start)
            {
                case "Londyn":
                    tokyo.X = wspolrzedne[0];
                    tokyo.Y = wspolrzedne[1];
                    break;
                case "Sydney":
                    tokyo.X = wspolrzedne[2];
                    tokyo.Y = wspolrzedne[3];
                    break;
                case "NY":
                    tokyo.X = wspolrzedne[4];
                    tokyo.Y = wspolrzedne[5];
                    break;
                case "Gdansk":
                    tokyo.X = wspolrzedne[6];
                    tokyo.Y = wspolrzedne[7];
                    break;
                case "Tokyo":
                    tokyo.X = wspolrzedne[8];
                    tokyo.Y = wspolrzedne[9];
                    break;
                default:
                    tokyo.X = wspolrzedne[8];
                    tokyo.Y = wspolrzedne[9];
                    break;
            }







            Bitmap mapa = new Bitmap(@"..\..\mapaAlt.png");

            int brushThickness = 15;

            using (Graphics graphics = Graphics.FromImage(mapa))
            {
                Brush brush = new SolidBrush(Color.Crimson);

                graphics.FillEllipse(brush, tokyo.X - brushThickness / 2, tokyo.Y - brushThickness / 2, brushThickness, brushThickness);
                graphics.FillEllipse(brush, london.X - brushThickness / 2, london.Y - brushThickness / 2, brushThickness, brushThickness);

            }

            pictureBox1.Image = mapa;
            pictureBox1.Refresh();



            AStarAlgorithm aStar = new AStarAlgorithm(mapa, tokyo, london, ref pictureBox1, hBoost, refreshTime);
            //aStar.FindRouteList();            //opcja na listach
            aStar.FindRouteDictionary();        //opcja na słownikach

            using (Graphics graphics = Graphics.FromImage(mapa))
            {
                Brush brush = new SolidBrush(Color.Crimson);

                graphics.FillEllipse(brush, tokyo.X - brushThickness / 2, tokyo.Y - brushThickness / 2, brushThickness, brushThickness);
                graphics.FillEllipse(brush, london.X - brushThickness / 2, london.Y - brushThickness / 2, brushThickness, brushThickness);
                pictureBox1.Refresh();

            }
            sw.Stop();
           // czasLabel.Text = sw.Elapsed.Milliseconds.ToString() + " ms";

        }

        
    }
}
