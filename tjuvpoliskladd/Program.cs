using System;
using System.Security.Cryptography.X509Certificates;

namespace tjuvpoliskladd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlista = new List<Person>();
            personlista = Helpers.Generate(personlista, 2);
            while (true)
            {
                string[,] drawing = new string[25, 100];
                for (int i = 0; i < personlista.Count; i++)
                {
                    Console.Clear();
                    Helpers.Draw(drawing, personlista[i].koordinater[0], personlista[i].koordinater[1], personlista[i].markör);
                    
                   
                    switch (personlista[i].riktning)
                    {
                        case 1:
                            personlista[i].koordinater[0]--;
                            break; //812   Riktningarna
                                   //703
                                   //654
                        case 2:
                            {
                                personlista[i].koordinater[1]++;
                                personlista[i].koordinater[0]--;
                                break;
                            }
                        case 3:
                            {
                                personlista[i].koordinater[1]++;
                                break;
                            }
                        case 4:
                            {
                                personlista[i].koordinater[1]++;
                                personlista[i].koordinater[0]++;
                                break;
                            }
                        case 5:
                            {
                                personlista[i].koordinater[0]++;
                            }
                            break;
                        case 6:
                            {
                                personlista[i].koordinater[1]--;
                                personlista[i].koordinater[0]++;
                            }
                            break;
                        case 7:
                            {
                                personlista[i].koordinater[1]--;
                            }
                            break;
                        case 8:
                            {
                                personlista[i].koordinater[1]--;
                                personlista[i].koordinater[0]--;
                            }
                            break;
                    }

                        if (personlista[i].koordinater[0] > 24)
                            personlista[i].koordinater[0] = 0;

                        if (personlista[i].koordinater[0] < 0)
                            personlista[i].koordinater[0] = 25;

                        if (personlista[i].koordinater[1] > 99)
                            personlista[i].koordinater[1] = 0;

                        if (personlista[i].koordinater[1] < 0)
                            personlista[i].koordinater[1] = 99;
                }

                Console.ReadKey();
            }
        }
    }
}
        
