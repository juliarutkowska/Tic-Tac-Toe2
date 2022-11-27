using Tic_Tac_Toe2;

var board = BoardInitializer.InitializeToBoard();

var symbol = "o";
var turns = 0;
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
    turns++;

    if (WinChecker.CheckWinner(board, symbol))
    {
        Console.WriteLine($"You won \"{symbol}\". Congrats!");
        return;
    }
    
    // Change for a good symbol
    if (symbol == "o")
    {
        symbol = "x";
    }
    else
    {
        symbol = "o";
    }
    
    
    if (turns == 9)
    {
        Console.WriteLine("It's a draw!");
        break;
    }
}

