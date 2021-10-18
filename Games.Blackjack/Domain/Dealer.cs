using Games.Blackjack.Interfaces;
using Games.Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Blackjack.Domain
{
    public class Dealer : IUser
    {
        public int TotalScore { get; set; }

        public Enums.Enums.UserType UserType => Enums.Enums.UserType.DEALER;
    }
}
