namespace Tic_Tac_Toe2;

public static class Player
{
    public static void PlayersMove(Symbol[,] board, Symbol symbol)
    {
        while (true)
        {
            var move = InputHelper.GetUsersMove(symbol);
            Console.WriteLine($"You put your {symbol} here: {move.Row} {move.Column}.");

            if (board[move.Row, move.Column].Equals("o") || board[move.Row, move.Column].Equals("x"))
            {
                Console.WriteLine("This spot is taken. Please chose another one.");
                continue;
            }
    
            board[move.Row, move.Column] = symbol;
            BoardPrinter.PrintBoard(board);

            break;
        }
    }
}