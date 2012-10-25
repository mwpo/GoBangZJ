using System;
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
            Board chessBoard = new Board() ;
            string expected = "********\n********\n********\n********\n********\n********\n********\n********\n";  

            Assert.AreEqual(expected,chessBoard.boardStatus);
        }
    }
}
