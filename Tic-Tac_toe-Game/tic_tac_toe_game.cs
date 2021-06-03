using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_toe_Game
{
    class tic_tac_toe_game
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
            for (int StartingIndex = 0; StartingIndex < board.Length; StartingIndex++)
                Console.WriteLine(board[StartingIndex] = '|');
        }
    }
}