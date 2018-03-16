
namespace Interface_Exercise
{
    using System;

    class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public int Wheel { get; set; }

        public double Speed { get; set; }

        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheel = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
