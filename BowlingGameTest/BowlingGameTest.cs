using System;
using System.Collections;
using CSC200_BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void AllGutterGameScoreShouldBeZero()
        {
            Game game = new Game();
          
            RollsMany(game, 20, 0);
                                  
            Assert.AreEqual(0, game.Score());
        }

        private void RollMany(Game game, int rolls, int pins)
        {
            for (int roll = 0; roll < rolls ; roll++)
            {
                game.Roll(pins);
            }
        }


        [TestMethod]
        public void AllOnesGameShouldScoreTwenty()
        {
            Game game = new Game();

            RollMany(game, 20, 1);
            
            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void SpareShouldGetNextRollBonus()
        {
            Game game = new Game();
            game.Roll(2);
            game.Roll(8);
            game.Roll(6);
            RollsMany(game, 18, 0);
            Assert.AreEqual(22, game.Score());
        }


        [TestMethod]
        public void PerfectGameShouldGetPerfectScore()
        {
            Game game = new Game();
            RollMany(game, 12, 10);
            Assert.AreEqual(300, game.Score());

        }


        [TestMethod]
        public void StrikeShouldGetTwoRollBonus()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(2);
            game.Roll(7);


            RollsMany(game, 14, 0);
            Assert.AreEqual(28, game.Score());
        }
        private void RollsMany(Game game, int rolls, int pins)
        {
            for(int index = 0; index < rolls; index++)
            {
                game.Roll(pins);
            }
        }


        
    }
}
