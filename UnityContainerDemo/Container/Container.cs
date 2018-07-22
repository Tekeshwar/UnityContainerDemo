using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityContainerDemo.Config;
using UnityContainerDemo.Contract;
using UnityContainerDemo.Factory;
using UnityContainerDemo.Impementation;

namespace UnityContainerDemo.Container
{
   public static class DefaultContainer
    {
       private static IUnityContainer container = new UnityContainer();
       private static List<CarRegistrationConfig> carRegistrationConfig = CarRegistrationConfig.DemoConfig();
       private static bool isPrepared = false;
       public static IUnityContainer GetContainer()
       {
           if (!isPrepared)
           {
               Build();
           }

           return container;
       }

       private static void Build()
       {
           RegisterICar();

           isPrepared = true;
       }
       private static void RegisterICar()
       {
           foreach (var item in carRegistrationConfig)
           {
               container.RegisterType(typeof(ICar), item.ImplType, item.Name);
           }           
       }
    }
}
