using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataAccess
{


    public class Xml
    {
            public static void SaveListData(object obj, string filename)
        {
            var serializer = new XmlSerializer(obj.GetType());

            using (var stream = new StreamWriter(filename))
            {
                serializer.Serialize(stream, obj);
            }
        }
  
    }
}
