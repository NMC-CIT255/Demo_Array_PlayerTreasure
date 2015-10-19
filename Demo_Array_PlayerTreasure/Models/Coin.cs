using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
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

        private string _name;
        private string _description;
        private TypeName _type;
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
            set { _countInPlayerInventory = value; }
        }
        

        public int ValueInDollars
        {
            get { return _valueInDollars; }
            set { _valueInDollars = value; }
        }
        

        public TypeName Type
        {
            get { return _type; }
            set { _type = value; }
        }
        

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Name
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

        public Coin(string name, string description, TypeName type, int value)
        {
            _name = name;
            _description = description;
            _type = type;
            _valueInDollars = value;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
