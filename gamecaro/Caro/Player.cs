using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    class Player
    {
        public Player(string name)
        {
            Console.Write("Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Column: ");
            int column = int.Parse(Console.ReadLine());
        }
    }
}
