using BuilderPattern.Interfaces;
using BuilderPattern.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Builder pattern is useful for creating complex objects that have multiple parts. The creation process of an object should
            // be independent of these parts; in other words the consturction process does not care how these parts are assembled.
            // You should be able to use the same construction process to create different representations of the objects
            Console.WriteLine("Builder Pattern");

            Director director = new Director();

            IBuilder buildOne = new Car("Dodge");
            IBuilder buildTwo = new MotorCycle("Honda");

            director.Construct(buildOne);
            Product p = buildOne.GetVehicle();
            p.Show();

            Console.WriteLine("----------------");

            director.Construct(buildTwo);
            Product p2 = buildTwo.GetVehicle();
            p2.Show();

            Console.ReadLine();
        }
    }
}
