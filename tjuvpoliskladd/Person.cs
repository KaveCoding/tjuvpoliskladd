using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tjuvpoliskladd
{
    internal class Person
    {
        public int[] koordinater = new int[2];
        public List<string> inventory = new List<string>();
        public string markör = "";

        public Person()
        {
            Random random = new Random();
            koordinater = new int[2];
            koordinater[0] = random.Next(0, 26); //y värde
            koordinater[1] = random.Next(0, 100); //x värde
            markör = "";

        }

    }

    internal class Medborgare : Person
    {
        public Medborgare()
        {
            inventory.Add("Nycklar");
            inventory.Add("Mobil");
            inventory.Add("Plånbok");
            inventory.Add("klocka");
            markör = "M";
            

    }
    }

    internal class Polis : Person
    {

        public Polis()
        {
            markör = "P";
        }
    }

        internal class Tjuv : Person
        {
            public Tjuv()
            {
            markör = "T";
        }
        }
    }

