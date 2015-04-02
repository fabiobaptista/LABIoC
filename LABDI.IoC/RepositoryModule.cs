using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Domain;
using LABDI.Repository;
using Ninject.Modules;

namespace LABDI.IoC
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRep>().To<RepImp>();
        }
    }
}
