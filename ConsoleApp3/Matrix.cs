using System;
using System.Threading;

namespace ConsoleApp3
{
    public class Matrix
    {
        public int[] a { private set; get; }
        public int[] b { private set; get; }
        public int[] c { private set; get; }
        public int[] l;
        public int[] j;
        public int[] k;
    
        private static Barrier barrier = new Barrier(3);

        public Matrix(int[] a, int[] b, int[] c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void line1(Matrix x1, Matrix x2)
        {
            int x = x1.a[0] + x2.a[0];
            int y = x1.a[1] + x2.a[1];
            int z = x1.a[2] + x2.a[2];
            int[] a1 = new int[3] { x, y, z };
            l = a1;
        }
        public void line2(Matrix x1, Matrix x2)
        {
            int x = x1.b[0] + x2.b[0];
            int y = x1.b[1] + x2.b[1];
            int z = x1.b[2] + x2.b[2];
            int[] b1 = new int[3] { x, y, z };
            j = b1;
        }
        public void line3(Matrix x1, Matrix x2)
        {
            int x = x1.c[0] + x2.c[0];
            int y = x1.c[1] + x2.c[1];
            int z = x1.c[2] + x2.c[2];
            int[] c1 = new int[3] { x, y, z };
            k = c1;
        }
        public Matrix oursum(Matrix x, Matrix y)
        {
            for (int i = 0; i < barrier.ParticipantCount; i++)
            {
                var thread = new Thread(Matrixadd);
                if(i == 1)
                {
                    x.line1(x, y);
                }
                else if(i == 2)
                {
                    x.line2(x, y);
                }
                else
                {
                    x.line3(x, y);
                }
                thread.Start();
            }
           return x.resultmatrix();
        }
        private static void Matrixadd()
        {
            Console.WriteLine("It is the thread");
            barrier.SignalAndWait();
        }
        public Matrix resultmatrix()
        {
            Matrix result = new Matrix(l, j, k);
            Console.WriteLine(result.a[0]);

            return result;
        }
    }
}
