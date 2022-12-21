namespace Tic_Tac_Toe2;

public static class GameChooser
{
    public static GameMode ChooseAGame()
    {
        while (true)
        {
            Console.WriteLine("What game do you want to play?");
            Console.WriteLine("Press \"1\" if you want to play with the computer.");
            Console.WriteLine("Press \"2\" if you want to play with the other player.");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("You chose single player game.");
                    return GameMode.SinglePlayer;
                case "2":
                    Console.WriteLine("You chose multiplayer game.");
                    return GameMode.MultiPlayer;
                default:
                    Console.WriteLine("You put wrong input.");
                    break;
            }
        }
    }
}