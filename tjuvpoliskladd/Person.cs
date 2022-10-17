using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjuvpoliskladd
{
    public class Person
    {
    
    }

    internal class Medborgare : Person
    {
        static Random random = new Random();
        public int X_värde = random.Next(0, 101);
        public int Y_värde = random.Next(0, 26);
        public List<string> tillhörigheter = new List<string>();
        public Medborgare()
        {
            tillhörigheter.Add("Nycklar");
            tillhörigheter.Add("Mobil");
            tillhörigheter.Add("Plånbok");
            tillhörigheter.Add("klocka");
        }
    }

    internal class Polis : Person
    {
        static Random random = new Random();
        public int X_värde = random.Next(0, 101);
        public int Y_värde = random.Next(0, 26);
        public List<string> stulet_gods = new List<string>();
        public Polis()
        {
            stulet_gods.Add(" tomt "); //placeholder
        }
    }
        internal class Tjuv : Person
        {
            static Random random = new Random();
            public int X_värde = random.Next(0, 101);
            public int Y_värde = random.Next(0, 26);
            public List<string> beslagtaget = new List<string>();
            public Tjuv()
            {
                beslagtaget.Add(" tomt "); //placeholder
            }
        }
    }

