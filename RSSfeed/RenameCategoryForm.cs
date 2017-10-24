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
    public partial class RenameCategoryForm : Form
    {
        CategoryList categoryList = new CategoryList();
        public RenameCategoryForm()
        {
            InitializeComponent();
            load();
        }

        

        private void load()
        {

            categoryList = XmlCommunication.LoadCategory();
            foreach (var item in categoryList.GetCategoryList())
            {

                cbCategories.Items.Add(item.Name);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string checkedCategory = (string)cbCategories.SelectedItem;

            if (rbAddNew.Checked)
            {
                categoryList.addCategoryToList(txtName.Text);
                XmlCommunication.SaveListData(categoryList.GetCategoryList(), "Category.xml");

            }
            else if (rbChange.Checked)
            {
                
                foreach (var category in categoryList.GetCategoryList())
                {
                    if(category.Name == checkedCategory)
                    {
                        category.Name = txtName.Text;
                        XmlCommunication.SaveListData(categoryList.GetCategoryList(), "Category.xml");
                        
                    }
                }
            }
            else if(rbRemove.Checked)
            {
                categoryList.removeCategoryFromList(checkedCategory);
                XmlCommunication.RemoveEntryFromXml(checkedCategory);
                
                
            }
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
