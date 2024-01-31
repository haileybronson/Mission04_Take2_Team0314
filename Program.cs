
//Welcome the user to the game
using Mission4_Take2_Team0314;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        //Create a game board array to store the players’ choices
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char currentPlayer = 'X';
        Supporting game = new Supporting();

        while (true)
        {
            Console.Clear();
            game.DrawBoard(board);

            //Ask each player in turn for their choice and update the game board array
            Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
            int move = int.Parse(Console.ReadLine());

            //invalid moves
            if (move < 1 || move > 9 || board[move - 1] == 'X' || board[move - 1] == 'O')
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            board[move - 1] = currentPlayer;
            //Check for a winner by calling the method in the supporting class, and notify the players

            if (game.CheckForWinner(board, currentPlayer))
            {
                Console.Clear();
                game.DrawBoard(board);
                //when a win has occurred and which player won the game 
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            if (Array.IndexOf(board, ' ') == -1)
            {
                Console.Clear();
                //Print the board by calling the method in the supporting class
                game.DrawBoard(board);
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}