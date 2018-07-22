using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityContainerDemo.Config;
using UnityContainerDemo.Container;
using UnityContainerDemo.Contract;

namespace UnityContainerDemo.Factory
{
    public class CarFactory
    {

        private static IUnityContainer container = DefaultContainer.GetContainer();
        
        public static ICar Get(string name)
        {
            ICar instance = null;
            instance = container.Resolve<ICar>(name);
            return instance;
        }
    }
}
