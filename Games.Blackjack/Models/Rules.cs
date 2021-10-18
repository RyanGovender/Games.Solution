using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Games.Blackjack.Enums.Enums;

namespace Games.Blackjack.Models
{
    public class Rules
    {
        public UserType RuleFor { get; set; }
        public bool Rule { get; set; }
        public Func<int,int,string> Message { get; set; }
        public Func<int,int,bool> CheckScore { get; set; }
    }
}
