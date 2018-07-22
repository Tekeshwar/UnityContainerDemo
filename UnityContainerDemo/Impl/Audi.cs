using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerDemo.Contract;

namespace UnityContainerDemo.Impementation
{
    public class Audi:ICar 
    {
        public string Run()
        {
            return "Audi Running";
        }
    }
}
