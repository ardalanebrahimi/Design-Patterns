using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Behaviors.QuackBehaviors;

namespace _01_Srategy.Pattern_Solution
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyBehavior = new Flyable();
            this.QuackBehavior = new Quack();
        }
        public override string Display() => "I am Mallard Duck";
    }
}
