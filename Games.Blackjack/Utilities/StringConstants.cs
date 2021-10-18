using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Blackjack.Utilities
{
    public static class StringConstants
    {
        public static string PLAYER_END_GAME => "h";
        public static string END_GAME => "q";
        public static string PLAYER_WIN_DEALER_OVER_21 => "You Win !! The dealer score is over 21!";
        public static string DEALER_WIN_PLAYER_OVER_21 => "Your score is over 21 !! The Dealer Wins!";
        public static string PLAYER_WINS => "Player Wins!";
        public static string DELAER_WINS => "Dealer Wins!";
    }
}
