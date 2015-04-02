using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Domain;

namespace LABDI.Repository
{
    public abstract class BaseRep<TContext> : IBaseRep where TContext : IContext
    {
        protected TContext _context;

        public BaseRep(TContext context)
        {
            _context = context;
        }

        public virtual string GetMessageContext()
        {
            return _context.Message();
        }
    }
}
