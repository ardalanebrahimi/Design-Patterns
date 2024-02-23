using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Behaviors.QuackBehaviors;

namespace _01_Srategy.Pattern_Solution
{
    class ReubberDuck : Duck
    {
        public ReubberDuck()
        {
            this.FlyBehavior = new NoFly();
            this.QuackBehavior = new Squeak();
        }
        public override string Display() => "I am Reubber Duck";

    }
}
