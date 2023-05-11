using Microsoft.VisualStudio.TestTools.UnitTesting;
using cli_life;
using System;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            LifeGame life = new LifeGame();
            var cells = life.Run("example.txt", "user_settings.json");
            Assert.AreEqual(cells.Iters, 71);
        }

        [TestMethod]
        public void Test2()
        {
            LifeGame life = new LifeGame();
            var cells = life.Run("example3.txt", "user_settings.json");
            Assert.AreEqual(cells.aliveCells, 6);
        }

        [TestMethod]
        public void Test3()
        {
            Board board = new Board(50, 20, 1, 0.5);
            board.GetCellsFromFile("box.txt");
            Assert.AreEqual(board.BoxesAmount(), 2);
        }

        [TestMethod]
        public void Test4()
        {
            Board board = new Board(50, 20, 1, 0.5);
            board.GetCellsFromFile("block.txt");
            Assert.AreEqual(board.BlocksAmount(), 3);
        }

        [TestMethod]
        public void Test5()
        {
            Board board = new Board(50, 20, 1, 0.5);
            board.GetCellsFromFile("hive.txt");
            Assert.AreEqual(board.HivesAmount(), 1);
        }
    }
}
