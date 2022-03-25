using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Austin Kerr
 * CSCI 3005
 * Assignment 4
 * 10/16/2020
 */

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Austin Kerr's Lifeform Battle Simulation");
            Console.WriteLine("___________________________________________________");

            Spaceship spaceship = new Spaceship();
            spaceship.sname = "Ship";
            spaceship.capacity = 9999; //Max cap set well over assumed number of aliens added by user
            List<Alien> aliens = new List<Alien>();
            spaceship.aliens = aliens;
            BattlePlanContext Battles = new BattlePlanContext();

            int selection = 0;
            while (selection != 4)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1.Add good alien \n2.Add evil alien \n3.Display good alien damage to evil alien \n4.Quit");
                selection = int.Parse(Console.ReadLine());

                while ((selection < 1) || (selection > 4))
                {
                    Console.WriteLine("Invalid selection. Enter choice number:");
                    selection = int.Parse(Console.ReadLine());
                }

                if (selection == 1)
                {
                    int colorselect = 0;
                    Console.WriteLine("What color is your good alien?\n1.Red\n2.Blue\n3.Green");
                    colorselect = int.Parse(Console.ReadLine());
                    while ((colorselect < 1) || (colorselect > 4))
                    {
                        Console.WriteLine("Invalid selection. Enter choice number:");
                        colorselect = int.Parse(Console.ReadLine());
                    }
                    if (colorselect == 1)
                    {
                        BetaAlien betaalien = new BetaAlien();
                        betaalien.setAName();
                        betaalien.setAAge();
                        betaalien.aalign = true;
                        spaceship.addAlien(betaalien);
                    }
                    else if (colorselect == 2)
                    {
                        GammaAlien gammaalien = new GammaAlien();
                        gammaalien.setAName();
                        gammaalien.setAAge();
                        gammaalien.aalign = true;
                        spaceship.addAlien(gammaalien);
                    }
                    else if (colorselect == 3)
                    {
                        AlphaAlien alphaalien = new AlphaAlien();
                        alphaalien.setAName();
                        alphaalien.setAAge();
                        alphaalien.aalign = true;
                        spaceship.addAlien(alphaalien);
                    }
                }
                else if (selection == 2)
                {
                    int colorselect = 0;
                    Console.WriteLine("What color is your evil alien?\n1.Red\n2.Blue\n3.Green");
                    colorselect = int.Parse(Console.ReadLine());
                    while ((colorselect < 1) || (colorselect > 4))
                    {
                        Console.WriteLine("Invalid selection. Enter choice number:");
                        colorselect = int.Parse(Console.ReadLine());
                    }
                    if (colorselect == 1)
                    {
                        BetaAlien betaalien = new BetaAlien();
                        betaalien.setAName();
                        betaalien.setAAge();
                        betaalien.aalign = false;
                        spaceship.addAlien(betaalien);
                    }
                    else if (colorselect == 2)
                    {
                        GammaAlien gammaalien = new GammaAlien();
                        gammaalien.setAName();
                        gammaalien.setAAge();
                        gammaalien.aalign = false;
                        spaceship.addAlien(gammaalien);
                    }
                    else if (colorselect == 3)
                    {
                        AlphaAlien alphaalien = new AlphaAlien();
                        alphaalien.setAName();
                        alphaalien.setAAge();
                        alphaalien.aalign = false;
                        spaceship.addAlien(alphaalien);
                    }
                }
                else if (selection == 3)
                {
                    long damage = 0;

                    void Battle()
                    {
                        foreach (Alien a in spaceship.aliens)
                        {
                            foreach (Alien b in spaceship.aliens)
                            {
                                foreach (IBattlePlan c in Battles.Plans)
                                {
                                    if (c.MatchesPlan(a, b))
                                    {
                                        damage = c.ComputeDamage(a, b);
                                    }
                                }
                            }
                        }
                    }
                    Battle();
                    Console.WriteLine("The good alien did " + damage + " damage to the evil alien.");
                }
            }
        }
    }
}
