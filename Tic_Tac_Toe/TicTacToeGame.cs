using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToeGame
    {
       
        public static char[]  CreatingBoard()
        {
            char[] board = new char[10];
            for(int i=0;i<board.Length;i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        
    }
}
