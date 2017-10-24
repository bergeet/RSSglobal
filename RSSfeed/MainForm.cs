
using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        FetchLists fetch = new FetchLists();
        int intervalMS;
        bool currentlyPlaying = false;
        bool podInitialized = false;
        string currentlyPlayingPod = "";
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public MainForm()
        {
            InitializeComponent();
            categoryList = XmlCommunication.LoadCategory();
            XmlCommunication.loadPodcasts(podcastList);
            setCategoryListOnLoad();

        }

        private void setCategoryListOnLoad()
        {
            foreach (var category in categoryList.GetCategoryList())
            {
                cbNewCategories.Items.Add(category.Name);
                cbCategories.Items.Add(category.Name);
            }

        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {

            var podUrl = txtAddPod.Text;
            var podName = txtEnterName.Text;
            var getCategory = (string)cbNewCategories.SelectedItem;
            int intervalValue = (int)numericUpdateFrequency.Value;
            try
            {

                Validation.checkIfEmpty(podUrl);
                Validation.checkIfNull(podUrl);
                Validation.checkIfEmpty(podName);
                Validation.checkIfEmpty(intervalValue);
                Validation.checkIfNull(getCategory);
                {
                    podcastList.AddPod(podUrl, podName, intervalMS, getCategory); //Adderar podcasten till ett objekt sedan till en lista

                    foreach (var item in cbNewCategories.Items)
                    {
                        categoryList.addCategoryToList(item.ToString());
                    }

                    XmlCommunication.SaveListData(podcastList.GetPodcastList(), "Podcasts.xml");
                    fillCbCategories(); //Ändra staten av comboboxen kategori
                    MessageBox.Show("Podden har nu lagts till! :)");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            RenameCategoryForm aForm = new RenameCategoryForm();
            aForm.ShowDialog();
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
            loadEpisodesToListBox();
        }

        private async void loadEpisodesToListBox()
        {
            Task<List<Episodes>> task = fetch.loadEpisodesTask((string)cbPods.SelectedItem);
 
            List<Episodes> x = await task;
            foreach (var episode in x)
            {
                lstBoxPods.Items.Add(episode.AvsnittsTitel);

            }


        }

        private void btnConfigPodd_Click(object sender, EventArgs e)
        {
            var selectedInput = (string)cbPods.SelectedItem;
            Podcast aPod = new Podcast();
            try
            {
                Validation.checkIfNull(selectedInput);
                foreach (var entry in podcastList.GetPodcastList()) //loopar igenom podcasts som finns i minnet och 
                                                                    //hämtar objektet som ska ändras
                {
                    if (entry.Name == selectedInput)
                    {
                        aPod = entry;
                    }

                }
                //Skapar en ny dialogruta och matar in ett podcast objekt till konstruktorn
                //Som att köra in en bil till service där den ska målas om och få nytt regnummer
                ModifyPodcastForm dialogForm = new ModifyPodcastForm(aPod, podcastList);

                dialogForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vänligen välj en pod att konfiguera");
            }

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
            Episodes anEpisode = null;

            foreach (Podcast podcast in podcastList.GetPodcastList())
            {
                if (currentlyPlayingPod != (string)lstBoxPods.SelectedItem)
                {
                    podInitialized = false;
                }
                if (!podInitialized)
                {
                    foreach (Episodes episode in podcast.GetEpisodes())
                    {
                        if (episode.AvsnittsTitel == (string)lstBoxPods.SelectedItem)
                        {
                            anEpisode = episode;
                            wplayer.URL = episode.AvsnittsMediaUrl;
                            currentlyPlayingPod = episode.AvsnittsTitel;
                            if (!currentlyPlaying)
                            {
                                podInitialized = true;
                                currentlyPlaying = true;
                                wplayer.controls.play();
                                break;
                            }
                            else
                            {
                                wplayer.controls.pause();
                                currentlyPlaying = false;
                                break;
                            }

                        }
                    }
                }
                else
                {
                    if (!currentlyPlaying)
                    {

                        wplayer.controls.play();
                        currentlyPlaying = true;
                        break;
                    }
                    else
                    {
                        wplayer.controls.pause();
                        currentlyPlaying = false;
                        break;
                    }
                }
            }

        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = tbVolume.Value;
        }

        private void txtAddPod_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddPod.Text = "";
        }

        private void txtEnterName_MouseClick(object sender, MouseEventArgs e)
        {
            txtEnterName.Text = "";
        }

        private void btnRemoveFeed_Click(object sender, EventArgs e)
        {

            var podFromCb = cbPods.SelectedIndex;
            podcastList.RemovePostcast(podFromCb);


        }


        private void btnShowMore_Click(object sender, EventArgs e)
        {
            String ettNamn = lstBoxPods.SelectedItem.ToString();
            String enUrl = null;

            foreach (var podcast in podcastList.GetPodcastList())
            {
                if (podcast.Name == (string)cbPods.SelectedItem)
                {
                    foreach (var episode in podcast.GetEpisodes())
                    {
                        if (episode.AvsnittsTitel.ToString() == ettNamn)
                        {
                            enUrl = episode.AvsnittsUrl;
                        }
                    }

                }


            }

            Process.Start(enUrl, enUrl);
        }

        private void loadCbCategories()
        {

            categoryList = XmlCommunication.LoadCategory();
            foreach (var item in categoryList.GetCategoryList())
            {

                cbNewCategories.Items.Add(item.Name);
            }
        }

        private void cbNewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCategoryCb();
        }

        internal void updateCategoryCb()
        {
            categoryList = XmlCommunication.LoadCategory();
            cbNewCategories.Items.Clear();
            foreach (var category in categoryList.GetCategoryList())
            {
                cbNewCategories.Items.Add(category.Name);
            }
        }

        private void cbNewCategories_MouseClick(object sender, MouseEventArgs e)
        {
            updateCategoryCb();
        }
    }
}
