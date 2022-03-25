using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Spaceship
    {
        public List<Alien> aliens;
        public string sname;
        public int capacity;

        public Spaceship()
        {
            sname = "Unnamed";
            capacity = 0;
            aliens = new List<Alien>();
        }
        public Spaceship(string sName, int Capacity, List<Alien> Aliens)
        {
            this.sname = sName;
            this.capacity = Capacity;
            this.aliens = Aliens;
        }

        public void addAlien(Alien Alien)
        {
            if (this.aliens.Count >= this.capacity)
            {
                Console.WriteLine("Maximum capacity reached. Additional aliens in this vessel may cause catastrophic destruction.");
            }
            else
                this.aliens.Add(Alien);
        }

        public void setSName()
        {
            Console.WriteLine("Please enter the name of your spaceship");
            this.sname = Console.ReadLine();
        }

        public string getSName()
        {
            return this.sname;
        }

        public Alien getOldest()
        {
            Alien oldest = this.aliens[0];
            for (int i = 0; i < this.aliens.Count; i++)
            {
                if (oldest.getAAge().CompareTo(this.aliens[i].getAAge()) < 0)
                {
                    oldest = aliens[i];
                }
            }
            return oldest;
        }

        public Alien getOldestColor()
        {
            Console.WriteLine("Look for the oldest alien from these colors(choose one): \n1.red \n2.green \n3.blue");
            int color = int.Parse(Console.ReadLine());
            while ((color < 1) || (color > 3))
            {
                Console.WriteLine("Invalid selection. Enter number of choice: \n1.red \n2.green \n3.blue");
                color = int.Parse(Console.ReadLine());
            }
            List<Alien> ColorAliens = new List<Alien>();
            for (int i = 0; i < this.aliens.Count; i++)
            {
                if (color == 1)
                {
                    if (this.aliens[i].getAColor() == "red")
                    {
                        ColorAliens.Add(this.aliens[i]);
                    }
                }
                else if (color == 2)
                {
                    if (aliens[i].getAColor() == "green")
                    {
                        ColorAliens.Add(this.aliens[i]);
                    }
                }
                else if (color == 3)
                {
                    if (aliens[i].getAColor() == "blue")
                    {
                        ColorAliens.Add(this.aliens[i]);
                    }
                }
            }
            if (ColorAliens.Count == 0)
            {
                return null;
            }
            else
            {
                Alien oldest = ColorAliens[0];
                for (int i = 0; i < ColorAliens.Count; i++)
                {
                    if (oldest.getAAge().CompareTo(ColorAliens[i].getAAge()) < 0)
                    {
                        oldest = ColorAliens[i];
                    }
                }
                return oldest;
            }
        }

        public void setCapacity()
        {
            Console.WriteLine("How many aliens can your spaceship hold?");
            capacity = int.Parse(Console.ReadLine());
        }

        public int Count()
        {
            return aliens.Count;
        }

        public int countGood()
        {
            List<Alien> GoodAliens = new List<Alien>();
            for (int i = 0; i < this.aliens.Count; i++)
            {
                if (this.aliens[i].getAAlign() == true)
                {
                    GoodAliens.Add(this.aliens[i]);
                }
            }
            return GoodAliens.Count();
        }

        public int countEvil()
        {
            List<Alien> EvilAliens = new List<Alien>();
            for (int i = 0; i < this.aliens.Count; i++)
            {
                if (this.aliens[i].getAAlign() == false)
                {
                    EvilAliens.Add(this.aliens[i]);
                }
            }
            return EvilAliens.Count();
        }

        public string ToString()
        {
            string tempstring = null;
            for (int i = 0; i > this.aliens.Count; i++)
            {
                tempstring += this.aliens[i].ToString() + "/n";
            }
            return tempstring;
        }

        public int countOverQuery(int query)
        {
            List<Alien> AliensOverQuery = new List<Alien>();
            for (int i = 0; i < this.aliens.Count; i++)
            {
                if (this.aliens[i].getAAge() >= query)
                {
                    AliensOverQuery.Add(this.aliens[i]);
                }
            }
            return AliensOverQuery.Count();
        }
    }
}