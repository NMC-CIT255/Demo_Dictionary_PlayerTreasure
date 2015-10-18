using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Dictionary_PlayerTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 00a - instantiate a player and game treasure objects
            Treasure gametreasure = new Treasure();
            Player myPlayer = new Player("Bonzo");

            // TODO 03b - call the method to demonstrate managing the player's treasure
            DemoTreasureManagement(myPlayer, gametreasure);

        }

        // TODO 03a - add a method to demonstrate managing the player's treasure
        /// <summary>
        /// deonstrate managing the player's treasure
        /// </summary>
        /// <param name="myPlayer"></param>
        public static void DemoTreasureManagement(Player myPlayer, Treasure gameTreasure)
        {
            // TODO 04c - call the method to initialze the game treasure types
            InitializeTreasures(gameTreasure);

            // TODO 05b - call DisplayTreasureTypes method
            DisplayTreasureTypes(gameTreasure);

            // TODO 07b - call the method to give the player some coins at the start of the game
            GivePlayerCoins(myPlayer, gameTreasure);

            // TODO 08c - call the method to display the player's treasure         
            DisplayPlayersTreasure(myPlayer);

            // TODO 09b - call the method to add more coins of a specific type to the player's treasure
            AddCoinsToPlayer(myPlayer, gameTreasure, Treasure.CoinNames.SmallGoldCoin, 25);

            DisplayPlayersTreasure(myPlayer);

            // TODO 10b - call the method to subtract coins of a specific type from the player's treasure
            SubtractCoinsFromPlayer(myPlayer, gameTreasure, Treasure.CoinNames.SmallGoldCoin, 10);

            DisplayPlayersTreasure(myPlayer);
        }

        // TODO 04a - add a method to initialze the game treasure types
        /// <summary>
        /// intitialize the type of treasures in the game
        /// </summary>
        public static void InitializeTreasures(Treasure playerTreasure)
        {

            // TODO 04b - initialize the coin types
            Coin goldCoin = new Coin(
                Treasure.CoinNames.SmallGoldCoin,
                "Gold coin with the Kings's face on one side and the Castle Wilhelm on the other side.",
                Treasure.Material.Gold,
                1);

            Coin silverCoin = new Coin(
                Treasure.CoinNames.SmallSilverCoin,
                "Silver coin with the Queen's face on one side and the River Thomes on the other side.",
                Treasure.Material.Silver,
                1);

            Coin bronzeCoin = new Coin(
                Treasure.CoinNames.SmallBronzeCoin,
                "Bronze coin with the Prince's face on one side and Mount Fidoria on the other side.",
                Treasure.Material.Bronze,
                1);

            playerTreasure.CoinTypes.Add(goldCoin);
            playerTreasure.CoinTypes.Add(silverCoin);
            playerTreasure.CoinTypes.Add(bronzeCoin);
        }

        // TODO 05a - add a DisplayTreasureTypes method
        /// <summary>
        /// display all of the treasure types
        /// </summary>
        public static void DisplayTreasureTypes(Treasure gameTreasure)
        {
            Console.WriteLine();

            Console.WriteLine("The game contains the treasure types:");
            Console.WriteLine();

            foreach (Coin coinType in gameTreasure.CoinTypes)
            {
                Console.WriteLine("Currency Name: " + ConsoleUtil.ToLabelFormat(coinType.Name.ToString()));
                Console.WriteLine("Currency Description: " + coinType.Description);
                Console.WriteLine("Currency Base Material: " + coinType.TypeOfMaterial);
                Console.WriteLine("Currency Value: " + gameTreasure.CoinValue(coinType));
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        // TODO 07a - add a method to give the player some coins at the start of the game
        /// <summary>
        /// give the player some coins to start the game
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="gameTreasure"></param>
        public static void GivePlayerCoins(Player myPlayer, Treasure gameTreasure)
        {
            int coinTypeIndex;

            coinTypeIndex = gameTreasure.CoinTypes.FindIndex(c => c.Name == Treasure.CoinNames.SmallGoldCoin);
            CoinGroup smallGoldCoins = new CoinGroup()
            {
                Quantity = 5,
                CoinType = gameTreasure.CoinTypes[coinTypeIndex]
            };

            coinTypeIndex = gameTreasure.CoinTypes.FindIndex(c => c.Name == Treasure.CoinNames.SmallSilverCoin);
            CoinGroup smallSilverCoins = new CoinGroup()
            {
                Quantity = 10,
                CoinType = gameTreasure.CoinTypes[coinTypeIndex]
            };

            coinTypeIndex = gameTreasure.CoinTypes.FindIndex(c => c.Name == Treasure.CoinNames.SmallBronzeCoin);
            CoinGroup smallBronzeCoins = new CoinGroup()
            {
                Quantity = 20,
                CoinType = gameTreasure.CoinTypes[coinTypeIndex]
            };

            myPlayer.Coins.Add(smallGoldCoins);
            myPlayer.Coins.Add(smallSilverCoins);
            myPlayer.Coins.Add(smallBronzeCoins);
        }


        // TODO 08b - add a DisplayPlayerTreasure method
        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersTreasure(Player myPlayer)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("The Player has the following treasure:");
            Console.WriteLine();

            DisplayPlayersCoins(myPlayer);

            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }

        // TODO 08c - add a DisplayPlayersCoins method
        /// <summary>
        /// display all of the currency types
        /// </summary>
        public static void DisplayPlayersCoins(Player myPlayer)
        {
            Console.WriteLine();

            Console.WriteLine("Coins:");
            Console.WriteLine();

            foreach (CoinGroup coin in myPlayer.Coins)
            {
                Console.WriteLine(coin.Quantity + " " + ConsoleUtil.ToLabelFormat(coin.CoinType.Name.ToString()));
            }
        }

        // TODO 09a - add a method to add more coins of a specific type to the player's treasure
        /// <summary>
        /// a method to add more coins of a specific type to the player's treasure
        /// </summary>
        /// <param name="myPlayer">Player object</param>
        /// <param name="gameTreasure">player's Treasure object</param>
        /// <param name="coins">coin type to add</param>
        /// <param name="quantity">number of coins</param>
        public static void AddCoinsToPlayer(Player myPlayer, Treasure gameTreasure, Treasure.CoinNames coinName, int quantity)
        {
            // find the index of coin type
            int coinTypeIndex = gameTreasure.CoinTypes.FindIndex(c => c.Name == coinName);

            myPlayer.Coins[coinTypeIndex].Quantity += quantity;
        }

        // TODO 10a - add a method to subtract coins of a specific type from the player's treasure
        /// <summary>
        /// a method to subtract coins of a specific type from the player's treasure
        /// </summary>
        /// <param name="myPlayer">Player object</param>
        /// <param name="gameTreasure">player's Treasure object</param>
        /// <param name="coins">coin type to add</param>
        /// <param name="quantity">number of coins</param>
        public static void SubtractCoinsFromPlayer(Player myPlayer, Treasure gameTreasure, Treasure.CoinNames coinName, int quantity)
        {
            // find the index of coin type
            int coinTypeIndex = gameTreasure.CoinTypes.FindIndex(c => c.Name == coinName);

            myPlayer.Coins[coinTypeIndex].Quantity -= quantity;
        }
    }
}
