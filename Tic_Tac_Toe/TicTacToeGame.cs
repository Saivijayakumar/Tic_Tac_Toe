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
        public static string Choose()
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
            }
            else
            {
                Console.WriteLine("Wrong choice please Enter X or O ");
            }
            return user;
        }

        public static void DisplayBoard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("------------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("------------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }

        public static char[] PositionSelect(char[] board)
        {
            while (true)
            {
                string cho = Choose();
                Console.WriteLine("Enter at what position you want to add ");
                int position = Convert.ToInt32(Console.ReadLine());
                if (board[position].Equals(board[0]))
                {
                    board[position] = Convert.ToChar(cho);
                    DisplayBoard(board);
                }
                else
                {
                    Console.WriteLine("This block is taken chose another");
                    break;
                }
            }
            return board;
        }
    }
}
