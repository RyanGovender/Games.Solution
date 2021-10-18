using Games.Blackjack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.Domain
{
    public class Player : IUser
    {
        public int TotalScore { get; set; }
        public UserType UserType { get; } = UserType.PLAYER;
    }
}
