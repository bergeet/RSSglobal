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
    public abstract class XmlCommunication
    {



        public static void loadCategory(CategoryList input)
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error

            try
            {
               
                var xmlDoc = XDocument.Load("Category.xml");

                var category = xmlDoc.Descendants("Category");

                //För varje entry så skapas ett nytt podcast-objekt i minnet som vi kan använda
                var catagObj = category.Select(element => new Category
                {
                    Name = element.Descendants("Name").Single().Value,
                });

                foreach (var aCategory in catagObj)
                {
                    input.addCategoryToList(aCategory.ToString());
                }
            }

            catch (Exception e)
            {

                SaveListData(input, "Category.xml");
            }
            
        }

        public static CategoryList loadCategory()
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error
            CategoryList input = new CategoryList();
            try
            {

                var xmlDoc = XDocument.Load("Category.xml");

                var category = xmlDoc.Descendants("Category");

                //För varje entry så skapas ett nytt podcast-objekt i minnet som vi kan använda
                var catagObj = category.Select(element => new Category
                {
                    Name = element.Descendants("Name").Single().Value,
                });

                foreach (var aCategory in catagObj)
                {
                    input.addCategoryToList(aCategory.Name);
                }
               
            }

            catch (Exception e)
            {

                SaveListData(input, "Category.xml");
            }
            return input;
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
