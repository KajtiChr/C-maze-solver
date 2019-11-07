using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        Pen blackPen = new Pen(Color.Black, 3);
        Pen bluePen = new Pen(Color.Pink, 3);
        Pen greenPen = new Pen(Color.Green, 1);
        Pen blue2Pen = new Pen(Color.Blue, 3);
        int rozmiar = 0;

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
            blackPen.Width = 8;
            greenPen.Width = 8;
            bluePen.Width = 8;
        }

       
    }
}
