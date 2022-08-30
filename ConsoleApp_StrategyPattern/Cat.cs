using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_StrategyPattern
{
    public class Cat : IAnnimalStrategy
    {
        public string WhoAmI()
        {
            return "I am a Cat";
        }
    }
}
