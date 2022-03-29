using System;

namespace Task1 { 
    class Program
    {
        static void Main(string[] args)
        {

            Car bus = new Bus("Mercedes","S-class","blue",220,60);
            bus.Info();
            Car car = new Car("Porsche","Cayenne","black",250);
            car.Info();
            
        }
    }
}
