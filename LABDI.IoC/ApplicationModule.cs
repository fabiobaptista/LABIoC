using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace LABDI.IoC
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<ServiceApp>().To<ServiceApp>();
        }
    }
}
