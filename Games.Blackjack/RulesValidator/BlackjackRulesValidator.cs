using Games.Blackjack.Interfaces;
using Games.Blackjack.Models;
using Games.Blackjack.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.RulesValidator
{
    public class BlackjackRulesValidator
    {
        private static List<Rules> _rules;

        //These are the rules for both Player and Dealer to determine the winner of the game.
        static BlackjackRulesValidator()
        {
            _rules = new()
            {
                new Rules() { RuleFor = UserType.DEALER, Message = (dealerScore, playerscore) => StringConstants.PLAYER_WIN_DEALER_OVER_21, CheckScore = (dealerScore, playerscore) => dealerScore > 21 },
                new Rules() { RuleFor = UserType.DEALER, Message = (dealerScore, playerscore) => dealerScore > playerscore ? StringConstants.DELAER_WINS : StringConstants.PLAYER_WINS, CheckScore = (dealerScore, playerscore) => dealerScore >= 17 && dealerScore <= 21 },
                new Rules() { RuleFor = UserType.PLAYER, Message = (dealerScore, playerscore) => StringConstants.DEALER_WIN_PLAYER_OVER_21, CheckScore = (dealerScore, playerscore) => dealerScore > 21 }
            };
        }

        //This will go through each rule and then run the score checker function each method has. This method will determine the player/dealer outcome based on the scores provided  
        //a false return means the game has been completed and a winner has been found
        public static bool ValidateGameActive(IUser _currentPlayer, int firstPlayerscore)
        {
            foreach (var rule in _rules)
            {
                if (rule.RuleFor == _currentPlayer.UserType && rule.CheckScore(_currentPlayer.TotalScore, firstPlayerscore))
                {
                    Console.WriteLine(rule.Message(_currentPlayer.TotalScore, firstPlayerscore));
                    return false;
                }
            }

            return true;
        }
    }
}
