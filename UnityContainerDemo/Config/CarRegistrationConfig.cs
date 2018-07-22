using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerDemo.Impementation;

namespace UnityContainerDemo.Config
{
    public class CarRegistrationConfig
    {
        public string Name { get; set; }
        public Type ImplType { get; set; }

        public static List<CarRegistrationConfig> DemoConfig()
        {
            List<CarRegistrationConfig> config = new List<CarRegistrationConfig>();
            config.Add(new CarRegistrationConfig() { Name = "Audi", ImplType = typeof(Audi) });
            config.Add(new CarRegistrationConfig() { Name = "Tesla", ImplType = typeof(Tesla) });
            config.Add(new CarRegistrationConfig() { Name = "BMW", ImplType = typeof(BMW) });
            config.Add(new CarRegistrationConfig() { Name = "Ford", ImplType = typeof(Ford) });
            return config;
        }
    }
}
