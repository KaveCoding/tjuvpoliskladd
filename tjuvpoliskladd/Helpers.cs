using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjuvpoliskladd
{
    internal class Helpers
    {
        internal static void Draw(string[,] drawing, int y_värde, int x_värde, string markör)
        {
           
            for (int row = 0; row < 25; row++)
            {
                for (int col = 0; col < 100; col++)
                {

                    if (row == y_värde && col == x_värde)
                    {
                        drawing[row, col] = markör;
                    }   
                }
            }
                for (int row = 0; row < 25; row++)
                {
                    for (int col = 0; col < 100; col++)
                {
                    if (drawing[row, col] == null)
                    {
                        drawing[row,col] = " ";
                    }
                    else
                    Console.Write(drawing[row, col]);
                }
                    Console.WriteLine();
                }
           
        }
    }
}
                
                
                
    