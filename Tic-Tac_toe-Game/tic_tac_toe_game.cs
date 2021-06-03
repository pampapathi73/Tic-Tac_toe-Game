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
        public void GameInput()
        {
            Random random = new Random();
            int RandomValue = random.Next(0, 2);
            if (RandomValue == 0)
                
                Console.WriteLine("Player play first. Input Will Be X");
            else
                
                Console.WriteLine("Computer play first.  Input Will Be 0");

        }

    }
}