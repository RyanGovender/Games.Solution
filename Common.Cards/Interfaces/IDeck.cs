using Common.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cards.Interfaces
{
    public interface IDeck
    {
        int KING_VALUE { get; set; }
        int JACK_VALUE { get; set; } 
        int QUEEN_VALUE { get; set; }
        int ACE_VALUE { get; set; }
        Card[] Playing_Deck { get; set; }
        Card[] GenerateDeck();
        Card GetCard();
        void ShuffleDeck();
    }
}
