using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCodingTest.Models
{
    public class Player
    {
        private int id;
        private string playerName;
        private int cardValue;
        
        public Player()
        {
          
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

        public int CardValue
        {
            get
            {
                return cardValue;
            }

            set
            {
                cardValue = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
