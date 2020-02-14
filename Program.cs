﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dto1d
{
    class twodmatrix
    {
        int m, n;
        int[,] a;
        int[] b;
        twodmatrix(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * n];
        }
        public void readmatrix()
        {
            for(int i = 0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void printd()
        {
            for (int i = 0; i<m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.Write("\n");
            }
            
        }
        public void convert()
        {
            int k = 0;
            for (int i =0; i <m; i ++)
            {
                for (int j = 0; j<n; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }
        public void printoned()
        {
            for (int i = 0; i< m* n; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
        }
        static void Main(string[] args)
        {
            twodmatrix obj = new twodmatrix(2, 3);
            Console.WriteLine("Enter the Elements : ");
            obj.readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.printd();
            obj.convert();
            Console.WriteLine("\t\t converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }
    }
}
