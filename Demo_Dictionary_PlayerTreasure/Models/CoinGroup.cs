using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_Dictionary_PlayerTreasure
{
    // TODO 06a - add a CoinGroup class to hold the coin type an and quantity
    /// <summary>
    /// class to hold groups of common coins
    /// </summary>
    public class CoinGroup
    {
        public int Quantity { get; set; }
        public Coin CoinType { get; set; }
        
    }
}
