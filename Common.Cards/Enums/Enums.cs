using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cards.Enums
{
    public static class Enums
    {
        public enum Suit
        {
            Clubs,
            Spades,
            Hearts,
            Diamonds
        }

        public enum RoyalCards
        {
            Ace = 0,
            King = 11,
            Queen = 10,
            Jack = 12
        }
    }
}
