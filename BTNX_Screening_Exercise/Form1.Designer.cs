namespace BTNX_Screening_Exercise
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.skillsListBox = new System.Windows.Forms.ListBox();
            this.industryListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countryListBox = new System.Windows.Forms.CheckedListBox();
            this.industryTextBox = new System.Windows.Forms.TextBox();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.addIndustryButton = new System.Windows.Forms.Button();
            this.addKeywordButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skillsListBox
            // 
            this.skillsListBox.FormattingEnabled = true;
            this.skillsListBox.Location = new System.Drawing.Point(127, 352);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.Size = new System.Drawing.Size(120, 95);
            this.skillsListBox.TabIndex = 1;
            this.skillsListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // industryListBox
            // 
            this.industryListBox.FormattingEnabled = true;
            this.industryListBox.Items.AddRange(new object[] {
            "Accounting",
            "Finance",
            "Software Engineering",
            "Software Development",
            "Embedded Development",
            "Risk Analysis",
            "Electrical Engineering",
            "Computer Engineering",
            "Construction",
            "Retail",
            "Management"});
            this.industryListBox.Location = new System.Drawing.Point(127, 69);
            this.industryListBox.Name = "industryListBox";
            this.industryListBox.Size = new System.Drawing.Size(120, 94);
            this.industryListBox.TabIndex = 2;
            this.industryListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please answer the following questions to complete our employment survey.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Experience Level";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 (Entry Level)",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10 (Most Senior)"});
            this.comboBox1.Location = new System.Drawing.Point(108, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Industry of Interest(s)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(254, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Industry";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Location Preference(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Keywords";
            // 
            // countryListBox
            // 
            this.countryListBox.FormattingEnabled = true;
            this.countryListBox.Location = new System.Drawing.Point(127, 200);
            this.countryListBox.Name = "countryListBox";
            this.countryListBox.Size = new System.Drawing.Size(120, 94);
            this.countryListBox.TabIndex = 11;
            this.countryListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CountryListBox_ItemCheck);
            this.countryListBox.SelectedIndexChanged += new System.EventHandler(this.LocationListBox2_SelectedIndexChanged);
            // 
            // industryTextBox
            // 
            this.industryTextBox.Enabled = false;
            this.industryTextBox.HideSelection = false;
            this.industryTextBox.Location = new System.Drawing.Point(257, 85);
            this.industryTextBox.Name = "industryTextBox";
            this.industryTextBox.Size = new System.Drawing.Size(100, 20);
            this.industryTextBox.TabIndex = 12;
            this.industryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(127, 323);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(100, 20);
            this.keywordTextBox.TabIndex = 13;
            this.keywordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeywordTextBox_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 493);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(405, 23);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // addIndustryButton
            // 
            this.addIndustryButton.Enabled = false;
            this.addIndustryButton.Location = new System.Drawing.Point(257, 112);
            this.addIndustryButton.Name = "addIndustryButton";
            this.addIndustryButton.Size = new System.Drawing.Size(75, 23);
            this.addIndustryButton.TabIndex = 16;
            this.addIndustryButton.Text = "Add";
            this.addIndustryButton.UseVisualStyleBackColor = true;
            this.addIndustryButton.Click += new System.EventHandler(this.AddIndustryButton_Click);
            // 
            // addKeywordButton
            // 
            this.addKeywordButton.Location = new System.Drawing.Point(233, 321);
            this.addKeywordButton.Name = "addKeywordButton";
            this.addKeywordButton.Size = new System.Drawing.Size(75, 23);
            this.addKeywordButton.TabIndex = 17;
            this.addKeywordButton.Text = "Add";
            this.addKeywordButton.UseVisualStyleBackColor = true;
            this.addKeywordButton.Click += new System.EventHandler(this.AddKeywordButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 18;
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.Location = new System.Drawing.Point(253, 200);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(120, 94);
            this.cityListBox.TabIndex = 19;
            this.cityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 528);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addKeywordButton);
            this.Controls.Add(this.addIndustryButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.industryTextBox);
            this.Controls.Add(this.countryListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.industryListBox);
            this.Controls.Add(this.skillsListBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BTNX_Screening_Exercise.Properties.Settings.Default, "test12", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "Form1";
            this.Text = global::BTNX_Screening_Exercise.Properties.Settings.Default.test12;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox skillsListBox;
        private System.Windows.Forms.CheckedListBox industryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox countryListBox;
        private System.Windows.Forms.TextBox industryTextBox;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button addIndustryButton;
        private System.Windows.Forms.Button addKeywordButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox cityListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

