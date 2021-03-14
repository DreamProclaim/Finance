using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Core.Characteristic;

namespace Finance.Core
{
    public class Ioc:BaseIOC
    {
        /// <summary>
        /// 生命周期分为 瞬时生命周期（默认）  单例生命周期（在一个进程中有且只有一个实例） 线程单例（每个线程是不同的实例同一个线程是同一个实例） 
        /// </summary>
        private Dictionary<string, Type> IOCDictionary = new Dictionary<string, Type>();

        public void RegisterType<T, M>() where T : M
        {
            this.IOCDictionary.Add(typeof(T).FullName, typeof(M));
        }

        public T Resolve<T>()
        {
            Type type = this.IOCDictionary[typeof(T).FullName];
            return (T)this.Resolve(type);
        }
        private object Resolve(Type type)
        {
            //选择构造函数  优先带标记的 ----然后优先参数个数最多的

            #region 选择构造函数
            var xtorArry = type.GetConstructors();  //获取全部构造函数
            var ctor = xtorArry.FirstOrDefault(o => o.IsDefined(typeof(InjectionCharacteristics), true)); //找出带特性的
            if (ctor == null)
            {
                ctor = xtorArry.OrderBy(c => c.GetParameters().Length).Last(); //GetParameters找出参数 找出参数最多的那个
            }
            #endregion

            #region 准备构造需要的参数
            List<object> paraList = new List<object>();
            foreach (var item in ctor.GetParameters())
            {
                var paraType = item.ParameterType; //参数的类型
                var paraTargetType = this.IOCDictionary[paraType.FullName];
                paraList.Add(this.Resolve(paraTargetType));
            }
            #endregion

            return Activator.CreateInstance(type, paraList.ToArray()); //表示调用无参数的构造函数
        }
    }
}
