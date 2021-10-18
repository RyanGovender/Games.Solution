using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.Interfaces
{
    public interface IUser
    {
        int TotalScore { get; set; }
        UserType UserType { get;}
    }
}
