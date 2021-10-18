using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Cards.Enums.Enums;

namespace Common.Cards.Models
{
    public class Card
    {
        public string CardName { get; set; }
        public int CardValue { get; set; }
        public Suit Suit { get; set; }
    }
}
