using System;

namespace RockPaperScissor
{

    public class Game
    {
        private string _playerOne {get; set;}
        private string _playerTwo {get; set;}
    
        public Game(string playerOne, string playerTwo)
        {

             _playerOne = playerOne;
             _playerTwo = playerTwo;
        }

        public string GetPlayerOne()
        {
            return _playerOne;
        }
        public string GetPlayerTwo()
        {
            return _playerTwo;
        }

        public string RunGame()
        {
           return GameLogic();
           
        }

        
        private string GameLogic()
        {
                if (_playerOne.ToLower() == "rock" && _playerTwo.ToLower() =="scissors")
                {
                    return "Player One Wins";
                }else if (_playerOne.ToLower() == "rock" && _playerTwo.ToLower() == "paper")
                {
                    return "Player Two Wins";
                } else if (_playerOne.ToLower() == "rock" && _playerTwo.ToLower() == "rock")
                {
                    return "Draw";
                } else if (_playerOne.ToLower()== "paper" && _playerTwo.ToLower()== "rock")
                {
                return "Player One Wins";
                } else if (_playerOne.ToLower() == "paper" && _playerTwo.ToLower() == "scissors")
                {
                    return "Player Two Wins";
                } else if (_playerOne.ToLower() == "paper" && _playerTwo.ToLower() == "paper")
                {
                    return "Draw";
                } else if (_playerOne.ToLower()== "scissors" && _playerTwo.ToLower()== "rock")
                {
                    return "Player Two Wins";
                } else if (_playerOne.ToLower() == "scissors" && _playerTwo.ToLower() == "paper")
                {
                    return "Player One Wins";
                } else if (_playerOne.ToLower() == "scissors" && _playerTwo.ToLower() == "scissors")
                {
                    return "Draw";
                }else
                {
                    return "Please Enter: Rock, Paper or Scissors";
                }
        }
    }
}