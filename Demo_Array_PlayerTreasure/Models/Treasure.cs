using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{


    // TODO 01a - add a treasure class
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
                ValueInDollars = 10,
                CountInGameInventory = 100
            };

            _coins[2] = new Coin()
            {
                Name = Coin.TypeName.SmallBronzeCoin,
                Description = "Bronze coin with the Prince's face on one side and Mount Fidoria on the other side.",
                ValueInDollars = 10,
                CountInGameInventory = 500
            };
        }

        #endregion
    }
}
