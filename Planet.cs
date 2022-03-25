using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Planet
    {
        public string name;

        public Planet()
        {
            name = null;
        }

        public Planet(string name)
        {
            this.name = name;
            if (name.Length == 0)
            {
                throw new System.ArgumentException("Your planet must have a name.");
            }
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
