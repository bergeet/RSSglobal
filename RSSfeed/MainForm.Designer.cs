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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolym = new System.Windows.Forms.Label();
            this.lblStartStop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxPods
            // 
            this.lstBoxPods.FormattingEnabled = true;
            this.lstBoxPods.Location = new System.Drawing.Point(270, 52);
            this.lstBoxPods.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxPods.Name = "lstBoxPods";
            this.lstBoxPods.Size = new System.Drawing.Size(269, 342);
            this.lstBoxPods.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(266, 7);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(46, 13);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Kategori";
            // 
            // lblAddPod
            // 
            this.lblAddPod.AutoSize = true;
            this.lblAddPod.Location = new System.Drawing.Point(9, 7);
            this.lblAddPod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPod.Name = "lblAddPod";
            this.lblAddPod.Size = new System.Drawing.Size(154, 13);
            this.lblAddPod.TabIndex = 2;
            this.lblAddPod.Text = "Lägg till ny podcast (RSS-URL)";
            // 
            // txtAddPod
            // 
            this.txtAddPod.Location = new System.Drawing.Point(11, 24);
            this.txtAddPod.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddPod.Name = "txtAddPod";
            this.txtAddPod.Size = new System.Drawing.Size(152, 20);
            this.txtAddPod.TabIndex = 3;
            this.txtAddPod.Text = "Ange url";
            this.txtAddPod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddPod_MouseClick);
            // 
            // btnAddPod
            // 
            this.btnAddPod.Location = new System.Drawing.Point(9, 193);
            this.btnAddPod.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(56, 19);
            this.btnAddPod.TabIndex = 4;
            this.btnAddPod.Text = "Submit";
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.btnAddPod_Click);
            // 
            // lblUpdateFrequency
            // 
            this.lblUpdateFrequency.AutoSize = true;
            this.lblUpdateFrequency.Location = new System.Drawing.Point(9, 52);
            this.lblUpdateFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateFrequency.Name = "lblUpdateFrequency";
            this.lblUpdateFrequency.Size = new System.Drawing.Size(181, 13);
            this.lblUpdateFrequency.TabIndex = 5;
            this.lblUpdateFrequency.Text = "Välj hur ofta podden ska uppdateras.";
            // 
            // lblUpdateFrequencyHour
            // 
            this.lblUpdateFrequencyHour.AutoSize = true;
            this.lblUpdateFrequencyHour.Location = new System.Drawing.Point(52, 70);
            this.lblUpdateFrequencyHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateFrequencyHour.Name = "lblUpdateFrequencyHour";
            this.lblUpdateFrequencyHour.Size = new System.Drawing.Size(40, 13);
            this.lblUpdateFrequencyHour.TabIndex = 7;
            this.lblUpdateFrequencyHour.Text = "timmar.";
            // 
            // numericUpdateFrequency
            // 
            this.numericUpdateFrequency.Location = new System.Drawing.Point(11, 68);
            this.numericUpdateFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpdateFrequency.Name = "numericUpdateFrequency";
            this.numericUpdateFrequency.Size = new System.Drawing.Size(36, 20);
            this.numericUpdateFrequency.TabIndex = 8;
            this.numericUpdateFrequency.ValueChanged += new System.EventHandler(this.numericUpdateFrequency_ValueChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(9, 96);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(90, 13);
            this.lblEnterName.TabIndex = 9;
            this.lblEnterName.Text = "Namnge ditt flöde";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(9, 112);
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(152, 20);
            this.txtEnterName.TabIndex = 10;
            this.txtEnterName.Text = "Ange namn";
            this.txtEnterName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnterName_MouseClick);
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Location = new System.Drawing.Point(9, 145);
            this.lblEnterCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(73, 13);
            this.lblEnterCategory.TabIndex = 11;
            this.lblEnterCategory.Text = "Ange kategori";
            // 
            // cbNewCategories
            // 
            this.cbNewCategories.FormattingEnabled = true;
            this.cbNewCategories.Items.AddRange(new object[] {
            "Sport",
            "Dokumentär",
            "Hälsa"});
            this.cbNewCategories.Location = new System.Drawing.Point(9, 162);
            this.cbNewCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cbNewCategories.Name = "cbNewCategories";
            this.cbNewCategories.Size = new System.Drawing.Size(155, 21);
            this.cbNewCategories.TabIndex = 12;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(167, 162);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(76, 19);
            this.btnNewCategory.TabIndex = 13;
            this.btnNewCategory.Text = "Ny kategori";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(268, 24);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(92, 21);
            this.cbCategories.TabIndex = 14;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // lblPods
            // 
            this.lblPods.AutoSize = true;
            this.lblPods.Location = new System.Drawing.Point(442, 9);
            this.lblPods.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPods.Name = "lblPods";
            this.lblPods.Size = new System.Drawing.Size(51, 13);
            this.lblPods.TabIndex = 15;
            this.lblPods.Text = "Välj podd";
            // 
            // cbPods
            // 
            this.cbPods.FormattingEnabled = true;
            this.cbPods.Location = new System.Drawing.Point(445, 25);
            this.cbPods.Margin = new System.Windows.Forms.Padding(2);
            this.cbPods.Name = "cbPods";
            this.cbPods.Size = new System.Drawing.Size(92, 21);
            this.cbPods.TabIndex = 16;
            this.cbPods.SelectedIndexChanged += new System.EventHandler(this.cbPods_SelectedIndexChanged);
            // 
            // btnRemoveFeed
            // 
            this.btnRemoveFeed.Location = new System.Drawing.Point(445, 396);
            this.btnRemoveFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFeed.Name = "btnRemoveFeed";
            this.btnRemoveFeed.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveFeed.TabIndex = 17;
            this.btnRemoveFeed.Text = "Ta bort podfeed";
            this.btnRemoveFeed.UseVisualStyleBackColor = true;
            this.btnRemoveFeed.Click += new System.EventHandler(this.btnRemoveFeed_Click);
            // 
            // btnConfigPodd
            // 
            this.btnConfigPodd.Location = new System.Drawing.Point(336, 396);
            this.btnConfigPodd.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigPodd.Name = "btnConfigPodd";
            this.btnConfigPodd.Size = new System.Drawing.Size(104, 23);
            this.btnConfigPodd.TabIndex = 18;
            this.btnConfigPodd.Text = "Konfigurera podd";
            this.btnConfigPodd.UseVisualStyleBackColor = true;
            this.btnConfigPodd.Click += new System.EventHandler(this.btnConfigPodd_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "⏯";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(221, 306);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(2);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVolume.RightToLeftLayout = true;
            this.tbVolume.Size = new System.Drawing.Size(45, 84);
            this.tbVolume.TabIndex = 20;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVolume.Value = 100;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lblVolym
            // 
            this.lblVolym.AutoSize = true;
            this.lblVolym.Location = new System.Drawing.Point(218, 291);
            this.lblVolym.Name = "lblVolym";
            this.lblVolym.Size = new System.Drawing.Size(35, 13);
            this.lblVolym.TabIndex = 21;
            this.lblVolym.Text = "Volym";
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(265, 433);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(56, 13);
            this.lblStartStop.TabIndex = 22;
            this.lblStartStop.Text = "Start/Stop";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.lblStartStop);
            this.Controls.Add(this.lblVolym);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "iRSS-LäsarN";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolym;
        private System.Windows.Forms.Label lblStartStop;
    }
}

