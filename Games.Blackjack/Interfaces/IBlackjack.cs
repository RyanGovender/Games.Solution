using Common.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.Interfaces
{
    public interface IBlackjack
    {
        Card DealCard();
        void DisplayDeck();
        void PlayGameRound(UserType firstPlayer = UserType.PLAYER);
        void PlayGame();
    }
}
