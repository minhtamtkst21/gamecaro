using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    class Board
    {
        public string[,] Arr;
        private int player=1;
        private int i=0;
         public Board()
        {
            this.Arr = new string[20,20];
        }
         public void PrintGame()
         {
             for (i = 0; i < 20; i++)
             {
                 Arr[i, 0] = i + "";
                 Arr[0, i] = i + "";
             }
                 for (int row = 0; row < 20; row++) //hang
                 {
                     for (int column = 0; column < 20; column++) //cot
                     {
                         if (column == 0 || row == 0)
                         {
                             Console.Write(Arr[column, row] + " ");
                         }
                         else
                             if (Arr[column, row] == "x" || Arr[column, row] == "o")
                             {
                                 Console.Write(Arr[column, row] + " ");
                             }
                         else
                             if(column<10)
                         {
                             Console.Write("  ");
                         }
                             else
                             {
                                 Console.Write("   ");
                             }
                     }
                     Console.WriteLine();
                 }
         }
         public bool isGameOver()
         {
             int th1 = 0, th2 = 0, th3 = 0, th4 = 0;
             for (int column = 0; column < 15; column++) //hang
             {
                 for (int row = 0; row < 15; row++) //cot
                 {
                     if (Arr[row, column] == "x" || Arr[row,column]=="o")
                     {
                         for (int i = 1; i < 5; i++)
                         {
                             if (Arr[row + i, column] == Arr[row, column])
                             {
                                 th1++;

                             }
                             if (Arr[row, column+i] == Arr[row, column])
                             {
                                 th2++;
                             }
                             if (Arr[row + i, column+i] == Arr[row, column])
                             {
                                 th3++;
                             }
                             if (column > 4)
                             {
                                 if (Arr[row +i, column-i] == Arr[row, column])
                                 {
                                     th4++;
                                 }
                             }
                         }
                         if (th1 == 4 || th2 == 4 || th3 == 4 || th4 == 4)
                         {
                             return true;
                         }
                         th1 = 0;
                         th2 = 0;
                         th3 = 0;
                         th4 = 0;
                     }
                 }
             }
             return false;
         }
         public void InputChar(int column,int row)
         {
             if (player == 1)
             {
                 Arr[column, row] = "x";
                 player = 2;
             }
             else
             {
                 Arr[column, row] = "o";
                 player = 1;
             }
         }
    }
}
