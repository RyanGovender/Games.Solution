using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Blackjack.Utilities
{
    class Utilities
    {
        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            return input.ToLower();
        }
    }
}
