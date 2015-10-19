using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 00a - instantiate a player and game treasure objects
            Treasure gametreasure = new Treasure();
            Player myPlayer = new Player("Bonzo");

            // TODO 03b - call the method to demonstrate managing the player's treasure
            DemoTreasureManagement(myPlayer, gametreasure);

        }

        // TODO 03a - add a method to demonstrate managing the player's treasure
        /// <summary>
        /// deonstrate managing the player's treasure
        /// </summary>
        /// <param name="myPlayer"></param>
        public static void DemoTreasureManagement(Player myPlayer, Treasure gameTreasure)
        {
            // TODO 
            InitializeTreasures(gameTreasure);

            // TODO 
            DisplayTreasureTypes(gameTreasure);

            // TODO 07b - call the method to give the player some coins at the start of the game
            GivePlayerCoins(myPlayer, gameTreasure);

            // TODO 08c - call the method to display the player's treasure         
            DisplayPlayersTreasure(myPlayer);

            Console.WriteLine("Now let's add 25 gold coins.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();

            // TODO 09b - call the method to add more coins of a specific type to the player's treasure
            //AddCoinsToPlayer(myPlayer, gameTreasure, Treasure.CoinNames.SmallGoldCoin, 25);

            DisplayPlayersTreasure(myPlayer);

            Console.WriteLine("Now let's subtract 10 gold coins.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();

            // TODO 10b - call the method to subtract coins of a specific type from the player's treasure
            //SubtractCoinsFromPlayer(myPlayer, gameTreasure, Treasure.CoinNames.SmallGoldCoin, 10);

            DisplayPlayersTreasure(myPlayer);
        }

        // TODO 04a - add a method to initialze the game treasure types
        /// <summary>
        /// intitialize the type of treasures in the game
        /// </summary>
        public static void InitializeTreasures(Treasure playerTreasure)
        {
            playerTreasure = new Treasure();
        }

        // TODO 05a - add a DisplayTreasureTypes method
        /// <summary>
        /// display all of the treasure types
        /// </summary>
        public static void DisplayTreasureTypes(Treasure gameTreasure)
        {
            Console.WriteLine();

            Console.WriteLine("The game contains the treasure types:");
            Console.WriteLine();

            foreach (Coin coin in gameTreasure.Coins)
            {
                Console.WriteLine("Coin Name: " + coin.Name);
                Console.WriteLine("Coin Description: " + coin.Description);
                Console.WriteLine("Coin Type: " + coin.Type);
                Console.WriteLine("Coin Value: " + coin.ValueInDollars);
                Console.WriteLine("Total Coin Count in Game: " + coin.CountInGameInventory);
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        // TODO 07a - add a method to give the player some coins at the start of the game
        /// <summary>
        /// give the player some coins to start the game
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="gameTreasure"></param>
        public static void GivePlayerCoins(Player myPlayer, Treasure gameTreasure)
        {

        }


        // TODO 08b - add a DisplayPlayerTreasure method
        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersTreasure(Player myPlayer)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("The Player has the following treasure:");
            Console.WriteLine();

            DisplayPlayersCoins(myPlayer);

            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersCoins(Player myPlayer)
        {
            Console.WriteLine();

            Console.WriteLine("Coins:");
            Console.WriteLine();


        }


        public static void AddCoinsToPlayer(Player myPlayer, Treasure gameTreasure, int quantity)
        {

        }


        public static void SubtractCoinsFromPlayer(Player myPlayer, Treasure gameTreasure, int quantity)
        {

        }
    }
}
