using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerDemo.Container;
using UnityContainerDemo.Factory;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCarname = "Ford";
            var car = new Driver(strCarname);
            Console.WriteLine(car.RunCar());
            Console.ReadLine();
        }
    }
}
