using System;
using System.Threading;

namespace ConsoleApp3
{
    public class Matrix
    {
        private readonly Barrier barrier;
        private readonly int[,] _matrixArray;

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
            var ud = new int[_matrixArray.GetLength(0), _matrixArray.GetLength(1)];
            for (var i = 0; i < _matrixArray.GetLength(0); i++)
            {
                var thread = new Thread(BarrierTread);
                for (int j = 0; j < _matrixArray.GetLength(1); j++)
                {
                    ud[i,j] = x._matrixArray[i, j] + y._matrixArray[i,j];
                }
                thread.Start();
            }
            var result = new Matrix(ud);
            return result;
        }
        private void BarrierTread()
        {
            Console.WriteLine("It is the thread");
            barrier.SignalAndWait();
        }
    }
}
