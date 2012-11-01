using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApplication1
{
    public class Board
    {
        public string BoardStatus
        {
            get { return GetBoardStatus(); }
        }

        private char[,] _cells;
        private int _boardSize;

        public Board(int boardSize)
        {
            _boardSize = boardSize;
            _cells = new char[boardSize,boardSize];
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    _cells[i,j] ='*';
                }
            }                                                                                      
        }

        public void PlacePiece(Point point)
        {
            _cells[point.X, point.Y] = 'X';
        }

        private string GetBoardStatus()
        {
            string boardStatus = string.Empty;
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    boardStatus += _cells[i, j];
                }
                boardStatus += "\n";
            }
            return boardStatus;
        }
    }
}