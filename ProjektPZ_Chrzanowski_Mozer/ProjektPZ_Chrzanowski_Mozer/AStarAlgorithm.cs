using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Przeszukiwanie_grafu
{
    class AStarAlgorithm
    {
        private class Node : IComparable
        {
            public long id; //numer węzła
            public Point point;   //koordynacje x, y

            public long f;  //g+h
            public long g; //koszt od punktu startowego
            public long h; //szacowany koszt od punktu koncowego  

            public bool obstructionNode; // czy jest przeszkodą - lądem

            public Node parent;    //węzeł rodzic

            public Node(Point point)
            {
                this.point = point;
            }

            public int GetLengthTo(Node node)
            {
                float x = Math.Abs(point.X - node.point.X);
                float y = Math.Abs(point.Y - node.point.Y);

                return (int)Math.Sqrt(x * x + y * y) * crossCost;
            }

            enum Direction
            {
                NW,
                N,
                NE,
                E,
                SE,
                S,
                SW,
                W
            }

            Bitmap bitmap;

            Point source;
            Point destination;

            Node sourceNode;
            Node destinationNode;

            int MAP_HEIGHT;
            int MAP_WIDTH;

            const int crossCost = 10;       //koszt drogi N E S W 
            const int diagonalCost = 14;    //koszt drogi NE NW SE SW

            int refreshTime; 

        }
    }
}
