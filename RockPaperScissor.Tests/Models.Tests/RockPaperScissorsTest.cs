using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissor;
using System;

namespace RockPaperScissors.TestTools
{
    [TestClass]
    public class RPSTests
    {
        // Test One
        [TestMethod]
        public void Constructor_CreatesObject_Object()
        {
            Game newGame = new Game("Rock", "Paper", "Scissor", "ROCK", "scissors", true , 1);
            Assert.AreEqual(typeof(Game), newGame.GetType());
        }
        // Test Two
        [TestMethod]
        public void Constructor_ReturnsPaper_Paper()
        {
            Game newGame = new Game("rock", "paper", "scissors", "ROCK", "scissors", true, 1 );
            Assert.AreEqual("paper", newGame.GetPaper());
        }

        //Test Three
        [TestMethod]
        public void Constructor_ReturnsRock_Rock()
        {
            Game newGame = new Game("rock" , "paper", "scissors", "rock", "paper", true, 1);
            Assert.AreEqual("rock", newGame.GetRock());
        }
        // Test Four
         [TestMethod]
        public void Constructor_ReturnsScissors_Scissors()
        {
            Game newGame = new Game("rock" , "paper", "scissors", "ROCK", "scissors", true, 1);
            Assert.AreEqual("scissors", newGame.GetScissors());
        }
        //Test Five
         [TestMethod]
        public void Logic_GameLogic_GameWorks()
        {
            Game newGame = new Game("rock" , "paper", "scissors", "ROCK", "scissors", true, 1);
            
            Assert.AreEqual("Player One Wins", newGame.RunGame());
        }

        //Test Six
         [TestMethod]
        public void Logic_GameLogic2_GameWorks()
        {
            Game newGame = new Game("rock" , "paper", "scissors", "Scissors", "Rock", true, 1);
            
            Assert.AreEqual("Player Two Wins", newGame.RunGame());
        }
        //Test Seven
        [TestMethod]
        public void Logic_GameLogic3_GameWorks()
        {
            Game newGame = new Game("rock" , "paper", "scissors", "Scissors", "Scissors", true, 1);
            
            Assert.AreEqual("Draw", newGame.RunGame());
        }

       
    }
}