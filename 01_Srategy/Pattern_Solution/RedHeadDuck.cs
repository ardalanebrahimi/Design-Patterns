using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Behaviors.QuackBehaviors;

namespace _01_Srategy.Pattern_Solution
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            this.FlyBehavior = new Flyable();
            this.QuackBehavior = new Quack();
        }
        public override string Display() => "I am RedHead Duck";
    }
}
