using MineSweeper;
using NUnit.Framework;

namespace MineSweeperTest
{
    public class MineTest
    {
        private Mine mine;
        [SetUp]
        public void Setup()
        {
            mine = new Mine();
        }

        [Test]
        public void Give_GameBoardWithMines_When_FindMines_Should_Return_GameBoardWithNumbersAndMines()
        {
            var inputArray = new[] { new string [] { "*", ".", ".", "." },
                                     new string [] { ".", ".", ".", "." },
                                     new string [] { ".", "*", ".", "." },
                                     new string [] { ".", ".", ".", "." }};

            var expected = new[] { new string [] { "*", "1", "0", "0" },
                                   new string [] { "2", "2", "1", "0" },
                                   new string [] { "1", "*", "1", "0" },
                                   new string [] { "1", "1", "1", "0" }};

            var actual = mine.FindMine(inputArray);

            Assert.AreEqual(expected, actual);
        }
    }
}
