using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{
    [TestClass]
    public class GoBangTest
    {
        [TestMethod]
        public void PrintEmptyChessBoard()
        {
            Board chessBoard = new Board(8) ;
            string expected = "********\n********\n********\n********\n********\n********\n********\n********\n";  

            Assert.AreEqual(expected,chessBoard.BoardStatus);
        }

        [TestMethod]
        public void PrintChessBoard_Given_Place_ON_1_2()
        {
            Board chessBoard = new Board(8);
            Point p = new Point(1,2);
            chessBoard.PlacePiece(p);
            string expected = "********\n**X*****\n********\n********\n********\n********\n********\n********\n";

            Assert.AreEqual(expected, chessBoard.BoardStatus);
        }
    }
}
