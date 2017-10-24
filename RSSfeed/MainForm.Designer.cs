﻿namespace RSSfeed
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
            this.btnShowMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxPods
            // 
            this.lstBoxPods.FormattingEnabled = true;
            this.lstBoxPods.ItemHeight = 16;
            this.lstBoxPods.Location = new System.Drawing.Point(360, 64);
            this.lstBoxPods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxPods.Name = "lstBoxPods";
            this.lstBoxPods.Size = new System.Drawing.Size(357, 388);
            this.lstBoxPods.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(355, 9);
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
            this.txtAddPod.Location = new System.Drawing.Point(15, 30);
            this.txtAddPod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddPod.Name = "txtAddPod";
            this.txtAddPod.Size = new System.Drawing.Size(201, 22);
            this.txtAddPod.TabIndex = 3;
            this.txtAddPod.Text = "Ange url";
            this.txtAddPod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddPod_MouseClick);
            // 
            // btnAddPod
            // 
            this.btnAddPod.Location = new System.Drawing.Point(12, 238);
            this.btnAddPod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(75, 23);
            this.btnAddPod.TabIndex = 4;
            this.btnAddPod.Text = "Submit";
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.btnAddPod_Click);
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
            this.numericUpdateFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpdateFrequency.Name = "numericUpdateFrequency";
            this.numericUpdateFrequency.Size = new System.Drawing.Size(48, 22);
            this.numericUpdateFrequency.TabIndex = 8;
            this.numericUpdateFrequency.ValueChanged += new System.EventHandler(this.numericUpdateFrequency_ValueChanged);
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
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(201, 22);
            this.txtEnterName.TabIndex = 10;
            this.txtEnterName.Text = "Ange namn";
            this.txtEnterName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnterName_MouseClick);
            // 
            // lblEnterCategory
            // 
            this.lblEnterCategory.AutoSize = true;
            this.lblEnterCategory.Location = new System.Drawing.Point(12, 178);
            this.lblEnterCategory.Name = "lblEnterCategory";
            this.lblEnterCategory.Size = new System.Drawing.Size(96, 17);
            this.lblEnterCategory.TabIndex = 11;
            this.lblEnterCategory.Text = "Ange kategori";
            // 
            // cbNewCategories
            // 
            this.cbNewCategories.FormattingEnabled = true;
            this.cbNewCategories.Location = new System.Drawing.Point(12, 199);
            this.cbNewCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNewCategories.Name = "cbNewCategories";
            this.cbNewCategories.Size = new System.Drawing.Size(205, 24);
            this.cbNewCategories.TabIndex = 12;
            this.cbNewCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbNewCategories_MouseClick);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(223, 199);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(101, 23);
            this.btnNewCategory.TabIndex = 13;
            this.btnNewCategory.Text = "Konfigurera";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(357, 30);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 24);
            this.cbCategories.TabIndex = 14;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            this.cbCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCategories_MouseClick);
            // 
            // lblPods
            // 
            this.lblPods.AutoSize = true;
            this.lblPods.Location = new System.Drawing.Point(589, 11);
            this.lblPods.Name = "lblPods";
            this.lblPods.Size = new System.Drawing.Size(67, 17);
            this.lblPods.TabIndex = 15;
            this.lblPods.Text = "Välj podd";
            // 
            // cbPods
            // 
            this.cbPods.FormattingEnabled = true;
            this.cbPods.Location = new System.Drawing.Point(593, 31);
            this.cbPods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPods.Name = "cbPods";
            this.cbPods.Size = new System.Drawing.Size(121, 24);
            this.cbPods.TabIndex = 16;
            this.cbPods.SelectedIndexChanged += new System.EventHandler(this.cbPods_SelectedIndexChanged);
            // 
            // btnRemoveFeed
            // 
            this.btnRemoveFeed.Location = new System.Drawing.Point(596, 457);
            this.btnRemoveFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFeed.Name = "btnRemoveFeed";
            this.btnRemoveFeed.Size = new System.Drawing.Size(121, 28);
            this.btnRemoveFeed.TabIndex = 17;
            this.btnRemoveFeed.Text = "Ta bort podfeed";
            this.btnRemoveFeed.UseVisualStyleBackColor = true;
            this.btnRemoveFeed.Click += new System.EventHandler(this.btnRemoveFeed_Click);
            // 
            // btnConfigPodd
            // 
            this.btnConfigPodd.Location = new System.Drawing.Point(451, 457);
            this.btnConfigPodd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfigPodd.Name = "btnConfigPodd";
            this.btnConfigPodd.Size = new System.Drawing.Size(139, 28);
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
            this.button1.Location = new System.Drawing.Point(361, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "⏯";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(295, 377);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVolume.RightToLeftLayout = true;
            this.tbVolume.Size = new System.Drawing.Size(56, 103);
            this.tbVolume.TabIndex = 20;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVolume.Value = 100;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lblVolym
            // 
            this.lblVolym.AutoSize = true;
            this.lblVolym.Location = new System.Drawing.Point(291, 358);
            this.lblVolym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolym.Name = "lblVolym";
            this.lblVolym.Size = new System.Drawing.Size(46, 17);
            this.lblVolym.TabIndex = 21;
            this.lblVolym.Text = "Volym";
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(358, 502);
            this.lblStartStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(71, 17);
            this.lblStartStop.TabIndex = 22;
            this.lblStartStop.Text = "Start/Stop";
            // 
            // btnShowMore
            // 
            this.btnShowMore.Location = new System.Drawing.Point(566, 490);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(151, 25);
            this.btnShowMore.TabIndex = 23;
            this.btnShowMore.Text = "Visa mer om avsnitt";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 531);
            this.Controls.Add(this.btnShowMore);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnShowMore;
    }
}

