using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure.Models
{
    public class TreasureItem
    {
        #region ENUMERABLES

        public enum Category
        {
            Coin,
            Jewel
        }

        #endregion


        #region FIELDS

        private string _name;
        private string _description;
        private Category _category;
        private int value;

        public int Value
        {
            get { return value; }
            set { value = value; }
        }
        

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
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



        #endregion

        #region METHODS



        #endregion
    }
}
