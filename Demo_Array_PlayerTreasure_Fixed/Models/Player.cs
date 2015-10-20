using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_PlayerTreasure
{
    // TODO 02 - add a Player class that derives from the base Character class
    /// <summary>
    /// Player class, inherites from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS


        #endregion

        #region PROPERTIES
        

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set intial properties
        /// </summary>
        /// <param name="name">player name</param>
        public Player(
            string name)
            : base(name) // constructor inherits from Character base class constructor 
        {

            
        }

        #endregion

        #region METHODS



        #endregion
    }
}
