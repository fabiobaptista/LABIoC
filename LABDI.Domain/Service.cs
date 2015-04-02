using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABDI.Domain
{
    public class Service
    {
        protected IRep _child { get; set; }

        public Service(IRep child)
        {
            _child = child;
        }

        public string GetMessage()
        {
            return _child.GetMessageContext();
        }
    }
}
