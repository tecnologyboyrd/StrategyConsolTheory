using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_StrategyPattern
{
    public class Context 
    {
        private IAnnimalStrategy _strategy;

        public IAnnimalStrategy Strategy 
        { set
            {
                _strategy = value;
            }
        }


        public Context(IAnnimalStrategy strategy)
        {
            _strategy = strategy;
            
        }

        public string WhoAmI()
        {
            Console.WriteLine(_strategy.WhoAmI());

            return _strategy.WhoAmI();
        }
    }
}
