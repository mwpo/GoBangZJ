using System.Collections.Generic;
using System.Drawing;
using ConsoleApplication1;

namespace GoBang
{
    public class Board
    {
        public int[,] BoardStatus
        {
            get { return _cells; }
        }


        private int[,] _cells;
        private int _boardSize;

        public Board(int boardSize)
        {
            _boardSize = boardSize;
            _cells = CreateAndInitBoardStatus(_boardSize);
        }

        public static int[,] CreateAndInitBoardStatus(int boardSize)
        {
            var boardStatus = new int[boardSize,boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardStatus[i, j] = 0;
                }
            }
            return boardStatus;
        }

        public void PlacePiece(Point point)
        {
            if (_cells[point.X, point.Y] != 0)
                throw new BoardSquareOccupiedException();
            _cells[point.X, point.Y] = 1;
        }
    }
}