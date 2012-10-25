using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Board
    {
        public string BoardStatus
        {
            get { return _boardStatus; }
        }

        private char[,] _cells;
        private string _boardStatus = string.Empty;

        public Board(int boardSize)
        {
            _cells = new char[boardSize,boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    _cells[i,j] ='*';
                    _boardStatus += "*";
                }
                _boardStatus += "\n";
            }
        }


    }
}