using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjuvpoliskladd
{
    internal class Helpers
    {
        public static List<Person> Generate(List<Person> persons, int antal_tjuvar, int antal_medborgare, int antal_poliser)
        {
            for (int i = 0; i < antal_tjuvar; i++)
            {
                persons.Add(new Tjuv());
            }

            for (int i = 0; i < antal_medborgare; i++)
            {
                persons.Add(new Medborgare());
            }

            for (int i = 0; i < antal_poliser; i++)
            {
                persons.Add(new Polis());
            }
            return persons;
        }

        internal static void Draw(string[,] drawing, int y_värde, int x_värde, string markör)
        {
            for (int row = 0; row < 25; row++)
            {
                for (int col = 0; col < 100; col++)
                {
                    
                    if (row == y_värde && col == x_värde)
                    {
                        if (drawing[row, col] != " ")
                            drawing[row, col] = drawing[row, col] + markör;

                        else
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

        public static void theft(int tjuv, int medborgare )
        {
            Console.Clear();
            Console.WriteLine("Tjuv " + tjuv + " har stulit från medborgare " + medborgare);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
                
                
                
    