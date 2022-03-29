using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string model, string brand, string colour, int maxspeed,int passengercount)
            :base(model,brand,colour,maxspeed)
        {
            PassengerCount = passengercount;
        }
        public Bus()
        {
            Console.WriteLine("Bus created.");
        }
        public  override void Info()
        {
            Console.WriteLine($"{Brand} {Model} {Colour} {MaxSpeed} {PassengerCount}");

        }
        
    }
}
