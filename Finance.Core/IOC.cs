using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core
{
    public class Ioc
    {
        public T GetService<T>(T t)where T : class
        {
            return CreateComentInstance<T>(t);
        }
        public T CreateComentInstance<T>(T t)where T : class
        {
            IOCConfiger<T> configer = new IOCConfiger<T>();
            configer.IOCCon(t);
        }
    }
}
