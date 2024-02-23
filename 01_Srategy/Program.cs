using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Pattern_Solution;
using System;

namespace _01_Srategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new ReubberDuck();
            duck.FlyBehavior = new Flyable();
            Console.WriteLine(duck.FlyBehavior.Run());
            Console.WriteLine("Hello World!");
        }
    }
}
