using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCodingTest.Models
{
    public class GameDeck
    {
        public  List<Card> Deck;

        public GameDeck()
        {
            Deck = new List<Card>();
            createDeck();
        }

        private void createDeck()
        {
            foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds", })
            {
                for (var rank = 0; rank <= 13; rank++)
                {
                    Deck.Add(new Card(rank, suit));
                }
            }
        }
    }
}
