namespace RSSfeed
{
    partial class ModifyPodcastForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNewUrl = new System.Windows.Forms.Label();
            this.txtNewUrl = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblEnterCategory = new System.Windows.Forms.Label();
            this.numericUpdateFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblUpdateFrequencyHour = new System.Windows.Forms.Label();
            this.lblUpdateFrequency = new System.Windows.Forms.Label();
            this.btnAddPod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PLACEHOLDER";
            // 
            // lblNewUrl
            // 
            this.lblNewUrl.AutoSize = true;
            this.lblNewUrl.Location = new System.Drawing.Point(15, 60);
            this.lblNewUrl.Name = "lblNewUrl";
            this.lblNewUrl.Size = new System.Drawing.Size(125, 17);
            this.lblNewUrl.TabIndex = 2;
            this.lblNewUrl.Text = "Ange ny RSS-feed";
            // 
            // txtNewUrl
            // 
            this.txtNewUrl.Location = new System.Drawing.Point(18, 81);
            this.txtNewUrl.Name = "txtNewUrl";
            this.txtNewUrl.Size = new System.Drawing.Size(231, 22);
            this.txtNewUrl.TabIndex = 3;
            this.txtNewUrl.Text = "URL";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(15, 117);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(107, 17);
            this.lblNewName.TabIndex = 4;
            this.lblNewName.Text = "Ange nytt namn";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(18, 137);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(231, 22);
            this.txtNewName.TabIndex = 5;
            this.txtNewName.Text = "URL";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(18, 259);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(231, 24);
            this.cbCategories.TabIndex = 21;
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Location = new System.Drawing.Point(18, 239);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(96, 17);
            this.lblEnterCategory.TabIndex = 20;
            this.lblEnterCategory.Text = "Ange kategori";
            // 
            // numericUpdateFrequency
            // 
            this.numericUpdateFrequency.Location = new System.Drawing.Point(21, 196);
            this.numericUpdateFrequency.Name = "numericUpdateFrequency";
            this.numericUpdateFrequency.Size = new System.Drawing.Size(48, 22);
            this.numericUpdateFrequency.TabIndex = 17;
            this.numericUpdateFrequency.ValueChanged += new System.EventHandler(this.numericUpdateFrequency_ValueChanged);
            // 
            // lblUpdateFrequencyHour
            // 
            this.lblUpdateFrequencyHour.AutoSize = true;
            this.lblUpdateFrequencyHour.Location = new System.Drawing.Point(75, 198);
            this.lblUpdateFrequencyHour.Name = "lblUpdateFrequencyHour";
            this.lblUpdateFrequencyHour.Size = new System.Drawing.Size(54, 17);
            this.lblUpdateFrequencyHour.TabIndex = 16;
            this.lblUpdateFrequencyHour.Text = "timmar.";
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Location = new System.Drawing.Point(15, 176);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(242, 17);
            this.lblUpdateFrequency.TabIndex = 15;
            this.lblUpdateFrequency.Text = "Välj hur ofta podden ska uppdateras.";
            // 
            // btnAddPod
            // 
            this.btnAddPod.Location = new System.Drawing.Point(18, 301);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(75, 23);
            this.btnAddPod.TabIndex = 14;
            this.btnAddPod.Text = "Submit";
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.btnAddPod_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 342);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lblEnterCategory);
            this.Controls.Add(this.numericUpdateFrequency);
            this.Controls.Add(this.lblUpdateFrequencyHour);
            this.Controls.Add(this.lblUpdateFrequency);
            this.Controls.Add(this.btnAddPod);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewUrl);
            this.Controls.Add(this.lblNewUrl);
            this.Controls.Add(this.lblTitle);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewUrl;
        private System.Windows.Forms.TextBox txtNewUrl;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label lblEnterCategory;
        private System.Windows.Forms.NumericUpDown numericUpdateFrequency;
        private System.Windows.Forms.Label lblUpdateFrequencyHour;
        private System.Windows.Forms.Label lblUpdateFrequency;
        private System.Windows.Forms.Button btnAddPod;
    }
}