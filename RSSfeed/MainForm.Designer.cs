namespace RSSfeed
{
    partial class MainForm
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
            this.lstBoxPods = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblAddPod = new System.Windows.Forms.Label();
            this.txtAddPod = new System.Windows.Forms.TextBox();
            this.btnAddPod = new System.Windows.Forms.Button();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.lblUpdateFrequencyHour = new System.Windows.Forms.Label();
            this.numericUpdateFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterCategory = new System.Windows.Forms.Label();
            this.cbNewCategories = new System.Windows.Forms.ComboBox();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblPods = new System.Windows.Forms.Label();
            this.cbPods = new System.Windows.Forms.ComboBox();
            this.btnRemoveFeed = new System.Windows.Forms.Button();
            this.btnConfigPodd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxPods
            // 
            this.lstBoxPods.FormattingEnabled = true;
            this.lstBoxPods.ItemHeight = 16;
            this.lstBoxPods.Location = new System.Drawing.Point(357, 61);
            this.lstBoxPods.Name = "lstBoxPods";
            this.lstBoxPods.Size = new System.Drawing.Size(357, 420);
            this.lstBoxPods.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(354, 9);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(61, 17);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Kategori";
            // 
            // lblAddPod
            // 
            this.lblAddPod.AutoSize = true;
            this.lblAddPod.Location = new System.Drawing.Point(12, 9);
            this.lblAddPod.Name = "lblAddPod";
            this.lblAddPod.Size = new System.Drawing.Size(205, 17);
            this.lblAddPod.TabIndex = 2;
            this.lblAddPod.Text = "Lägg till ny podcast (RSS-URL)";
            // 
            // txtAddPod
            // 
            this.txtAddPod.Location = new System.Drawing.Point(15, 29);
            this.txtAddPod.Name = "txtAddPod";
            this.txtAddPod.Size = new System.Drawing.Size(202, 22);
            this.txtAddPod.TabIndex = 3;
            this.txtAddPod.Text = "Ange url";
            // 
            // btnAddPod
            // 
            this.btnAddPod.Location = new System.Drawing.Point(12, 230);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(75, 23);
            this.btnAddPod.TabIndex = 4;
            this.btnAddPod.Text = "Submit";
            this.btnAddPod.UseVisualStyleBackColor = true;
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Location = new System.Drawing.Point(12, 64);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(242, 17);
            this.lblUpdateFrequency.TabIndex = 5;
            this.lblUpdateFrequency.Text = "Välj hur ofta podden ska uppdateras.";
            // 
            // lblUpdateFrequencyHour
            // 
            this.lblUpdateFrequencyHour.AutoSize = true;
            this.lblUpdateFrequencyHour.Location = new System.Drawing.Point(69, 86);
            this.lblUpdateFrequencyHour.Name = "lblUpdateFrequencyHour";
            this.lblUpdateFrequencyHour.Size = new System.Drawing.Size(54, 17);
            this.lblUpdateFrequencyHour.TabIndex = 7;
            this.lblUpdateFrequencyHour.Text = "timmar.";
            // 
            // numericUpdateFrequency
            // 
            this.numericUpdateFrequency.Location = new System.Drawing.Point(15, 84);
            this.numericUpdateFrequency.Name = "numericUpdateFrequency";
            this.numericUpdateFrequency.Size = new System.Drawing.Size(48, 22);
            this.numericUpdateFrequency.TabIndex = 8;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(12, 118);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(119, 17);
            this.lblEnterName.TabIndex = 9;
            this.lblEnterName.Text = "Namnge ditt flöde";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(12, 138);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(202, 22);
            this.txtEnterName.TabIndex = 10;
            this.txtEnterName.Text = "Ange namn:";
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Location = new System.Drawing.Point(12, 179);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(96, 17);
            this.lblEnterCategory.TabIndex = 11;
            this.lblEnterCategory.Text = "Ange kategori";
            // 
            // cbNewCategories
            // 
            this.cbNewCategories.FormattingEnabled = true;
            this.cbNewCategories.Location = new System.Drawing.Point(12, 199);
            this.cbNewCategories.Name = "cbNewCategories";
            this.cbNewCategories.Size = new System.Drawing.Size(205, 24);
            this.cbNewCategories.TabIndex = 12;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(223, 200);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(102, 23);
            this.btnNewCategory.TabIndex = 13;
            this.btnNewCategory.Text = "Ny kategori";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(357, 30);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 24);
            this.cbCategories.TabIndex = 14;
            // 
            // lblPods
            // 
            this.lblPods.AutoSize = true;
            this.lblPods.Location = new System.Drawing.Point(590, 11);
            this.lblPods.Name = "lblPods";
            this.lblPods.Size = new System.Drawing.Size(67, 17);
            this.lblPods.TabIndex = 15;
            this.lblPods.Text = "Välj podd";
            // 
            // cbPods
            // 
            this.cbPods.FormattingEnabled = true;
            this.cbPods.Location = new System.Drawing.Point(593, 31);
            this.cbPods.Name = "cbPods";
            this.cbPods.Size = new System.Drawing.Size(121, 24);
            this.cbPods.TabIndex = 16;
            // 
            // btnRemoveFeed
            // 
            this.btnRemoveFeed.Location = new System.Drawing.Point(502, 487);
            this.btnRemoveFeed.Name = "btnRemoveFeed";
            this.btnRemoveFeed.Size = new System.Drawing.Size(121, 28);
            this.btnRemoveFeed.TabIndex = 17;
            this.btnRemoveFeed.Text = "Ta bort podfeed";
            this.btnRemoveFeed.UseVisualStyleBackColor = true;
            // 
            // btnConfigPodd
            // 
            this.btnConfigPodd.Location = new System.Drawing.Point(357, 487);
            this.btnConfigPodd.Name = "btnConfigPodd";
            this.btnConfigPodd.Size = new System.Drawing.Size(139, 28);
            this.btnConfigPodd.TabIndex = 18;
            this.btnConfigPodd.Text = "Konfigurera podd";
            this.btnConfigPodd.UseVisualStyleBackColor = true;
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 542);
            this.Controls.Add(this.btnConfigPodd);
            this.Controls.Add(this.btnRemoveFeed);
            this.Controls.Add(this.cbPods);
            this.Controls.Add(this.lblPods);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.cbNewCategories);
            this.Controls.Add(this.lblEnterCategory);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.numericUpdateFrequency);
            this.Controls.Add(this.lblUpdateFrequencyHour);
            this.Controls.Add(this.lblUpdateFrequency);
            this.Controls.Add(this.btnAddPod);
            this.Controls.Add(this.txtAddPod);
            this.Controls.Add(this.lblAddPod);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstBoxPods);
            this.Name = "Presentation";
            this.Text = "iRSS-LäsarN";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPods;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblAddPod;
        private System.Windows.Forms.TextBox txtAddPod;
        private System.Windows.Forms.Button btnAddPod;
        private System.Windows.Forms.Label lblUpdateFrequency;
        private System.Windows.Forms.Label lblUpdateFrequencyHour;
        private System.Windows.Forms.NumericUpDown numericUpdateFrequency;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterCategory;
        private System.Windows.Forms.ComboBox cbNewCategories;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblPods;
        private System.Windows.Forms.ComboBox cbPods;
        private System.Windows.Forms.Button btnRemoveFeed;
        private System.Windows.Forms.Button btnConfigPodd;
    }
}

