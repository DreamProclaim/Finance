using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Finance.UI.Helper
{
    /// <summary>
    /// 加密类
    /// </summary>
    public class Encryption
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns></returns>
        public string MD5Helper(string str)
        {
            MD5 mD5 = MD5.Create();

            //编码字节
            byte[] strburrer = Encoding.Default.GetBytes(str);

            //加密并返回字节数组
            strburrer = mD5.ComputeHash(strburrer);

            string strName = "";
            foreach (var item in strburrer)
            {
                strName = item.ToString("X2");
            }
            return strName;
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns></returns>
        public string SHA1Helper(string str)
        {
            SHA1 sHA1 = new SHA1CryptoServiceProvider();
            byte[] bytes = Encoding.Unicode.GetBytes(str);
            byte[] result = sHA1.ComputeHash(bytes);
            return BitConverter.ToString(result);
        }


    }
}
