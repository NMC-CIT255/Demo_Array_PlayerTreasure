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
            // set the initial size of the console window
            Console.WindowWidth = 80;
            Console.WindowHeight = 50;

            // TODO 04d - instantiate the Treasure object
            Treasure gametreasure = new Treasure();


            // TODO 05a - call the method to demonstrate managing the player's treasure
            DemoTreasureManagement(gametreasure);

        }

        // TODO 05a - add a method to demonstrate managing the treasure
        /// <summary>
        /// deonstrate managing the player's treasure
        /// </summary>
        /// <param name="myPlayer"></param>
        public static void DemoTreasureManagement(Treasure gameTreasure)
        {
            // TODO 06b - call the method to instantiate a new Treasure object, this will populate the coin array
            InitializeTreasures(gameTreasure);

            // TODO 07b - call the method to display the type of treasure a player can earn
            Console.WriteLine("The game's coin inventory:");
            DisplayTreasureTypes(gameTreasure);

            // TODO 08b - call the method to give the player coins to start the game
            GivePlayerCoinsToStartWith(gameTreasure);

            // TODO 09b - call the method to display the player's treasure
            Console.Clear();
            Console.WriteLine("The player's and game's coin inventory after the player gets coins to start with:");
            DisplayPlayersTreasure(gameTreasure);
            DisplayTreasureTypes(gameTreasure);

            // TODO 10b - prompt the user, and call the method to add coins to the player's treasure, and display the treasure
            Console.Clear();
            Console.WriteLine("Now let's add 25 gold coins to the player's inventory.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
            AddCoinsToPlayer(gameTreasure, 25, Coin.TypeName.SmallGoldCoin);
            DisplayPlayersTreasure(gameTreasure);
            DisplayTreasureTypes(gameTreasure);

            // TODO 11b - prompt the user, call the method to subtract the coins from the player's treasure, and display the treasure
            Console.Clear();
            Console.WriteLine("Now let's subtract 10 gold coins from the player's inventory");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
            SubtractCoinsFromPlayer(gameTreasure, 10, Coin.TypeName.SmallGoldCoin);
            DisplayPlayersTreasure(gameTreasure);
            DisplayTreasureTypes(gameTreasure);
        }

        // TODO 06a - add a method to instantiate a new Treasure object, this will populate the coin array
        /// <summary>
        /// intitialize the type of treasures in the game
        /// </summary>
        public static void InitializeTreasures(Treasure playerTreasure)
        {
            playerTreasure = new Treasure();
        }

        // TODO 07a - add a method to display the type of treasure a player can earn
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
                Console.WriteLine("Coin Name: " + ConsoleUtil.ToLabelFormat(coin.Name.ToString()));
                Console.WriteLine("Coin Description: " + coin.Description);
                Console.WriteLine("Coin Value: " + coin.ValueInDollars);
                Console.WriteLine("Total Coin Count in Game: " + coin.CountInGameInventory);
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        // TODO 08a - add a method to give the player coins to start the game
        /// <summary>
        /// give the player some coins to start the game
        /// </summary>
        /// <param name="gameTreasure">Treasure Object</param>
        public static void GivePlayerCoinsToStartWith(Treasure gameTreasure)
        {
            // TODO 11c - call the method to add coins to the player's treasure
            AddCoinsToPlayer(gameTreasure, 10, Coin.TypeName.SmallGoldCoin);
            AddCoinsToPlayer(gameTreasure, 50, Coin.TypeName.SmallSilverCoin);
        }

        // TODO 09a - add a method to display the player's treasure
        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersTreasure(Treasure gameTreasure)
        {
            Console.WriteLine();

            Console.WriteLine("The Player has the following treasure:");
            Console.WriteLine();

            DisplayPlayersCoins(gameTreasure);
        }

        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersCoins(Treasure gameTreasure)
        {
            Console.WriteLine();
            Console.WriteLine("Coins:");

            foreach (Coin coin in gameTreasure.Coins)
            {
                if (coin.CountInPlayerInventory > 0)
                {
                    Console.WriteLine(coin.CountInPlayerInventory + " " + ConsoleUtil.ToLabelFormat(coin.Name.ToString()));
                }
            }

            Console.WriteLine();
        }

        // TODO 10a - add a method to add coins to the player's treasure
        /// <summary>
        /// add coins to the player inventory
        /// </summary>
        /// <param name="gameTreasure">Treasure object</param>
        /// <param name="quantity">quantity of the coin to add</param>
        /// <param name="coinType">enum - TypeName of the coin to add</param>
        public static void AddCoinsToPlayer(Treasure gameTreasure, int quantity, Coin.TypeName coinType)
        {
            foreach (Coin coin in gameTreasure.Coins)
            {
                if (coin.Name == coinType)
                {
                    coin.CountInPlayerInventory += quantity;
                }
            }
        }

        // TODO 11a - add a method to subtract coins from the player's treasure
        /// <summary>
        /// subrtract coins from the player inventory
        /// </summary>
        /// <param name="gameTreasure">Treasure object</param>
        /// <param name="quantity">quantity of the coin to subrtract</param>
        /// <param name="coinType">enum - TypeName of the coin to subrtract</param>
        public static void SubtractCoinsFromPlayer(Treasure gameTreasure, int quantity, Coin.TypeName coinType)
        {
            foreach (Coin coin in gameTreasure.Coins)
            {
                if (coin.Name == coinType)
                {
                    coin.CountInPlayerInventory -= quantity;
                }
            }
        }
    }
}
