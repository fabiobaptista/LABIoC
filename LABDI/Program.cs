using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Application;
using Ninject;
using Ninject.Modules;

namespace LABDI
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Ex. $deferred.call(ServiceApp)
            Console.WriteLine(new ServiceApp().GetMessage());
            Console.ReadKey();
        }
    }
}
