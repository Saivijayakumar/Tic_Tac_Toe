using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToeGame
    {

        public static char[] CreatingBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public static void Choose()
        {
            string computerChoice;
            Console.WriteLine("Enter your choice X or O");
            string user = Console.ReadLine();
            if (user.ToUpper().Equals("X") || user.ToUpper().Equals("O"))
            {
                switch (user.ToUpper())
                {
                    case "X":
                        computerChoice = "O";
                        break;
                    default:
                        computerChoice = "X";
                        break;
                }
                Console.WriteLine(computerChoice);
            }
            else
            {
                Console.WriteLine("Wrong choice please Enter X or O ");
            }
        }

        public static char[] DisplayBoard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("------------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("------------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
            return board;
        }
    }
}
