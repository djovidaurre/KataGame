using System;
using System.Collections.Generic;
using KataGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKataGame
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void KeepaLiveCaseTwoCellLives()
        {
            Game game = new Game(5, 5);

            game.Init(new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(2, 2),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(4, 3),
                new KeyValuePair<int, int>(3, 4)
            });

            bool expected = true;

            game.Play();

            bool? result = game.Dashboard[4,3];

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void KeepaLiveCaseThreeCellLives()
        {
            Game game = new Game(5, 5);

            game.Init(new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(2, 2),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(4, 3),
                new KeyValuePair<int, int>(3, 4)
            });

            bool expected = true;

            game.Play();

            bool? result = game.Dashboard[3, 3];

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeadOverpopulationfourCellLives()
        {
            Game game = new Game(5, 5);

            game.Init(new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(2, 2),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(4, 3),
                new KeyValuePair<int, int>(3, 4),
                new KeyValuePair<int, int>(4, 2)
            });

            bool expected = false;

            game.Play();

            bool? result = game.Dashboard[3, 3];

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ReviveCellDeadTreeCellLive()
        {
            Game game = new Game(5, 5);

            game.Init(new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(2, 2),
                new KeyValuePair<int, int>(3, 3),
                new KeyValuePair<int, int>(4, 3),
                new KeyValuePair<int, int>(3, 4),
                new KeyValuePair<int, int>(4, 2)
            });

            bool expected = true;

            game.Play();

            bool? result = game.Dashboard[2, 3];

            Assert.AreEqual(expected, result);
        }


    }
}
