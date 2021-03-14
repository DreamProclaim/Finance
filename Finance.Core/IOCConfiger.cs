using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Finance.Core
{
    public class IOCConfiger<T>
    {
        IOCElement element = new IOCElement();
        public IOCElement IOCCon(string ServiceName)
        {
            //添加 json 文件路径
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Configer.json");
            //创建配置根对象
            var configurationRoot = builder.Build();
            //取配置根下的 name 部分
            //var Services = configurationRoot.GetSection("IOC").GetSection(t.GetType().ToString()).GetSection("Service");
            //var Copments = configurationRoot.GetSection("IOC").GetSection(t.GetType().ToString()).GetSection("Copment");
            //element.Services = Services.Value;
            //element.Copments = Copments.Value;
            return element;
        }
    }
    public class IOCElement
    {
        public string Services { set; get; }
        public string Copments { set; get; }
    }
}
