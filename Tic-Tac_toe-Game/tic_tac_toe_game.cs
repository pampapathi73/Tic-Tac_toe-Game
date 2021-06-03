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
        public char[] getUserMove(char[] board)
        {
            
            Console.WriteLine("Select The Location On Board:  ");
            
            int ExactLocation = Convert.ToInt32(Console.ReadLine());
            
            while (ExactLocation > 9 || ExactLocation < 1)
            {
               
                Console.WriteLine("Invalid exactLocation, select the location on Board b/w 1 to 9 :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine()); // ip
                ExactLocation = checkBoard(ExactLocation, board); // 1 to 9 
            }
          
            if (ExactLocation == 0)
            {
                
                Console.WriteLine("location already selected");
                Console.WriteLine("Please Select another location on Tic Tac Toc Board :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine());
            }
           
            else
                
                board[ExactLocation] = '0';
            return board;
        }

       
        public int checkBoard(int ExactLocation, char[] board)
        {
            if (board[ExactLocation] != ' ')
                return 0;
            else
                return ExactLocation;
        }
        public char[] UserMove(char[] board)
        {
            //Select location in Your Board Where you want your 0
            Console.WriteLine("Select The Location On Board:  ");
            //Store in Int Variable
            Console.WriteLine("select the location on Board :  ");
            int ExactLocation = Convert.ToInt32(Console.ReadLine());
            //validating user location
            //while loop check if ExactLocation is (less than)9 And  ExactLoaction is (greater) than 1
            while (ExactLocation > 9 || ExactLocation < 1)
            {
                // if other than this it will give an error
                Console.WriteLine("Invalid exactLocation, select the location on Board b/w 1 to 9 :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine()); // ip
                ExactLocation = checkBoard(ExactLocation, board); // 1 to 9 
                Console.WriteLine("invalid location, select the location on Board :  ");
                ExactLocation = Convert.ToInt32(Console.ReadLine());
            }
            //loop for checking Empty Space
            //loop to check for empty space
            bool emptySpace = false;
            while (true)
            {
                //if 0 == 0
                //checking for free space
                ExactLocation = CheckBoard(ExactLocation, board);
                if (ExactLocation == 0)
                {
                    //error Location Already Selected
                    Console.WriteLine("location already selected");
                    Console.WriteLine("Please Select another location on Board :  ");
                    Console.WriteLine("The Location Already Selected . Select Another Location on the  Board : ");
                    ExactLocation = Convert.ToInt32(Console.ReadLine());
                    //loop to check for empty space
                    emptySpace = true;
                }
                else
                    board[ExactLocation] = 'x';
                return board;

                {
                    //else ExactLocation = '0'
                    board[ExactLocation] = '0';
                    break;
                }
            }
            return board;
        }
        //checking if board is empty
        public int checkBoard(int ExactLocation, char[] board)
        //check the borad is empty or not
        public int CheckBoard(int ExactLocation, char[] board)
        {
            if (board[ExactLocation] != ' ')
                return 0;
            return 0;
            else
                return ExactLocation;
            return ExactLocation;
        }

    }
}