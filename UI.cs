using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe
{
    static class UI
    {
        public static void introduction()
        {
            Console.Title = ("Tic Tac Toe Version 2");
            Console.WriteLine("Welcome to Tic Tac Toe.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void goodBye()
        {
            Console.WriteLine("Thank you for playing! Thanks YouTube for watching.");
            Console.ReadLine();

        }
    }
}
