namespace RSSfeed
{
    partial class RenameCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblChangeCategory = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.rbAddNew = new System.Windows.Forms.RadioButton();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblChangeCategory
            // 
            this.lblChangeCategory.AutoSize = true;
            this.lblChangeCategory.Location = new System.Drawing.Point(12, 19);
            this.lblChangeCategory.Name = "lblChangeCategory";
            this.lblChangeCategory.Size = new System.Drawing.Size(99, 17);
            this.lblChangeCategory.TabIndex = 3;
            this.lblChangeCategory.Text = "Ändra befintlig";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(15, 40);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(143, 24);
            this.cbCategories.TabIndex = 4;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(12, 84);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(107, 17);
            this.lblNewName.TabIndex = 5;
            this.lblNewName.Text = "Ange nytt namn";
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Location = new System.Drawing.Point(15, 155);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(122, 21);
            this.rbChange.TabIndex = 6;
            this.rbChange.TabStop = true;
            this.rbChange.Text = "Ändra kategori";
            this.rbChange.UseVisualStyleBackColor = true;
            // 
            // rbAddNew
            // 
            this.rbAddNew.AutoSize = true;
            this.rbAddNew.Location = new System.Drawing.Point(15, 182);
            this.rbAddNew.Name = "rbAddNew";
            this.rbAddNew.Size = new System.Drawing.Size(152, 21);
            this.rbAddNew.TabIndex = 7;
            this.rbAddNew.TabStop = true;
            this.rbAddNew.Text = "Lägg till ny kategori";
            this.rbAddNew.UseVisualStyleBackColor = true;
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Location = new System.Drawing.Point(15, 209);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(130, 21);
            this.rbRemove.TabIndex = 8;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "Ta bort kategori";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // RenameCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 297);
            this.Controls.Add(this.rbRemove);
            this.Controls.Add(this.rbAddNew);
            this.Controls.Add(this.rbChange);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lblChangeCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSubmit);
            this.Name = "RenameCategoryForm";
            this.Text = "AddCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblChangeCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Windows.Forms.RadioButton rbAddNew;
        private System.Windows.Forms.RadioButton rbRemove;
    }
}