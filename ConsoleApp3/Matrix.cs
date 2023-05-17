using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Matrix
    {

        /*   public int y
          {
              get;set;
          }
          public int x
          {
              get; set;
          }*/
        private int x;
        private int y;
        public Matrix(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public Matrix()
        {
            Console.WriteLine("enter the number of rows");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of columns");
             y = Convert.ToInt32(Console.ReadLine());
        }
        public void ReadMatrix() 
        {
            int[,] re = new int[x, y];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    re[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void print()
        {
            Console.WriteLine("the elements is");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine(re[i, j]);
                }
            }

        }

    }
}
