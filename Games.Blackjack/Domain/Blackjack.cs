using Common.Cards.Infrastructure;
using Common.Cards.Interfaces;
using Common.Cards.Models;
using Games.Blackjack.Interfaces;
using Games.Blackjack.Models;
using Games.Blackjack.RulesValidator;
using Games.Blackjack.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.Domain
{
    public class Blackjack : IBlackjack
    {
        private readonly IDeck _deck;
        private IUser _currentPlayer;

        int playerScore;

        public Blackjack()
        {
            //To create a new instance of a deck that the values of the following cards can be configured.
            //Deck/card has been create in its own libary so it can be used with any card game. 
            _deck = new Deck { 
                KING_VALUE = 10,
                QUEEN_VALUE = 10,
                JACK_VALUE = 10,
                ACE_VALUE = 1
            };

            playerScore = 0;
        }

        public Card DealCard()
        {
            return _deck.GetCard();
        }

        public void DisplayDeck()

        {
            foreach(var item in _deck.Playing_Deck)
            {
                Console.WriteLine($"{item.CardName} {item.CardValue} {item.Suit}");
            }
        }

        public void PlayGame()
        {
            string continueGame;
            do
            {
                PlayGameRound();
                continueGame = Utilities.Utilities.GetInput("Would you like to play another round ? Press Enter to Continue or (Q) to quite.");
                _deck.GenerateDeck();
                _deck.ShuffleDeck();
            } while (!continueGame.Equals(StringConstants.END_GAME));
        }

        //Will create an instance based on the type of player(dealer or player). This allows us to reuse a lot of the code and allows the game to depend on a high level of abstraction.
        public void PlayGameRound(UserType firstPlayer = UserType.PLAYER)
        {
            _currentPlayer = GetUser(firstPlayer);

            bool isGameActive = true;

            while (isGameActive)
            {
                var card = DealCard();
                _currentPlayer.TotalScore += card.CardValue;

                Console.WriteLine($"{_currentPlayer.UserType} card is {card.CardName} {card.Suit} \n {_currentPlayer.UserType} Total Score is : {_currentPlayer.TotalScore}");

                //Checks to see if the player or dealer has completed the game.
                isGameActive = BlackjackRulesValidator.ValidateGameActive(_currentPlayer, playerScore);

                PlayerTurn(ref isGameActive);
            }
        }

        //These rules only imply to a player and have been separated.
        //we directly change the value of isGameActive thats why we are using ref
        private void PlayerTurn(ref bool isGameActive)
        {
            if (_currentPlayer.UserType == UserType.PLAYER)
            {
                var input = Utilities.Utilities.GetInput("To continiue Press Enter to HIT \n To Stop Press (H)");

                if (input.Equals(StringConstants.PLAYER_END_GAME))
                {
                    playerScore = _currentPlayer.TotalScore;
                    isGameActive = false;
                    PlayGameRound(UserType.DEALER);
                }
            }
        }

        private static IUser GetUser(UserType userType)
        {
            return userType switch
            {
                UserType.DEALER => new Dealer(),
                UserType.PLAYER => new Player(),
                _ => null,
            };
        }
    }
}
