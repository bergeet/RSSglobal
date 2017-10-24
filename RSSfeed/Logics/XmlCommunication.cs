using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace Logics
{
    public abstract class XmlCommunication
    {



        public static void LoadCategory(CategoryList input)
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error
            var xmlDoc = XDocument.Load("Category.xml");
            var category = xmlDoc.Descendants("Category");

            Validation.checkIfNull(xmlDoc);

            try
            {

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
                MessageBox.Show(e.Message);
            }

        }

        public static CategoryList LoadCategory()
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error
            CategoryList input = new CategoryList();
            var xmlDoc = XDocument.Load("Category.xml");
            var category = xmlDoc.Descendants("Category");

            Validation.checkIfNull(xmlDoc);
            try
            {

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

            catch (Exception)
            {
                MessageBox.Show("Xml-dokumentet hittades tyvärr inte, var snäll och start om programmet så skapas ett nytt :)");
                NewXml.createNewXmlCategory();
            }
            return input;
        }

        public static void loadPodcasts(PodcastList input)
        {
            //Laddar xml-filen
            //TODO: Om XMLfilen är tom så får man error


            try
            {
                var xmlDoc = XDocument.Load("pods.xml");
                var podcasts = xmlDoc.Descendants("Podcast");

                Validation.checkIfNull(xmlDoc);

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
            catch (Exception)
            {
                MessageBox.Show("Xml-dokumentet hittades tyvärr inte, var snäll och start om programmet så skapas ett nytt :)");
                NewXml.createNewXmlDefault();


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