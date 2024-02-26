using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Srategy.Composition_Sample
{
    using System;

    // Engine interface
    public interface IEngine
    {
        string Type { get; }
        void Start();
        void CheckFuelLevel();
    }

    // Engine class
    public class Engine : IEngine
    {
        public virtual string Type => "Regular";

        public virtual void Start()
        {
            IgniteEngine();
            Console.WriteLine($"{Type} Engine started");
            CheckFuelLevel(); // Moved the fuel level check inside the Start method
        }

        protected virtual void IgniteEngine()
        {
            Console.WriteLine("Engine ignited");
        }

        public virtual void CheckFuelLevel()
        {
            Console.WriteLine("Fuel level checked");
        }
    }

    // Electric Engine class
    public class ElectricEngine : IEngine
    {
        public string Type => "Electric";

        public void Start()
        {
            Console.WriteLine($"{Type} Engine started");
        }

        public void CheckFuelLevel()
        {
            // For electric engine, fuel level check is not applicable
            Console.WriteLine("Fuel level not applicable for Electric Engine");
        }
    }

    // Car class using composition
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine; // Composition: Car has an Engine
        }

        public void Start()
        {
            Console.WriteLine("Vehicle starting sequence initialized");
            engine.Start(); // Delegates to engine class
            PerformPreDriveChecks();
            Console.WriteLine("Vehicle started successfully");
        }

        private void PerformPreDriveChecks()
        {
            Console.WriteLine("Pre-drive checks completed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Configuring the engine type
            IEngine myEngine = new Engine();
            IEngine myElectricEngine = new ElectricEngine();

            // Creating a Car instance with a configured engine
            Car myCar = new Car(myEngine);
            Car myElectricCar = new Car(myElectricEngine);

            myCar.Start(); // Output: Vehicle starting sequence initialized
                           // Engine ignited
                           // Regular Engine started
                           // Fuel level checked
                           // Pre-drive checks completed
                           // Vehicle started successfully

            myElectricCar.Start(); // Output: Vehicle starting sequence initialized
                                   // Electric Engine started
                                   // Fuel level not applicable for Electric Engine
                                   // Pre-drive checks completed
                                   // Vehicle started successfully
        }
    }

}
