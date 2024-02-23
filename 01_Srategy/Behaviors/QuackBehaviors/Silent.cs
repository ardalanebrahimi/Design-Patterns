using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Srategy.Behaviors.QuackBehaviors
{
    public class Silent : QuackBehavior
    {
        public string Run() => "I make no sound!";
    }
}
