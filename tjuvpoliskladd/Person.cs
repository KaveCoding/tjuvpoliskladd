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
        public int riktning = 0;
        public bool inJail = false;
        public Person()
        {
            Random random = new Random();
            koordinater = new int[2];
            koordinater[0] = random.Next(0,25); //y värde
            koordinater[1] = random.Next(0,100); //x värde
            riktning = random.Next(0, 10); 
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

