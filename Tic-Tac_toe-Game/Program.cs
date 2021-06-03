using System;

namespace Tic_Tac_toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            tic_tac_toe_game tttgame = new tic_tac_toe_game();
            tttgame.CreateBoard();
            tttgame.GameInput();
            char[] board = tttgame.CreateBoard();
            board = tttgame.getUserMove(board);
            tttgame.ShowBoard(board)
            Console.ReadKey();
        }
    }
}
