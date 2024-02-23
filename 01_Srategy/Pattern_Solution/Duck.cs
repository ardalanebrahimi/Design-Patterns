using _01_Srategy.Behaviors.FlyBehaviors;
using _01_Srategy.Behaviors.QuackBehaviors;

namespace _01_Srategy.Pattern_Solution
{
    public class Duck
    {
        public FlyBehavior FlyBehavior { get; set; }

        public QuackBehavior QuackBehavior { get; set; }
        public string Swim() => "I am Swimming";

        public virtual string Display() => "I am Duck";
    }
}
