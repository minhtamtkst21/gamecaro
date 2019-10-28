using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class Controller
    {

        private Player P1, P2;
        private Board game;
        public Controller()
        {
            game = new Board();
            this.P1 = new Player("Player 1");
            this.P2 = new Player("Player 2");
        }
        public void PlayGame()
        {
            game.PrintGame();
            while (true)
            {
                Console.WriteLine("{0} plays...", P1.GetName());
                P1.PlayGame(game);
                game.PrintGame();
                if (game.isGameOver())
                {
                    Console.WriteLine(P1.GetName() + " win");
                    break;
                }
                Console.WriteLine("{0} plays...", P2.GetName());
                P2.PlayGame(game);
                game.PrintGame();
                if (game.isGameOver())
                {
                    Console.WriteLine(P2.GetName() + " win");
                    break;
                }
            }
        }
    }
}
