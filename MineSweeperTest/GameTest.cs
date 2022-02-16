using NUnit.Framework;
using MineSweeper;

namespace MineSweeperTest
{
    public class GameTest
    {
        private Game game;
        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Given_2DArray_When_FindNeigbours_Should_ReturnListOfArrayItems()
        {
            var inputArray = new[] { new string [] { "*", ".", ".", "." },
                                     new string [] { ".", ".", ".", "." },
                                     new string [] { ".", "*", ".", "." },
                                     new string [] { ".", ".", ".", "." }};

            var expected = new[] { new string [] { "*", "1", "0", "0" },
                                   new string [] { "2", "2", "1", "0" },
                                   new string [] { "1", "*", "1", "0" },
                                   new string [] { "1", "1", "1", "0" }};

            var actual = game.FindNeighbours(inputArray);

            Assert.AreEqual(expected, actual);
           
        }
    }
}