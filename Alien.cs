using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Alien
    {
        protected string aname;
        protected string acolor;
        protected long aage;
        public bool aalign;
        protected Planet aplanet;

        public Alien()
        {
            aname = "Unnamed";
            acolor = "No Color";
            aage = 0;
            aalign = false;
            aplanet = null;
        }

        public Alien(string aName, string aColor, long aAge, bool aAlign, Planet aPlanet)
        {
            this.aname = aName;
            this.acolor = aColor;
            this.aage = aAge;
            this.aalign = aAlign;
            this.aplanet = aPlanet;
        }

        public void setAName()
        {
            Console.WriteLine("What is the name of the alien?");
            aname = Console.ReadLine();
        }

        public string getAName()
        {
            return this.aname;
        }

        public void setAColor()
        {
            int color = 0;
            Console.WriteLine("What color is the alien?: \n1.red \n2.green \n3.blue");//loops until the user selects one of the 3 aproved colors
            color = int.Parse(Console.ReadLine());
            while ((color > 3) || (color < 1))
            {
                Console.WriteLine("You must put the number of the selection: \n1.red \n2.green \n3.blue \nPlease try again.");//1 = red, 2 = green, 3 = blue
                color = int.Parse(Console.ReadLine());
            }
            string color2 = "color error";
            if (color == 1)
            {
                color2 = "Red";
            }
            else if (color == 2)
            {
                color2 = "Green";
            }
            else if (color == 3)
            {
                color2 = "Blue";
            }
            acolor = color2;
        }

        public string getAColor()
        {
            return this.acolor;
        }

        public void setAAge()
        {
            Console.WriteLine("How old is your alien?");
            long aAge = 0;
            aAge = long.Parse(Console.ReadLine());
            while (aAge < 0)
            {
                Console.WriteLine("Age must be a positive value. Please try again.");
                aAge = long.Parse(Console.ReadLine());
            }
            aage = aAge;
        }

        public long getAAge()
        {
            return this.aage;
        }

        public void setAAlign()
        {
            bool aAlign = false;
            int input = 0;
            Console.WriteLine("Is your alien \n1.good \nor \n2.evil");
            input = int.Parse(Console.ReadLine());
            while ((input < 1) || (input > 2))
            {
                Console.WriteLine("They must be \n1.good \nor \n2.evil");
                Console.WriteLine("Enter a new input:");
                input = int.Parse(Console.ReadLine());
            }
            if (input == 1)
            {
                aAlign = true;
            }
            else if (input == 2)
            {
                aAlign = false;
            }
            aalign = aAlign;
        }

        public bool getAAlign()
        {
            return this.aalign;
        }

        public void setPlanet(Planet aPlanet)
        {
            Console.WriteLine("Enter the name of the planet:");
            aPlanet.name = Console.ReadLine();
            aplanet = aPlanet;
        }
        public Planet getAPlanet()
        {
            return this.aplanet;
        }

        public string ToString()
        {
            string alignment;
            if (aalign == false)
            {
                alignment = "evil";
            }
            else if (aalign == true)
            {
                alignment = "good";
            }
            else
            {
                alignment = "morals-error";
            }
            string tempstring = aname + " - " + acolor + " - age: " + aage + " - " + alignment + " - " + aplanet.name;
            return tempstring;
        }
    }
}
