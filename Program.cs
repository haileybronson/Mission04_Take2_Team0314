
//Welcome the user to the game
using System;
using Mission4_Take2_Team0314;

internal class Program
{
    //Create a game board array to store the players’ choices
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int playerTurn = 1; // Player 1 starts

    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        int choice;
        int player = 0; // By default, no winner
        Supporting game = new Supporting();

        do
        {
            Console.Clear(); // Clear the console for a cleaner display
            Console.WriteLine("Player {0}: ", playerTurn % 2 == 0 ? 2 : 1);
            game.DrawBoard(board);

            // Check for invalid input
            bool validInput = false;
            do
            {
                //Ask each player in turn for their choice and update the game board array
                Console.Write("Enter a number (1-9): ");
                validInput = int.TryParse(Console.ReadLine(), out choice);
                if (!validInput || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    validInput = false;
                }
            } while (!validInput);

            // Assign 'X' or 'O' based on player turn
            char marker = (playerTurn % 2 == 0) ? 'O' : 'X';

            // Update the board and check for a winner
            board[choice - 1] = marker;
            //Check for a winner by calling the method in the supporting class, and notify the players
            //when a win has occurred and which player won the game
                        player = game.CheckForWinner(board, playerTurn);

            // Switch player turn
            playerTurn++;

        } while (player == 0);

        Console.Clear();
        //Print the board by calling the method in the supporting class
        game.DrawBoard(board);

        if (player == -1)
            Console.WriteLine("It's a draw!");
        else
            Console.WriteLine("Player {0} wins!", player);

        Console.ReadLine();
    }
}