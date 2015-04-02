using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABDI.Domain;

namespace LABDI.Repository
{
    public class RepImp : BaseRep<Context>, IRep
    {
        public RepImp(Context context)
            : base(context)
        {
            _context = context;
        }

    }
}
