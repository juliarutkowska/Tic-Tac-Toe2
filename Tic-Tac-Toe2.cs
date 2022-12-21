using Tic_Tac_Toe2;

var board = BoardInitializer.InitializeToBoard();

var symbol = Symbol.O;
var gameMode = GameChooser.ChooseAGame();

while (true)
{
    if (gameMode is GameMode.SinglePlayer)
    {
        Console.WriteLine("Now it's computers move.");
        Computer.Move(board, symbol);

        symbol = symbol is Symbol.O
            ? Symbol.X
            : Symbol.O;

        switch (WinChecker.CheckWinner(board, symbol))
        {
            case GameState.XWin:
                Console.WriteLine($"You won \"{symbol}\". Congrats!");
                break;  
        }
        
        Console.WriteLine("Now it's players move.");
    }
    
    Player.PlayersMove(board, symbol);

    switch (WinChecker.CheckWinner(board, symbol))
    {
        case GameState.XWin:
            Console.WriteLine($"You won \"{symbol}\". Congrats!");
            break;  
    }
    
    // Change for a good symbol
    symbol = symbol is Symbol.O
        ? Symbol.X
        : Symbol.O;    
}

