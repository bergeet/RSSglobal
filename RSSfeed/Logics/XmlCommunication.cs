using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Logics
{
    public class XmlCommunication
    {

        public static void load(PodcastList input)
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error

            var xmlDoc = XDocument.Load("Podcasts.xml");

            var podcasts = xmlDoc.Descendants("Podcast");

            //För varje entry så skapas ett nytt podcast-objekt i minnet som vi kan använda
            var podObj = podcasts.Select(element => new Podcast
            {
                Url = element.Descendants("Url").Single().Value,
                Name = element.Descendants("Name").Single().Value,
                Category = element.Descendants("Category").Single().Value,
                Interval = int.Parse(element.Descendants("Interval").Single().Value)
            });

            foreach (var aPod in podObj)
            {
                input.AddPod(aPod);
            }
        }

        public static void loadPodcasts(PodcastList input)
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error
           
            var xmlDoc = XDocument.Load("Podcasts.xml");
            
            var podcasts = xmlDoc.Descendants("Podcast");

            //För varje entry så skapas ett nytt podcast-objekt i minnet som vi kan använda
            var podObj = podcasts.Select(element => new Podcast
            {
                Url = element.Descendants("Url").Single().Value,
                Name = element.Descendants("Name").Single().Value,
                Category = element.Descendants("Category").Single().Value,
                Interval = int.Parse(element.Descendants("Interval").Single().Value)
            });

            foreach (var aPod in podObj)
            {
                input.AddPod(aPod);
            }
        }

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
