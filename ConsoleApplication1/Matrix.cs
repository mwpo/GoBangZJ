using System.Drawing;

namespace GoBang
{
    internal class Matrix<T>
    {
        private readonly T[,] _elements;

        public Matrix(int size)
        {
            _elements = new T[size, size];
        }

        public T this[Point pt]
        {
            get
            {
                return _elements[pt.X, pt.Y];
            }
            set
            {
                _elements[pt.X, pt.Y] = value;
            }
        }

        public T[,] ToArray()
        {
            return _elements;
        }
    }
}