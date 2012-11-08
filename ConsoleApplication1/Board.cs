using System.Collections.Generic;
using System.Drawing;
using ConsoleApplication1;

namespace GoBang
{
    public class Board
    {
        private readonly int[,] _cells;

        public Board(int boardSize)
        {
            _cells = new int[boardSize,boardSize];
        }

        public void PlacePiece(Point point)
        {
            if (_cells[point.X, point.Y] != 0)
                throw new BoardSquareOccupiedException();
            _cells[point.X, point.Y] = 1;
        }

        internal int[,] BoardStatus
        {
            get { return _cells; }
        }
    }
}