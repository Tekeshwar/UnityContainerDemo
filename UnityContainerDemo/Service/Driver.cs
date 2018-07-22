using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerDemo.Contract;

namespace UnityContainerDemo.Factory
{
    public class Driver
    {
        private ICar _obj = null;
        public Driver(string carName)
        {
            _obj = CarFactory.Get(carName);
        }
        public string RunCar()
        {
            return _obj.Run();
        }
    }
}
