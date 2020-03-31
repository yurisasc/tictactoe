using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    class TicTacToe
    {
        // OOP Encapsulation
        private String[] board = new String[9];
        private String playsAgain = "Y";
        private int counter = 0;

        // Getters & setters for the instance variables
        public string PlaysAgain { get => playsAgain; set => playsAgain = value; }
        public string[] Board { get => board; set => board = value; }
        public int Counter { get => counter; set => counter = value; }


        // Constructor
        public TicTacToe()
        {
            // initialize the board 
            initializeVariable();
        }

        private void initializeVariable()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString();
            }
        }

        public void playAgainMsg(String message)
        {
            Console.WriteLine(message + "Do you want to play again?");
            if (Console.ReadLine().Equals("Y"))
            {
                reset();
                playsAgain = "Y";
            }
            else
            {
                playsAgain = "N";
            }
        }

        // Should be in the Game class
        public void askData(String player)
        {
            Console.Clear();

            Console.WriteLine("Player: " + player); // X / O
            int selection;

            while (true)
            {
                Console.WriteLine("Please enter your selection.");
                Console.WriteLine("Counter: " + counter);
                drawBoard();
                selection = Convert.ToInt32(Console.ReadLine()); // input from the user, the index of board
                // [0, ..., 8]
                if (selection < 0 || selection > 9 || (board[selection].Equals("X") || board[selection].Equals("O")))
                    Console.WriteLine("Invalid selection!");
                else
                    break;
            }
            board[selection] = player;
            counter++;
        }

        // Should be in the Board class
        private void drawBoard()
        {
            for (int i = 0; i < 7; i += 3) //Draw the board.
                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);
        }

        public Boolean hasWon()
        {
            for (int i = 0; i < 7; i += 3)
            {
                if (board[i].Equals(board[i + 1]) && board[i + 1].Equals(board[i + 2]))
                {
                    return true;
                }
            }
            if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
                return true;
            if (board[1].Equals(board[4]) && board[4].Equals(board[7]))
                return true;
            if (board[2].Equals(board[5]) && board[3].Equals(board[8]))
                return true;
            if (board[2].Equals(board[4]) && board[4].Equals(board[6]))
                return true;
            if (board[0].Equals(board[4]) && board[4].Equals(board[8]))
                return true;
            return false;
        }

        private void reset()
        {
            // clear the board
            initializeVariable();
            // counter = 0
            counter = 0;
        }
    }
}
