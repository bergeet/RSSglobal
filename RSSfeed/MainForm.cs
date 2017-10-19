﻿
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RSSfeed
{
    public partial class MainForm : Form
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
            }
            XmlCommunication.SaveListData(categoryList.GetCategoryList(), "Category.xml");
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            var podUrl = txtAddPod.Text;
            var podName = txtEnterName.Text;
            var getCategory = (string)cbNewCategories.SelectedItem;
            //var selectedInterval = numericUpdateFrequency.

            
            podcastList.AddPod(podUrl, podName, intervalMS, getCategory);
            //addObjToList(string name)

            foreach (var item in cbNewCategories.Items)
            {
                categoryList.addCategoryToList(item.ToString());
            }


           

            XmlCommunication.SaveListData(podcastList.GetPodcastList(), "Podcasts.xml");
            // Xml.SaveListData(categoryList.GetCategoryList(), "Podcasts.xml");


        }

 
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpdateFrequency_ValueChanged(object sender, EventArgs e)
        {
            int outcome = (int)numericUpdateFrequency.Value;
            intervalMS = TimeConverter.hourToMS(outcome);
        }
    }
}
