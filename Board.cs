using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    class Board
    {
        private String[] currentBoard = new String[9];
        
        public string[] CurrentBoard { get => currentBoard; set => currentBoard = value; }

        public Board()
        {
            // initialize board
        }

        // TODO: Move some methods from TicTacToe.cs to here
    }
}
