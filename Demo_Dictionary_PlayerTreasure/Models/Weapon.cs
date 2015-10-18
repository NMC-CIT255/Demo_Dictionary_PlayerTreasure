using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ListsDictionaries
{
    // TODO T-02 add a Weapon class
    /// <summary>
    /// class for all game weapons
    /// </summary>
    public class Weapon : GameItem
    {
        #region ENUMERABLES

        public enum WeaponType
        {
            knife,
            gun,
            laser
        }

        #endregion


        #region FIELDS

        private WeaponType _type;

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }



        #endregion

        #region PROPERTIES



        #endregion

        #region CONSTRUCTORS

        public Weapon()
        {

        }

        // note constructor inheritance from base class
        public Weapon(
            WeaponType type,
            string name,
            string description)
            : base(name, description)
        {

        }

        #endregion

        #region METHODS



        #endregion
    }
}
