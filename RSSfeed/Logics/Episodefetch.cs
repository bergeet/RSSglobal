using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    class Episodefetch
    {
        public void FetchEpsiodes(string url)
        {
            List<Episodes> episodeCollection = new List<Episodes>();

            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                var link = item.SelectSingleNode("link");

                Episodes ettAvsnitt = new Episodes(title.InnerText, link.InnerText);
                episodeCollection.Add(ettAvsnitt);
            }
        }
            
        

    }
}
