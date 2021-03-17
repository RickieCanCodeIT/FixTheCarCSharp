using System;

namespace FixTheCar
{
    class Program
    {
        private static Vehicle motorcycle;
        private static Vehicle unicycle;
        private static Vehicle redVehicle;
        private static Vehicle blueVehicle;
        static void Main(string[] args)
        {
            motorcycle = new Vehicle(2, 4f, 20, "Motorcycle");
            unicycle = new Vehicle(1, 3f, 20, "Unicycle");
            redVehicle = new Vehicle(4, 5f, 20, "Red Car");
            while (motorcycle.CanMove())
            {
                motorcycle.Move();
            }
            while (unicycle.CanMove())
            {
                unicycle.Move();
            }
            while (redVehicle.CanMove())
            {
                redVehicle.Move();
            }
            while (blueVehicle.CanMove())
            {
                blueVehicle.Move();
            }

        }
    }
}
