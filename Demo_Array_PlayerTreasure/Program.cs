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
            Treasure gametreasure = new Treasure();
            Player myPlayer = new Player("Bonzo");

            // call the method to demonstrate managing the player's treasure
            DemoTreasureManagement(myPlayer, gametreasure);

        }


        /// <summary>
        /// deonstrate managing the player's treasure
        /// </summary>
        /// <param name="myPlayer"></param>
        public static void DemoTreasureManagement(Player myPlayer, Treasure gameTreasure)
        {

            InitializeTreasures(gameTreasure);

            DisplayTreasureTypes(gameTreasure);

            GivePlayerCoins(myPlayer, gameTreasure);

            DisplayPlayersTreasure(myPlayer);

            Console.WriteLine("Now let's add 25 gold coins.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();

            DisplayPlayersTreasure(myPlayer);

            Console.WriteLine("Now let's subtract 10 gold coins.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();

            DisplayPlayersTreasure(myPlayer);
        }

        /// <summary>
        /// intitialize the type of treasures in the game
        /// </summary>
        public static void InitializeTreasures(Treasure playerTreasure)
        {
            playerTreasure = new Treasure();
        }

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
                Console.WriteLine("Coin Value: " + coin.ValueInDollars);
                Console.WriteLine("Total Coin Count in Game: " + coin.CountInGameInventory);
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        /// <summary>
        /// give the player some coins to start the game
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="gameTreasure"></param>
        public static void GivePlayerCoins(Player myPlayer, Treasure gameTreasure)
        {
            // add 2 small gold coins
            for (int coinIndex = 0; coinIndex < gameTreasure.Coins.Length; coinIndex++)
            {
                if (gameTreasure.Coins[coinIndex].Name == Coin.TypeName.SmallGoldCoin)
                {
                    gameTreasure.Coins[coinIndex].CountInPlayerInventory = 2;
                }
            }


        }

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

        /// <summary>
        /// add coins to the player inventory
        /// </summary>
        /// <param name="myPlayer">Player object</param>
        /// <param name="gameTreasure">Treasure object</param>
        /// <param name="quantity">quantity of the coin to add</param>
        /// <param name="coinType">enum - TypeName of the coin to add</param>
        public static void AddCoinsToPlayer(Player myPlayer, Treasure gameTreasure, int quantity, Coin.TypeName coinType)
        {

        }

        /// <summary>
        /// subrtract coins from the player inventory
        /// </summary>
        /// <param name="myPlayer">Player object</param>
        /// <param name="gameTreasure">Treasure object</param>
        /// <param name="quantity">quantity of the coin to subrtract</param>
        /// <param name="coinType">enum - TypeName of the coin to subrtract</param>
        public static void SubtractCoinsFromPlayer(Player myPlayer, Treasure gameTreasure, int quantity, Coin.TypeName coinType)
        {

        }
    }
}
