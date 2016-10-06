using BlackJackCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCodingTest.ViewModels
{
    public class GameViewModel
    {
        public GameDeck gameDeck;
        private Player player1;
        private Player player2;
        private Player player3;
        public GameViewModel()
        {
            gameDeck = new GameDeck();
            player1 = new Player() { ID = 1, PlayerName = "Van" };
            player1 = new Player() { ID = 2, PlayerName = "Huy" };
            player1 = new Player() { ID = 3, PlayerName = "Duc" };
        }

        public void StartGame()
        {
            Random rnd = new Random();

            Card currentCard = gameDeck.Deck[rnd.Next()];

            displayCard(currentCard);

            gameDeck.Deck.Remove(currentCard);
        }

        public void displayCard(Card currentCard)
        {

        }
    }
}
