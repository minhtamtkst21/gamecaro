using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    class Board
    {
    private char[,] Arr;
    private string P1, P2;
    public Board()
    {
        this.Arr = new char[20, 20];
        this.P1 = new string() {"Player 1"};
        this.P2 = new string() {"Player 2"};
    }

    }
}
