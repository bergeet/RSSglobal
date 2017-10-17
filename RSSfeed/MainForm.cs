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
        public MainForm()
        {
            InitializeComponent();
        }
        PodcastList podList = new PodcastList();

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            var podUrl = txtAddPod.Text;
            var podName = txtEnterName.Text;

            podList.AddPod(podUrl, podName, 0);

            Xml.SaveListData(podList.GetPodcastList(), "Podcasts.xml");

           /* List<object> podList = Xml.LoadListData(pods, "Podcasts.xml");
            foreach (var item in podList)
            {
                lstBoxPods.Items.Add(item);

            }*/



        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Xml.LoadXmlToList("Podcasts.xml", "Url");
        }
    }
}
