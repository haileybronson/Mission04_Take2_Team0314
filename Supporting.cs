using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mission4_Take2_Team0314
{
    internal class Supporting
    {
        //Receive the “board” array from the driver class
        //Contain a method that prints the board based on the information passed to it
        public void DrawBoard(char[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        /*Contain a method that receives the game board array as input and returns if there is a
        winner and who it was*/
        public int CheckForWinner(char[] board, int playerTurn)
        {
            //Horzontal Winning Condtion
            if (board[0] == board[1] && board[1] == board[2])
                return (playerTurn % 2 == 0) ? 2 : 1;
            else if (board[3] == board[4] && board[4] == board[5])
                return (playerTurn % 2 == 0) ? 2 : 1;
            else if (board[6] == board[7] && board[7] == board[8])
                return (playerTurn % 2 == 0) ? 2 : 1;

            //Vertical Winning Condtion
            else if (board[0] == board[3] && board[3] == board[6])
                return (playerTurn % 2 == 0) ? 2 : 1;
            else if (board[1] == board[4] && board[4] == board[7])
                return (playerTurn % 2 == 0) ? 2 : 1;
            else if (board[2] == board[5] && board[5] == board[8])
                return (playerTurn % 2 == 0) ? 2 : 1;

            //Diagonal Winning Condtion
            else if (board[0] == board[4] && board[4] == board[8])
                return (playerTurn % 2 == 0) ? 2 : 1;
            else if (board[2] == board[4] && board[4] == board[6])
                return (playerTurn % 2 == 0) ? 2 : 1;

            //Checking For a Draw
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' &&
                    board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
                return -1;

            else
                return 0;
        }
    }
}
