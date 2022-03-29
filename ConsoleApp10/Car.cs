using System;
using System.Collections.Generic;
using System.Text;

namespace Task1

{
    class Car
    {
        public string Brand;
        public string Model;
        public string Colour;
        public double MaxSpeed;

        public  Car()
        {
            Console.WriteLine("Car created.");
        }
        public Car(string brand, string model):this()
        {
            Brand = brand;
            Model = model;
        }
        public Car(string model, string brand, string colour, int maxspeed):this(model,brand)
        {
            Colour = colour;
            MaxSpeed = maxspeed;
        }
        public  virtual void  Info()
        {
            Console.WriteLine($"{Brand} {Model} {Colour} {MaxSpeed}");
        }
        
    }
}
