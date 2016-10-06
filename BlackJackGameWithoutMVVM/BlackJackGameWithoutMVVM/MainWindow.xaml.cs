using BlackJackGameWithoutMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJackGameWithoutMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int winningHand = 0;
        public int pID = 0;
        public BlackJackDeck GameDeck;
        public List<Player> Players;
        public bool Gameover;
        public string GameHistory;
        public int turns = 0;
        public MainWindow()
        {
            InitializeComponent();
            HitButton.IsEnabled = false;
            PlayAgainButton.IsEnabled = false;

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            startOfGame();
            checkIfGameIsOver();
        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            turns++;
            Card nextCard = GameDeck.DrawAndRemoveCardFromDeck();
            GameHistory += turns + " " + nextCard.Rank + " " + nextCard.Suit + " was hit \n";
            GameStatusTextBox.Text = GameHistory;
            runGame(nextCard);

            Player1HandLabel.Content = Players[0].HandValue.ToString();
            Player2HandLabel.Content = Players[1].HandValue.ToString();
            Player3HandLabel.Content = Players[2].HandValue.ToString();
            checkIfGameIsOver();

        }
        private void runGame(Card nextCard)
        {
            checkIfGameIsOver();
            foreach (Player player in Players)
            {
                if (checkPlayerHand(player))
                {
                    player.HandValue = nextCard.CardValue;
                    //checkIfGameIsOver();
                    return;
                }
                checkIfGameIsOver();
            }
            checkIfGameIsOver();
        }
        private void startOfGame()
        {
            PlayAgainButton.IsEnabled = false;
            GameDeck = new BlackJackDeck();
            Players = new List<Player>();
            Players.Add(new Player(1, "Van"));
            Players.Add(new Player(2, "Duc"));
            Players.Add(new Player(3, "Huy"));
            Gameover = false;
            StartButton.IsEnabled = false;
            HitButton.IsEnabled = true;
            pID = 0;
            winningHand = 0;
            GameHistory = "";

            Card nextCard;
            int playerTurn = 0;
            foreach (var player in Players)
            {
                playerTurn++;
                for (int i = 0; i < 2; i++)
                {
                    turns++;
                    nextCard = GameDeck.DrawAndRemoveCardFromDeck();
                    player.HandValue = nextCard.CardValue;
                    GameHistory += turns + ": Player" + player.ID + " HIT A " + nextCard.Rank + " of " + nextCard.Suit + " was hit \n";
                    GameStatusTextBox.Text = GameHistory;
                }
            }
            checkIfGameIsOver();

            Player1HandLabel.Content = Players[0].HandValue.ToString();
            Player2HandLabel.Content = Players[1].HandValue.ToString();
            Player3HandLabel.Content = Players[2].HandValue.ToString();
        }
        private bool checkPlayerHand(Player player)
        {
            if (player.HandValue == 21)
            {
                StartButton.IsEnabled = true;
                HitButton.IsEnabled = false;
                Gameover = true;
                pID = player.ID;
                winningHand = player.HandValue;
                //GameStatusTextBox.Text = "Player" + player.ID + " is the winner!";
                gameOver();
                return false;
            }
            else if (player.HandValue >= 17)
            {
                player.PlayerTurn = false;
                checkIfGameIsOver();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void PlayAgain()
        {
            PlayAgainButton.IsEnabled = true;
            startOfGame();
        }

        private void gameOver()
        {
            StartButton.IsEnabled = false;
            HitButton.IsEnabled = false;
            PlayAgainButton.IsEnabled = true;

            foreach (Player player in Players)
            {
                if (player.HandValue > winningHand && player.HandValue < 21)
                {
                    winningHand = player.HandValue;
                    pID = player.ID;
                }

            }


            GameStatusTextBox.Text = "Player" + pID + " is the winner!  He has "+ winningHand;
        }

        private void PlayAgainButton_Click(object sender, RoutedEventArgs e)
        {
            PlayAgain();
        }

        private void checkIfGameIsOver()
        {
            foreach (Player player in Players)
            {
                if (player.PlayerTurn == false)
                    Gameover = true;
                else
                    Gameover = false;
            }

            if (Gameover == true)
            {
                StartButton.IsEnabled = false;
                HitButton.IsEnabled = false;
                PlayAgainButton.IsEnabled = true;
                gameOver();
            }
              
        }

      
    }
}