
using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RSSfeed
{
    internal partial class MainForm : Form
    {
        PodcastList podcastList = new PodcastList();
        CategoryList categoryList = new CategoryList();
        int intervalMS;

        public MainForm()
        {
            InitializeComponent();
            setCategoryListOnLoad();
            XmlCommunication.loadCategory(categoryList);
            XmlCommunication.loadPodcasts(podcastList);
        }

        private void setCategoryListOnLoad()
        {
            foreach (var item in cbNewCategories.Items)
            {
                categoryList.addCategoryToList(item.ToString());
                cbCategories.Items.Add(item.ToString());
            }
            XmlCommunication.SaveListData(categoryList.GetCategoryList(), "Category.xml");
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            var podUrl = txtAddPod.Text;
            var podName = txtEnterName.Text;
            var getCategory = (string)cbNewCategories.SelectedItem;

            
            podcastList.AddPod(podUrl, podName, intervalMS, getCategory); //Adderar podcasten till ett objekt sedan till en lista

            foreach (var item in cbNewCategories.Items)
            {
                categoryList.addCategoryToList(item.ToString());
            }
       
            XmlCommunication.SaveListData(podcastList.GetPodcastList(), "Podcasts.xml");
            fillCbCategories(); //Ändra staten av comboboxen kategori


        }

 
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpdateFrequency_ValueChanged(object sender, EventArgs e)
        {
            //Konverterar intervallen till rätt format för koden (milllisekund)
            int outcome = (int)numericUpdateFrequency.Value;
            intervalMS = TimeConverter.hourToMS(outcome);
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCbCategories();
        }

        private void cbPods_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxPods.Items.Clear();
            foreach (var podcast in podcastList.GetPodcastList())
            {
                foreach (var episode in podcast.GetEpisodes())
                {
                    if(podcast.Name == (string)cbPods.SelectedItem)
                    lstBoxPods.Items.Add(episode.AvsnittsTitel);
                }
              
                
            }
        }

        private void btnConfigPodd_Click(object sender, EventArgs e)
        {
            var selectedInput = (string)cbPods.SelectedItem;
            Podcast aPod = new Podcast();
            foreach (var entry in podcastList.GetPodcastList()) //loopar igenom podcasts som finns i minnet och 
                                                                //hämtar objektet som ska ändras
            {
                if(entry.Name == selectedInput)
                {
                    aPod = entry;
                }
                
            }
            //Skapar en ny dialogruta och matar in ett podcast objekt till konstruktorn
            //Som att köra in en bil till service där den ska målas om och få nytt regnummer
            DialogForm dialogForm = new DialogForm(aPod, podcastList);
            
            dialogForm.Show();
        }

        private void fillCbCategories()
        {
            cbPods.Items.Clear();
            foreach (Podcast podcast in podcastList.GetPodcastList())
            {
                if (podcast.Category == (string)cbCategories.SelectedItem)
                {
                    cbPods.Items.Add(podcast.Name);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = intervalMS;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            foreach (Podcast podcast in podcastList.GetPodcastList())
            {
                foreach (Episodes episode in podcast.GetEpisodes())
                {
                    if(episode.AvsnittsTitel == (string)lstBoxPods.SelectedItem)
                    {

                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                        wplayer.URL = episode.AvsnittsMediaUrl;
                        wplayer.controls.play();


                    }
                }
            }
            
        }
    }
}
