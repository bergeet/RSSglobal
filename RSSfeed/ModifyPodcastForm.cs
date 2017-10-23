using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSfeed
{
    internal partial class ModifyPodcastForm : Form
    {
        Podcast podcast;
        PodcastList podcastList;

        private int intervalMS;

        public ModifyPodcastForm(Podcast aPod, PodcastList aPodList)
        {
            InitializeComponent();
            podcastList = aPodList;
            podcast = aPod;
            load();
            setFields();


        }

        public void setFields()
        {
            lblTitle.Text = podcast.Name;
            txtNewName.Text = podcast.Name;
            txtNewUrl.Text = podcast.Url;

        }

        private void load()
        {

            CategoryList categoryList = XmlCommunication.LoadCategory();
            foreach (var item in categoryList.GetCategoryList())
            {

                cbCategories.Items.Add(item.Name);
            }
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            podcast.Name = txtNewName.Text;
            podcast.Url = txtNewUrl.Text;
            podcast.Category = (string)cbCategories.SelectedItem;
            podcast.Interval = intervalMS;
            try
            {
                Validation.checkIfEmpty(podcast.Interval);
                Validation.checkIfEmpty(podcast.Name);
                Validation.checkIfNull(podcast.Category);
                Validation.checkIfEmpty(podcast.Url);

                XmlCommunication.SaveListData(podcastList.GetPodcastList(), "Podcasts.xml");
                MessageBox.Show("Ändringen är nu klar! :)");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpdateFrequency_ValueChanged(object sender, EventArgs e)
        {
            int outcome = (int)numericUpdateFrequency.Value;
            intervalMS = TimeConverter.hourToMS(outcome);
        }
    }
}
