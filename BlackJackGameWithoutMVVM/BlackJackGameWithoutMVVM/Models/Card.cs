﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGameWithoutMVVM.Models
{
    public class Card
    {
        private int rank;
        private int cardValue;
        private string suit;
        /// <summary>
        /// Initialize a new instance of card with card value and suit
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(int rank,int cardValue, string suit)
        {
            Rank = rank;
            Suit = suit;
            CardValue = cardValue;
        }
       

        public string Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
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
                if (Rank >= 10)
                    cardValue = 10;
                else if (Rank == 1)
                    cardValue = 11;
                else
                    cardValue = value;
            }
        }
    }
}
