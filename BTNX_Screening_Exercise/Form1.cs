using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace BTNX_Screening_Exercise
{

    public partial class Form1 : Form
    {
        private MySqlConnection sqlConn;
        public Form1()
        {
            InitializeComponent();
        }


        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            this.cityListBox.DisplayMember = "city";
            sqlConn = new MySqlConnection("user id=survey;server=localhost;port=3306");
            try
            {
                sqlConn.Open();
                string query = "select distinct country from survey_location.worldcities order by country asc;";
                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader rdr = sqlCmd.ExecuteReader();
                while (rdr.Read())
                {
                    countryListBox.Items.Add(rdr[0], false);
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                label6.Text = "Cannot connect to server at this time. Please try again later";
            }
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            industryTextBox.Enabled = true;
            addIndustryButton.Enabled = true;
        }


        private void LocationListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (industryTextBox.Text != "")
                {
                    industryListBox.Items.Add(industryTextBox.Text, true);
                    industryTextBox.Clear();
                    industryTextBox.Enabled = false;
                    addIndustryButton.Enabled = false;
                }
            }
        }

        private void AddIndustryButton_Click(object sender, EventArgs e)
        {
            this.TextBox1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        private void AddKeywordButton_Click(object sender, EventArgs e)
        {
            this.KeywordTextBox_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int experienceLevel = this.comboBox1.SelectedIndex + 1;
            string query = "select UUID();";
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader rdr = sqlCmd.ExecuteReader();
                rdr.Read();
                string entryId = rdr[0].ToString();
                rdr.Close();
                query = "insert into btnx_screening.entry (entryId, experience) values (@entryId, @experience);";
                sqlCmd.CommandText = query;
                sqlCmd.Parameters.AddWithValue("@entryId", entryId);
                sqlCmd.Parameters.AddWithValue("@experience", experienceLevel);
                sqlCmd.ExecuteNonQuery();
                StringBuilder queryBuilder = new StringBuilder("insert into btnx_screening.industry (entryId, industry) values ");
                List<string> entryRows = new List<string>();
                foreach (object checkedItem in this.industryListBox.CheckedItems)
                {
                    entryRows.Add(string.Format("('{0}','{1}')", MySqlHelper.EscapeString(entryId), MySqlHelper.EscapeString(checkedItem.ToString())));
                }
                queryBuilder.Append(string.Join(",", entryRows));
                queryBuilder.Append(";");
                sqlCmd.CommandText = queryBuilder.ToString();
                sqlCmd.ExecuteNonQuery();
                entryRows.Clear();
                queryBuilder.Clear();
                queryBuilder.Append("insert into btnx_screening.keyword (entryId, keyword) values ");
                foreach (object checkedItem in this.skillsListBox.Items)
                {
                    entryRows.Add(string.Format("('{0}','{1}')", MySqlHelper.EscapeString(entryId), MySqlHelper.EscapeString(checkedItem.ToString())));
                }
                queryBuilder.Append(string.Join(",", entryRows));
                queryBuilder.Append(";");
                sqlCmd.CommandText = queryBuilder.ToString();
                sqlCmd.ExecuteNonQuery();
                queryBuilder.Clear();
                entryRows.Clear();
                queryBuilder.Append("insert into btnx_screening.location (entryId, city, country) values ");
                foreach (_location checkedItem in this.cityListBox.CheckedItems)
                {
                    entryRows.Add(string.Format("('{0}', '{1}', '{2}')", MySqlHelper.EscapeString(entryId), MySqlHelper.EscapeString(checkedItem.city), MySqlHelper.EscapeString(checkedItem.country)));
                }
                queryBuilder.Append(string.Join(",", entryRows));
                queryBuilder.Append(";");
                sqlCmd.CommandText = queryBuilder.ToString();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Form successfully submitted");
            }
            catch (Exception ex)
            {
                label6.Text = "Cannot connect to server at this time. Please try again later";
            }
        }

        private void KeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.keywordTextBox.Text != "")
            {
                string[] keywordList = this.keywordTextBox.Text.Split(',');
                foreach (string word in keywordList)
                {
                    this.skillsListBox.Items.Add(word);
                }
                this.keywordTextBox.Clear();
            }
        }

        private void CountryListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                this.cityListBox.Items.Clear();
                List<string> selectedCountries = new List<string>();
                List<string> parameters = new List<string>();
                string query = "select country, city_ascii from survey_location.worldcities where country in ({0}) order by city_ascii asc";
                foreach (object itemChecked in countryListBox.CheckedItems)
                {
                    selectedCountries.Add(itemChecked.ToString());
                }
                if (e.NewValue == CheckState.Checked)
                    selectedCountries.Add(countryListBox.Items[e.Index].ToString());
                else
                    selectedCountries.Remove(countryListBox.Items[e.Index].ToString());
                for (int i = 0; i < selectedCountries.Count; ++i)
                {
                    parameters.Add("@country" + i);
                }
                query = string.Format(query, string.Join(",", parameters));
                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                for (int i = 0; i < selectedCountries.Count; ++i)
                {
                    sqlCmd.Parameters.AddWithValue(parameters[i], selectedCountries[i]);
                }
                MySqlDataReader rdr = sqlCmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.cityListBox.Items.Add(new _location {country = rdr[0].ToString(), city = rdr[1].ToString() });
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                label6.Text = "Cannot connect to server at this time. Please try again later";
            }
        }

        private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
class _location
{
    public string country { get; set; }
    public string city { get; set; }
}