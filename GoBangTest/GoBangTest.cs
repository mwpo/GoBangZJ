using System.Drawing;
using ConsoleApplication1;
using GoBang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{
    [TestClass]
    public class GoBangTest
    {
        private readonly Board _sut = new Board(BoardSize);
        private readonly Point _point_1_2 = new Point(1, 2);

        private const int BoardSize = 8;

        [TestMethod]
        public void Given_Place_Piece_At_1_2_Should_Be_Successful()
        {
            var expectedResults = PopulateExpectedBoardStatus(BoardSize, _point_1_2);

            _sut.PlacePiece(_point_1_2);

            Assert.IsTrue(expectedResults.TwoDimArrayEqual(expectedResults, _sut.BoardStatus));
        }

        [TestMethod]
        public void Initial_Board_Status_Should_Be_Empty()
        {
            var expectedResults = PopulateExpectedBoardStatus(BoardSize);

            Assert.IsTrue(expectedResults.TwoDimArrayEqual(expectedResults, _sut.BoardStatus));
        }

        [TestMethod]
        [ExpectedException(typeof (BoardSquareOccupiedException))]
        public void Given_Place_Two_Pieces_On_the_Same_Place_Should_Throw_Exception()
        {
            _sut.PlacePiece(_point_1_2);
            _sut.PlacePiece(_point_1_2);
        }

        private int[,] PopulateExpectedBoardStatus(int boardSize, params Point[] points)
        {
            var boardStatus = new int[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardStatus[i, j] = 0;
                }
            }
            foreach (var point in points)
            {
                boardStatus[point.X, point.Y] = 1;
            }
            return boardStatus;
        }
    }
}
