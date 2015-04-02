using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Domain;
using Ninject.Modules;

namespace LABDI.IoC
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Service>().To<Service>();
        }
    }
}
