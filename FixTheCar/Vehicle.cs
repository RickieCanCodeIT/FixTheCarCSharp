using System;
using System.Collections.Generic;
using System.Text;

namespace FixTheCar
{
    class Vehicle
    {
        private int numberOfWheels;
        private double speed;
        private int fuel;
        private bool flatTire;
        private double distanceTravelled;
        private string name;
        public static Random random = new Random();

        public Vehicle(int numberOfWheels, double speed, int fuel, string name)
        {
            this.numberOfWheels = numberOfWheels;
            this.fuel = fuel;
            this.flatTire = false;
            this.name = name;
            this.distanceTravelled = 0;
        }

        public void Move()
        {
            fuel--;
            if (flatTire)
            {
                flatTire = false;
                Console.WriteLine(name + " has travelled " + distanceTravelled + " feet.");
            }
            else
            {
                distanceTravelled += speed;
                Console.WriteLine(name + " has travelled " + distanceTravelled + " feet.");
                for (int i = 1; i < numberOfWheels; i++)
                {
                    if (random.Next(12) == 0)
                    {
                        flatTire = true;
                        Console.WriteLine(name + " has a flat tire.");
                        break;
                    }
                }
            }
        }

        public bool CanMove()
        {
            if (fuel > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine(name + " is out of gas.");
                return false;
            }
        }
    }
}
