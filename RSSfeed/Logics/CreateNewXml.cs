using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logics
{
    public class newXml
    {

        public static void createNewXmlDefault()
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>default</name></item>");

            XmlTextWriter writer = new XmlTextWriter("pods.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
        }
        public static void createNewXmlCategory()
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>category</name></item>");

            XmlTextWriter writer = new XmlTextWriter("Category.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
        }
    }
}

