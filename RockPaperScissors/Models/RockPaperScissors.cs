using System;

namespace RockPaperScissor
{

    public class Game
    {
        private string _rock { get; set; }
        private string _paper { get; set; }
        private string _scissors { get; set;}
        private string _playerOne {get; set;}
        private string _playerTwo {get; set;}
        private bool _gameOn {get ; set;}
        private int _turn {get; set;}
        
    
        public Game(string rock, string paper, string scissors, string playerOne, string playerTwo, bool gameOn, int turn)
        {
             _rock = rock;
             _paper = paper;
             _scissors = scissors;
             _playerOne = playerOne;
             _playerTwo = playerTwo;
             _gameOn = gameOn;
             _turn = turn;
        }

        public string GetRock()
        {
            return _rock;
        }
        public string GetPaper()
        {
            return _paper;
        }
        public string GetScissors()
        {
            return _scissors;
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