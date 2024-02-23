using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Behaviors.QuackBehaviors;

namespace _01_Srategy.Pattern_Solution
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyBehavior = new NoFly();
            this.QuackBehavior = new Silent();
        }
        public override string Display() => "I am Decoy Duck";
    }
}
