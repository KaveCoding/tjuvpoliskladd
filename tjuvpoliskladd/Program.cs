using System;

namespace tjuvpoliskladd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlista = new List<Person>();
            
            for (int i = 0; i < 30; i++)
            {
                personlista.Add(generera_personer());
            }
            
            static Person generera_personer()
            {
                Random random = new Random();
                int randomnumber = random.Next(1, 4);
                switch (randomnumber)
                {
                    case 1:
                        Polis nyPolis = new Polis();
                        ;
                        return nyPolis;

                    case 2:
                        {
                            Tjuv nyTjuv = new Tjuv();
                            return nyTjuv;

                        }
                    case 3:
                        {
                            Medborgare nyMedborgare = new Medborgare();
                            return nyMedborgare;
                        }
                    default:
                        return null;
                        break;
                }
            }

            while (true)
            {
                string[,] drawing = new string[25, 100];
                for (int i = 0; i < personlista.Count; i++)
                {
                    Console.Clear();
                    Helpers.Draw(drawing, personlista[i].koordinater[0], personlista[i].koordinater[1], personlista[i].markör);
                    Random random = new Random();
                    int randomnumber = random.Next(1, 9);
                    
                    switch (randomnumber)
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
                    

                }

                Console.ReadKey();
            }
        }
    }
}
        
