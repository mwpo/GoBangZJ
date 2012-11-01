using System.Drawing;
using GoBang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{
    [TestClass]
    public class GoBangTest
    {
        [TestMethod]
        public void PrintChessBoard_Given_Place_ON_1_2()
        {
            int boardSize = 8;
            var expectedResults = Board.CreateAndInitBoardStatus(boardSize);
            expectedResults[1, 2] = 1;
            Board chessBoard = new Board(boardSize);
            Point p = new Point(1, 2);
            chessBoard.PlacePiece(p);
            Assert.IsTrue(expectedResults.TwoDimArrayEqual(expectedResults, chessBoard.BoardStatus));
        }

        [TestMethod]
        public void PrintEmptyChessBoard()
        {
            int boardSize = 8;
           var expectedResults = Board.CreateAndInitBoardStatus(boardSize);
            Board chessBoard = new Board(boardSize);
            Assert.IsTrue(expectedResults.TwoDimArrayEqual(expectedResults, chessBoard.BoardStatus));
        }
    }

    static class Extension
    {
            public static bool TwoDimArrayEqual(this int[,] X, int[,] a, int[,] b)
            {
                if (a.Rank != b.Rank || a.Rank != 2)
                    return false;

                for (int i = 0; i < a.Rank; i++)
                    if (a.GetLength(i) != b.GetLength(i))
                        return false;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for(int j = 0; j<a.GetLength(1); j++ )
                    {
                        if (a[i, j] != b[i, j])
                            return false;
                    }
                }
                return true;
            }
    }
}
