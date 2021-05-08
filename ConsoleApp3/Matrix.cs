using System;
using System.Threading;

namespace ConsoleApp3
{
    public class Matrix
    {
        private readonly Barrier barrier;
        private readonly int[,] _matrixArray;
        int[,] ud;
        public Matrix a { get; set; }
        public Matrix b { get; set; }
        int l = 0;
        public Matrix( int[,] matrixArray)
        {
            _matrixArray = matrixArray;
            barrier = new Barrier(matrixArray.GetLength(0));
        }

        public int this[int i, int j]
        {
            get { return _matrixArray[i, j]; }
        }

        public Matrix oursum(Matrix x, Matrix y)
        {
            a = x;
            b = y;
            ud = new int[_matrixArray.GetLength(0), _matrixArray.GetLength(1)];
            for (var i = 0; i < _matrixArray.GetLength(0); i++)
            {
                var thread = new Thread(BarrierTread);
                thread.Start();
            }
            var result = new Matrix(ud);
            return result;
        }
        private void BarrierTread()
        {
            Console.WriteLine("It is the thread");
                for (int j = 0; j < _matrixArray.GetLength(1); j++)
                {
                    ud[l, j] = a._matrixArray[l, j] + b._matrixArray[l, j];
                }
            Interlocked.Increment(ref l);
            barrier.SignalAndWait();
        }
    }

}
