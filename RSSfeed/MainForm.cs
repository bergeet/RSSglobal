using DataAccess;
using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RSSfeed
{
    public partial class MainForm : Form
    {
        PodcastList podList = new PodcastList();

        public MainForm()
        {
            load();
            InitializeComponent();
        }
        
        public void load()
        {
            var xmlDoc = XDocument.Load("Podcasts.xml");
            var podcasts = xmlDoc.Descendants("Podcast");

            var podObj = podcasts.Select(element => new Podcast
            {
                Url = element.Descendants("Url").Single().Value,
                Name = element.Descendants("Name").Single().Value,
                Interval = int.Parse(element.Descendants("Interval").Single().Value)
            });

            foreach (var aPod in podObj)
            {
                podList.AddPod(aPod);
            }

        }


        private void btnAddPod_Click(object sender, EventArgs e)
        {
            var podUrl = txtAddPod.Text;
            var podName = txtEnterName.Text;

            podList.AddPod(podUrl, podName, 0);

            Xml.SaveListData(podList.GetPodcastList(), "Podcasts.xml");


        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            
        }
    }
}
