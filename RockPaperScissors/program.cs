using System;
using RockPaperScissor;
using System.Collections.Generic;

namespace RockGame
{
   
      public class Program 
      {
          
          public static void Main()
          {    
              int turn = 1;
              for(int i = 0; i < turn; i ++)
              {
                Console.WriteLine("Player Ones Turn.");
                string playerOne = Console.ReadLine();
                 Console.WriteLine("Player Twos Turn");
                string playerTwo = Console.ReadLine();
                Game newGame = new Game(playerOne, playerTwo);    
                newGame.GetPlayerOne();
                newGame.GetPlayerTwo();
                Console.WriteLine(newGame.RunGame());
                turn ++;
              }
                
          }
      }
}