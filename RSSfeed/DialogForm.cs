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
    public partial class DialogForm : Form
    {
        Podcast podcast;
        PodcastList podcastList;
        
        private int intervalMS;


       

        public DialogForm(Podcast aPod, PodcastList aPodList)
        {
            InitializeComponent();
            podcastList = aPodList;
            podcast = aPod;
            load();
            
        }

        public void setHeader(string name)
        {
            lblTitle.Text = name;
        }

        private void load()
        {

            CategoryList categoryList = XmlCommunication.loadCategory();
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
            
            XmlCommunication.SaveListData(podcastList.GetPodcastList(), "Podcasts.xml");


        }

        private void numericUpdateFrequency_ValueChanged(object sender, EventArgs e)
        {
            int outcome = (int)numericUpdateFrequency.Value;
            intervalMS = TimeConverter.hourToMS(outcome);
        }
    }
}
