using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    class Game
    {
        // The states of the game
        private Board board; // Decouple this class by creating an interface for Board
        private String playsAgain;
        private int counter;

        // TODO: Create getter & setter for the fields

        // The constructor of Game.
        // It will need a Board object as an argument, then store it as a field
        public Game(Board board) {
            this.board = board;
            this.playsAgain = "Y";
            this.counter = 0;
        }

        public void askData(String player)
        {
            Console.Clear();

            Console.WriteLine("Player: " + player); // X / O
            int selection;

            while (true)
            {
                Console.WriteLine("Please enter your selection.");
                Console.WriteLine("Counter: " + counter);
                board.drawBoard();
                selection = Convert.ToInt32(Console.ReadLine()); // input from the user, the index of board
                // [0, ..., 8]
                if (selection < 0 || selection > 9 || (board.CurrentBoard[selection].Equals("X") || board.CurrentBoard[selection].Equals("O")))
                    Console.WriteLine("Invalid selection!");
                else
                    break;
            }
            board.CurrentBoard[selection] = player;
            counter++;
        }


        // TODO: Move some methods from TicTacToe.cs to here
    }
}
