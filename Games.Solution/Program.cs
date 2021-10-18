
using Games.Blackjack.Interfaces;
using Games.Solution.Interfaces;
using System;


namespace Games.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame _game = new Domain.Blackjack();

            _game.PlayGame();

            Console.ReadKey();
        }
    }
}
