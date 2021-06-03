using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_toe_Game
{
    class tic_tac_toe_game
    {
        public void CreateBoard()
           
            public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int StartingIndex = 0; StartingIndex < board.Length; StartingIndex++)
                Console.WriteLine(board[StartingIndex] = '|');
            board[StartingIndex] = ' ';
           
            return board;
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
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }

    }
}