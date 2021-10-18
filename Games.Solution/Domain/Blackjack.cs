using Games.Blackjack.Interfaces;
using Games.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Solution.Domain
{
    public class Blackjack : IGame
    {
        private readonly IBlackjack _blackJack;
        public Blackjack()
        {
            _blackJack = new Games.Blackjack.Domain.Blackjack();
        }

        public void GameOver()
        {
            Console.WriteLine("Game Over Thanks for playing !");
        }

        public void PlayGame()
        {
            _blackJack.PlayGame();
        }
    }
}
