using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Dictionary_PlayerTreasure
{
    // TODO 00a create Player class derived from the Character class
    /// <summary>
    /// Player class, inherites from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        // TODO 06b - add a field/property of list of CoinGroup to the hold the player's coins
        private List<CoinGroup> _coins;  

        #endregion

        #region PROPERTIES
        
        public List<CoinGroup> Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set intial properties
        /// </summary>
        /// <param name="name">player name</param>
        public Player(
            string name)
            : base(name)
        {

            _coins = new List<CoinGroup>();

        }

        #endregion

        #region METHODS



        #endregion
    }
}
