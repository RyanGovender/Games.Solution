using Common.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cards.Extension
{
    public static class CardExtension
    {
        private static readonly Random random = new();

        public static Card[] ShuffleDeck(this Card[] deck)
        {
            for(int n = deck.Length - 1; n > 0; n--)
            {
                int k = random.Next(n + 1);
                var temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
            return deck;
        }

        public static Card GetCard(this Card[] _deck)
        {
            var card = _deck[_deck.Length - 1];

            _deck = _deck.Where((source, index) => index != _deck.Length - 1).ToArray();

            return card;
        }

    }
}
