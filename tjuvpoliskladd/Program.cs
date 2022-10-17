using System;

namespace tjuvpoliskladd
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<Medborgare> medborgarlista = new List<Medborgare>();
                List<Polis> polislista = new List<Polis>();
                List<Tjuv> tjuvlista= new List<Tjuv>();


            for (int i = 0; i < 10; i++)
            {
                medborgarlista.Add(generera_medborgare());
                polislista.Add(generera_poliser());
                tjuvlista.Add(generera_tjuvar());
            }
                foreach (Medborgare medborgare in medborgarlista)
            {
                Console.WriteLine(medborgare.X_värde + " " + medborgare.Y_värde);
            }
                foreach (Polis polis in polislista)
            {
                Console.WriteLine(polis.X_värde + " " + polis.Y_värde);
            }
                foreach (Tjuv tjuv in tjuvlista)
            {
                Console.WriteLine(tjuv.X_värde + " " + tjuv.Y_värde);
            }

            static Medborgare generera_medborgare()
            {
                Medborgare nyMedborgare = new Medborgare();
                return nyMedborgare;
            }

            static Polis generera_poliser()
                {
                Polis nyPolis = new Polis();
                return nyPolis;
                }

            static Tjuv generera_tjuvar()
            {
                Tjuv nyTjuv= new Tjuv();
                return nyTjuv;
            }

            //while (true)
            //{
            //    Console.Clear();
            //    Helpers.Draw(drawing, y_värde, x_värde);
            //    Console.ReadKey();

            //    int randomnumber =  random.Next(1,9);
            //    switch (randomnumber)
            //    {
            //        case 1: y_värde--; 
            //            break; //812   Riktningarna
            //                   //703
            //                   //654
            //        case 2:
            //            {
            //                x_värde++; 
            //                y_värde--;
            //                break;
            //            }
            //        case 3:
            //            {
            //                x_värde++;
            //                break;
            //            }
            //        case 4:
            //            {
            //                x_värde++;
            //                y_värde++;
            //                break;
            //            }
            //        case 5:
            //            {
            //                y_värde++;
            //            }
            //            break;
            //        case 6:
            //            {
            //                x_värde--;
            //                y_värde++;
            //            }
            //            break;
            //        case 7:
            //            {
            //                x_värde--;
            //            }
            //            break;
            //        case 8:
            //            {
            //                x_värde--;
            //                y_värde--;
            //            }
            //            break;
            //    }
            //}
        }
        }
    }
