using System.Collections.Generic;
using System.Drawing;
using ConsoleApplication1;

namespace GoBang
{
    public class Board
    {
        private readonly int[,] _cells;
        private Matrix<int> _matrix;

        public Board(int boardSize)
        {
            _cells = new int[boardSize,boardSize];
            _matrix = new Matrix<int>(boardSize);
        }

        public void PlacePiece(Point point)
        {
            if (_matrix[point] != 0)
                throw new BoardSquareOccupiedException();
            _matrix[point] = 1;
        }

        internal int[,] BoardStatus
        {
            get { return _matrix.ToArray(); }
        }
    }
}