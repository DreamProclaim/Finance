using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace Finance.Core.Autofac
{
    public class AutofacIOC
    {
        private static IContainer Container;
        public static void InitAutofac()
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("Json/Configer.json");
            var module = new ConfigurationModule(config.Build());
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            Container = builder.Build();
        }
        // <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return Container.Resolve<T>();
            //   return (T)DependencyResolver.Current.GetService(typeof(T));
        }

        public static T GetFromFac<T>(string name)
        {
            return Container.ResolveNamed<T>(name);
        }
    }
}
