using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    class point
        {
            int x, y;
            public int X
            {
                get{return x;}
                set{x = value;}
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            #region
            public point() { x = 0; y = 0; }
            public point(int a, int b) { this.x = a; this.y = b; }
            #endregion
        }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            point temp;
            point[] p= new point[100];

            p[0] = new point(0, 0);
            p[1] = new point(1, 0);
            p[2] = new point(2, 5);
            p[3] = new point(5, 7);
            p[4] = new point(8, 3);
            p[5] = new point(9, 10);
            p[6] = new point(6, 3);
            p[7] = new point(10, 10);
            p[8] = new point(11, 7);

            //It is like scanning a page. Hence it goes left to right and top to bottom simultaneously. 
            //Therefore, we start scanning at the top left corner which is (0, n) and 
            //end at bottom right corner which is (m, 0) ; m and n being the largest in their axis.

            //We traverse top to bottom only once. But we traverse left to right sequentially.
            //Sorting using Binary Sort
            // y -> decending. If 2 or more points have same y, then sort only those respective x in ascending order.
            for (j = 0; j < 9; j++)
            {
                for (i = 0; i < 8; i++)
                {
                    if (p[i].Y < p[i + 1].Y)
                    {
                        temp = p[i];
                        p[i] = p[i + 1];
                        p[i + 1] = temp;
                    }
                }
            }

            //Now that it is sorted decending with Y axis - to fix top to bottom approach
            //Left to right is traversed from least to the largest by sorting ascending

            for(j=0;j<9;j++)
            {
                for(i=0;i<8;i++)
                {
                    if(p[i].Y==p[i+1].Y)
                    {
                        if(p[i].X > p[i+1].X)
                        {
                            temp = p[i];
                            p[i] = p[i + 1];
                            p[i + 1] = temp;
                        }
                    }
                }
            
            }
            Console.WriteLine("Scanning a Hard Coded 2D graph sheet");
            for(i=0;i<9;i++)
            {
                Console.WriteLine("(" + p[i].X + "," + p[i].Y + ")");
            }

            Console.Read();
    


        }
    }
}
