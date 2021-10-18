using Common.Cards.Extension;
using Common.Cards.Interfaces;
using Common.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Cards.Enums.Enums;

namespace Common.Cards.Infrastructure
{
    public class Deck : IDeck
    {
        public int KING_VALUE { get; set; } = 10;
        public  int JACK_VALUE { get; set; } = 10;
        public  int QUEEN_VALUE { get; set; } = 10;
        public  int ACE_VALUE { get; set; } = 1;
        public Card[] Playing_Deck { get; set; }

        private const int _deckSize = 52;
        private int _currentDeckSize = _deckSize;

        //This was created to allow the deck to be reused by any card game.
        public Deck()
        {
            GenerateDeck();
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            Playing_Deck.ShuffleDeck();
        }

        public Card[] GenerateDeck()
        {
            Playing_Deck = new Card [_deckSize];

            for(int i = 0; i< _deckSize; i++)
            {
                Playing_Deck[i]=GetRoyalCards(i % 4, i % 13);
            }
            return Playing_Deck;
        }

        public Card GetCard()
        {
            var card = Playing_Deck[_currentDeckSize - 1];

            Playing_Deck = Playing_Deck.Where((source, index) => index != _currentDeckSize -1).ToArray();

            _currentDeckSize--;

            return card;
        }

        private Card GetRoyalCards(int suit, int cardRank)
        {
            Card card = new();

            var royalCard = cardRank.IntToEnum<RoyalCards>();

            switch (royalCard)
            {
                case RoyalCards.Ace:
                    SetRoyalCard(ref card, ACE_VALUE, royalCard);
                    break;
                case RoyalCards.Queen:
                    SetRoyalCard(ref card, QUEEN_VALUE, royalCard);
                    break;
                case RoyalCards.King:
                    SetRoyalCard(ref card, KING_VALUE, royalCard);
                    break;
                case RoyalCards.Jack:
                    SetRoyalCard(ref card, JACK_VALUE, royalCard);
                    break;
                default:
                    card.CardName = cardRank.ToString();
                    card.CardValue = cardRank;
                    break;
            }

            card.Suit = suit.IntToEnum<Suit>();

            return card;
            
        }

        private static void SetRoyalCard(ref Card card, int value, RoyalCards  royalCard)
        {
            card.CardName = royalCard.ToString();
            card.CardValue = value;
        }
    }
}
