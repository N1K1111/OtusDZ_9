using System.IO;
using System;

namespace OtusDZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport() { Model = "NoName", MaxSpeed = 200 };
            var ts1 = transport.Clone();
            Console.WriteLine($"Type: {ts1.GetType().Name} Model: {ts1.Model} MaxSpeed: {ts1.MaxSpeed}");
            ts1.Move();

            Car car = new Car() {Model="Honda", MaxSpeed=250 };
            var car1 = car.Clone();
            Console.WriteLine($"Type: {car1.GetType().Name} Model: {car1.Model} MaxSpeed: {car1.MaxSpeed}");
            car1.OnRadio(true);
            car1.Move();

            Minivan minivan = new Minivan() { Model = "Craysler", MaxSpeed = 150 };
            Minivan mini1 = minivan.Clone();
            Console.WriteLine($"Type: {mini1.GetType().Name} Model: {mini1.Model} MaxSpeed: {mini1.MaxSpeed}");
            mini1.OnRadio(true);
            mini1.Move();

            Hatchback hatchback = new Hatchback() { Model = "Ford", MaxSpeed = 180 };
            var hatch = hatchback.Clone();
            Console.WriteLine($"Type: {hatch.GetType().Name} Model: {hatch.Model} MaxSpeed: {hatch.MaxSpeed}");
            hatch.OnRadio(true);
            hatch.Move();

        }
    }
}
