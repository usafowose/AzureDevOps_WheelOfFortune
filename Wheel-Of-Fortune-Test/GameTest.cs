
using Wheel_Of_Fortune_MVP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Wheel_Of_Fortune_Test
{
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void GameConstructor_CreatesInstanceOfGame_Game()
        {
            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);
            Assert.AreEqual(typeof(Game), game.GetType());
        }

        [TestMethod]
        public void StartGame_InitializeTargetWordAndDashesWordFromArrayOfWordsAtIndex2_Void()
        {
            // Arrange
            Mock<RandomGenerator> randomTest = new Mock<RandomGenerator>(MockBehavior.Strict);
            randomTest.Setup(h => h.GetNumber(It.Is<int>(t => t == 6)))
              .Returns(2);
            Game game = new Game(randomTest.Object);

            // Act
            game.StartGame();

            //Assert
            Assert.AreEqual("polymorphism", game.TargetWord);
            Assert.AreEqual("------------", game.DisplayWord);

            randomTest.VerifyAll();
        }

        [TestMethod]
        public void CheckCharIndex_IndicesOfLetterAinBanana_ListOfIntegers()
        {
            List<int> test = new List<int> { 1, 3, 5 };

            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);
            game.TargetWord = "banana";
            List<int> result = game.CheckCharIndex('a');

            Assert.AreEqual(test[0], result[0]);
            Assert.AreEqual(test[1], result[1]);
            Assert.AreEqual(test[2], result[2]);
            Assert.AreEqual(test.Count, result.Count);
        }

        [TestMethod]
        public void CheckCharIndex_NoLetterEinBananaCaseSensitive_EmptyListOfIntegers()
        {
            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);
            game.TargetWord = "banana";
            List<int> result = game.CheckCharIndex('E');

            //Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ReplaceDash_ReplaceDashesByLetterO()
        {
            string test = "-o--o----o-";

            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);
            game.TargetWord = "composition";
            game.DisplayWord = "-----------";
            List<int> listOfIndices = game.CheckCharIndex('o');
            game.ReplaceDash(listOfIndices, 'o');

            Assert.AreEqual(test, game.DisplayWord);
        }

        [TestMethod]
        public void HasWon_IndicateWinningIfGuessedWordCorrect_True()
        {
            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);
            game.TargetWord = "banana";

            Assert.AreEqual(true, game.HasWon("banana"));
        }

        [TestMethod]
        public void ReplaceDash_ReplaceDashesByNonExistentLetterW()
        {
            string test = "-------------";
            Mock<RandomGenerator> randomTest = new Mock<RandomGenerator>(MockBehavior.Strict);
            randomTest.Setup(j => j.GetNumber(It.Is<int>(t => t == 6))).Returns(0);

            Game game = new Game(randomTest.Object);
            game.StartGame();
            List<int> listofIndices = game.CheckCharIndex('W');
            game.ReplaceDash(listofIndices, 'W');
            Assert.AreEqual(test, game.DisplayWord);
        }
    }
}
