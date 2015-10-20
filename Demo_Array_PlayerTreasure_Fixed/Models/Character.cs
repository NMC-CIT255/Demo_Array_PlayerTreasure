using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
    // TODO 01 - add a Character class to act as the base class for the Player class
    /// <summary>
    /// base class for player and guests in game
    /// </summary>
    public class Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        protected string _name;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        /// <summary>
        /// instantiate a character and set intial properties
        /// </summary>
        /// <param name="name">character name</param>
        public Character(string name)
        {
            _name = name;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
