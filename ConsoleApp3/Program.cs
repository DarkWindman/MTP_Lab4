using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 0, 7, 1 };
            int[] a2 = new int[] { 2, 0, 1 };
            int[] a3 = new int[] { 3, 4, 1 };
            int[] b1 = new int[] { 3, 4, 1 };
            int[] b2 = new int[] { 0, 5, 1 };
            int[] b3 = new int[] { 6, 6, 6 };
            Matrix a = new Matrix (a1, a2, a3);
            Matrix b = new Matrix(b1, b2, b3);
            a.oursum(a, b);
            Console.ReadKey();
        }
    }
    
}
