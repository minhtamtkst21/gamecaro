using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    class Player
    {
        private string name;
        public Player(string name)
        {
            this.name = name;
        }
        public void PlayGame(Board game)
        {
            Console.Write("Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Column: ");
            int column = int.Parse(Console.ReadLine());
            game.InputChar(column, row);
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
