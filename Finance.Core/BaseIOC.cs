using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core
{
    public interface BaseIOC
    {
        void RegisterType<T, M>() where T : M;
        T Resolve<T>();
    }
}
