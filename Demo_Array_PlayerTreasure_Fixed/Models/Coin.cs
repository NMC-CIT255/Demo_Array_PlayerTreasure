using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
    // TODO 03 - add a Coin class
    /// <summary>
    /// class to hold all of the information for a given coin type
    /// </summary>
    public class Coin
    {
        #region ENUMERABLES

        public enum TypeName
        {
            SmallGoldCoin,
            SmallSilverCoin,
            SmallBronzeCoin
        }

        #endregion


        #region FIELDS

        private TypeName _name;
        private string _description;
        private int _valueInDollars;
        private int _countInPlayerInventory;
        private int _countInGameInventory;

        public int CountInGameInventory
        {
            get { return _countInGameInventory; }
            set { _countInGameInventory = value; }
        }


        public int CountInPlayerInventory
        {
            get { return _countInPlayerInventory; }
            set
            {
                // TODO 12 - update coins in game inventory when coins in player inventory change
                _countInGameInventory += _countInPlayerInventory - value;
                _countInPlayerInventory = value;
            }
        }


        public int ValueInDollars
        {
            get { return _valueInDollars; }
            set { _valueInDollars = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public TypeName Name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion

        #region PROPERTIES



        #endregion

        #region CONSTRUCTORS

        public Coin()
        {

        }

        public Coin(TypeName name, string description, int value, int countInGameInventory)
        {
            _name = name;
            _description = description;
            _valueInDollars = value;
            _countInGameInventory = countInGameInventory;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
