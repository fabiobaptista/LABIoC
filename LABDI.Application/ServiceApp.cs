using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Domain;
using LABDI.IoC;
using Ninject;
using Ninject.Modules;

namespace LABDI.Application
{
    public class ServiceApp
    {
        private Service _service;

        //1 - public ServiceApp (Service service)
        public ServiceApp()
	    {
            //1 - _service = service;

            //2 - Nesse ponto em uma aplicação Web/Api, "ServiceApp" poderia ser um controller 
            //e então "Service" será injetado diretamente
            var modules = new List<INinjectModule>
            {
                new DomainModule(),
                new RepositoryModule(),
                new ApplicationModule()
            };

            var kernel = new StandardKernel();

            kernel.Load(modules);

            _service = kernel.Get<Service>();
            /*2 - *********************************************/
	    }

        public string GetMessage()
        { 
            return _service.GetMessage();
        }
        
    }
}
