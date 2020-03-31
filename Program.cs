using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tictactoe;

namespace Tic_Tac_Toe_V2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Example of Game & Board initialization
            Board board = new Board();
            Game game = new Game(board);

            TicTacToe ticTacToe = new TicTacToe();
            UI.introduction();

            while (ticTacToe.PlaysAgain.Equals("Y"))
            {
                // check if the game is not finished
                while (ticTacToe.hasWon() == false && ticTacToe.Counter < 9)
                {
                    // we want the game to finish when either player puts the counter >= 9 or game.hasWon == true
                    // by finish, we mean by exiting this while loop
                    ticTacToe.askData("X");
                    if (ticTacToe.hasWon() == true || ticTacToe.Counter == 9)
                        break;
                    ticTacToe.askData("O"); // game.hasWon() == true
                }
                // the lines below will be executed when the game is finished
                if (ticTacToe.hasWon() == true)
                {
                    ticTacToe.playAgainMsg("Congratulations! You won!");
                }
                else
                {
                    ticTacToe.playAgainMsg("Sorry, but this was a tie game!");
                }
            }
            UI.goodBye();
        }

    }
}