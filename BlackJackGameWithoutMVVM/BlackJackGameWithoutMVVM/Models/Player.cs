using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGameWithoutMVVM.Models
{
    public class Player
    {
        private int playerID;
        private string playerName;
        private int handValue = 0;
        private bool playerTurn = true;
        /// <summary>
        /// Default constructor to initialize a new player
        /// </summary>
        public Player()
        {

        }
        //Initialize a new player with ID and Name
        public Player(int playerID, string playerName)
        {
            this.playerID = playerID;
            this.playerName = playerName;
        }

        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }


        public int ID
        {
            get
            {
                return playerID;
            }

            set
            {
                playerID = value;
            }
        }

        public int HandValue
        {
            get
            {
                return handValue;
            }

            set
            {
                handValue += value;
            }
        }

        public bool PlayerTurn
        {
            get
            {
                return playerTurn;
            }

            set
            {
                playerTurn = value;
            }
        }
    }
}

