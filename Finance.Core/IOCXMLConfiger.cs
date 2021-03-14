using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace Finance.Core
{
    internal class IOCXMLConfiger:ConfigurationSection
    {
        private List<IOCElement> m_Element = new List<IOCElement>();
        public IOCXMLConfiger()
        {

        }
        public List<IOCElement> IOCElements
        {
            get
            {
                return m_Element;
            }
        }
        /// <summary>
        /// 反序列化Element节点 app.config文件里面的Element节点
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="serializeCollectionKey"></param>
        protected override void DeserializeElement(XmlReader reader,bool serializeCollectionKey)
        {
            var xmDoc = new XmlDocument();
            xmDoc.Load(reader);
            var element = xmDoc.GetElementsByTagName("element"); //通过标签名获取Element节点
            foreach(XmlNode node in element)
            {
                var elem = new IOCElement();
                if (node.Attributes["service"] != null)
                {
                    elem.Services = node.Attributes["service"].Value;
                }
                if (node.Attributes["copment"] != null)
                {
                    elem.Copments = node.Attributes["copment"].Value;
                }
                m_Element.Add(elem);
            }
            base.DeserializeElement(reader, serializeCollectionKey);
        }
    }
}
