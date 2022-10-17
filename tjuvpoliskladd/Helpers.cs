using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjuvpoliskladd
{
    internal class Helpers
    {
     

        
        internal static void Draw(string[,] drawing, int y_värde, int x_värde)
        {
            string frame = "#";

            for (int top = 0; top < drawing.GetLength(1) + 2; top++)
            {
                Console.Write(frame);
            }
            Console.WriteLine();


            for (int row = 0; row < drawing.GetLength(0); row++)
            {
                Console.Write(frame);
                for (int col = 0; col < drawing.GetLength(1); col++)
                {
                    if (row == y_värde && col == x_värde)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(drawing[row, col] == null ? "P" : drawing[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(drawing[row, col] == null ? " " : drawing[row, col]);
                    }

                }
                Console.Write(frame);
                Console.WriteLine();
            }

            for (int bottom = 0; bottom < drawing.GetLength(1) + 2; bottom++)
            {
                Console.Write(frame);
            }
            Console.WriteLine();
        }
    }
}
