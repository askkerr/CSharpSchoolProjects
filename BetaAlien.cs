using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BetaAlien : Alien
    {
        public BetaAlien()
        {
            aname = "Unnamed";
            acolor = "Red";
            aage = 0;
            aalign = false;
        }
        public BetaAlien(string aName, long aAge, bool aAlign)
        {
            this.aname = aName;
            this.aage = aAge;
            this.aalign = aAlign;
            this.acolor = "Red";
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
            string tempstring = aname + " - " + acolor + " - age: " + aage + " - " + alignment + " - " + aplanet.name + " -  Beta Alien";
            return tempstring;
        }
    }
}
