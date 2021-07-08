using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        /// <summary>
        ///------>Wellcome<-----
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] board = TicTacToeGame.CreatingBoard();
            Console.Read();
        }
    }
}
