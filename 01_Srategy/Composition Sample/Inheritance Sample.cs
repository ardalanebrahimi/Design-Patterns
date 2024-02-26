using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Srategy.Composition_Sample
{

    // Base class
    public class Car
    {
        protected string EngineType { get; set; }

        public Car(string engineType)
        {
            EngineType = engineType;
        }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle starting sequence initialized");
            IgniteEngine();
            CheckFuelLevel();
            PerformPreDriveChecks();
            Console.WriteLine("Vehicle started successfully");
        }

        protected virtual void IgniteEngine()
        {
            Console.WriteLine("Engine ignited");
        }

        protected virtual void CheckFuelLevel()
        {
            Console.WriteLine("Fuel level checked");
        }

        protected virtual void PerformPreDriveChecks()
        {
            Console.WriteLine("Pre-drive checks completed");
        }
    }

    // Electric Car class
    public class ElectricCar : Car
    {
        public ElectricCar() : base("Electric")
        {
        }

        protected override void IgniteEngine()
        {
            // No need to ignite engine for electric cars
        }

        protected override void CheckFuelLevel()
        {
            // Fuel level check is not applicable for electric cars
            Console.WriteLine("Fuel level not applicable for Electric Car");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating car instances
            Car myCar = new Car("Regular");
            ElectricCar myElectricCar = new ElectricCar();

            // Starting cars
            myCar.Start(); // Output: Vehicle starting sequence initialized
                           // Engine ignited
                           // Fuel level checked
                           // Pre-drive checks completed
                           // Vehicle started successfully

            myElectricCar.Start(); // Output: Vehicle starting sequence initialized
                                   // Fuel level not applicable for Electric Car
                                   // Pre-drive checks completed
                                   // Vehicle started successfully
        }
    }

}
