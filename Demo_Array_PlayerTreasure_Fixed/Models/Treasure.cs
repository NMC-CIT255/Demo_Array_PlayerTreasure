using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
    // TODO 04a - add a treasure class to hold all of the treasure information
    /// <summary>
    ///  class for all of the player's treasures
    /// </summary>
    public class Treasure
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private Coin[] _coins; 
        
        #endregion

        #region PROPERTIES

        // TODO 04b - add a Coin array, each element is a different type of coins info
        public Coin[] Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Treasure()
        {
            InitializeCoinArray();

        }

        #endregion

        #region METHODS

        // TODO 04c - add a method initialize the Coin array and populate it with the coin type info
        public void InitializeCoinArray()
        {
            _coins = new Coin[3];

            _coins[0] = new Coin()
            {
                Name = Coin.TypeName.SmallGoldCoin,
                Description = "Gold coin with the Kings's face on one side and the Castle Wilhelm on the other side.",
                ValueInDollars = 10,
                CountInGameInventory = 50
            };

            _coins[1] = new Coin()
            {
                Name = Coin.TypeName.SmallSilverCoin,
                Description = "Silver coin with the Queen's face on one side and the River Thomes on the other side.",
                ValueInDollars = 5,
                CountInGameInventory = 100
            };

            _coins[2] = new Coin()
            {
                Name = Coin.TypeName.SmallBronzeCoin,
                Description = "Bronze coin with the Prince's face on one side and Mount Fidoria on the other side.",
                ValueInDollars = 1,
                CountInGameInventory = 500
            };
        }

        #endregion
    }
}
