using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace se307
{
    public partial class MainPage : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-8POO7R8;Initial Catalog=\"GTS 1.1\";Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load_1(object sender, EventArgs e)
        {
            LoadThesisInfo();
        }
        public void LoadThesisInfo()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Title, Abstract, Year, Type, Pages, Language, SubDate FROM Thesis";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string abstractText = reader["Abstract"].ToString();
                            int year = Convert.ToInt32(reader["Year"]);
                            string type = reader["Type"].ToString();
                            int pages;

                            if (int.TryParse(reader["Pages"].ToString(), out pages))
                            {
                                string language = reader["Language"].ToString();

                                DateTime subDate;
                                if (DateTime.TryParse(reader["SubDate"].ToString(), out subDate))
                                {
                                    thesisDisplay.AppendText($"Title: {title}\n");
                                    thesisDisplay.AppendText($"Abstract: {abstractText}\n");
                                    thesisDisplay.AppendText($"Year: {year}\n");
                                    thesisDisplay.AppendText($"Type: {type}\n");
                                    thesisDisplay.AppendText($"Pages: {pages}\n");
                                    thesisDisplay.AppendText($"Language: {language}\n");
                                    thesisDisplay.AppendText($"Submission Date: {subDate}\n\n");
                                }
                                else
                                {
                                    thesisDisplay.AppendText($"Title: {title}\n");
                                    thesisDisplay.AppendText($"Abstract: {abstractText}\n");
                                    thesisDisplay.AppendText($"Year: {year}\n");
                                    thesisDisplay.AppendText($"Type: {type}\n");
                                    thesisDisplay.AppendText($"Pages: {pages}\n");
                                    thesisDisplay.AppendText($"Language: {language}\n");
                                    thesisDisplay.AppendText($"Submission Date: Invalid date\n\n");
                                }
                            }
                            else
                            {

                                thesisDisplay.AppendText($"Title: {title}\n");
                                thesisDisplay.AppendText($"Abstract: {abstractText}\n");
                                thesisDisplay.AppendText($"Year: {year}\n");
                                thesisDisplay.AppendText($"Type: {type}\n");
                                thesisDisplay.AppendText($"Pages: Invalid value\n");
                                string language = reader["Language"].ToString();
                                thesisDisplay.AppendText($"Language: {language}\n");
                                thesisDisplay.AppendText($"Submission Date: Invalid date\n\n");
                            }
                        }

                    }
                }
            }
        }
        private void thesisDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (thesisDisplay.SelectedText.Length > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected thesis?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string selectedTitle = thesisDisplay.SelectedText.Split('\n')[0].Substring(7); 

                    DeleteThesis(selectedTitle);

                    LoadThesisInfo();
                }
            }
            else
            {
                MessageBox.Show("Please select a thesis to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteThesis(string title)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Thesis WHERE Title = @Title";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@Title", title);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thesis deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting thesis.");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ThesisSubmissionForm submissionForm = new ThesisSubmissionForm(this);
            submissionForm.ShowDialog(); 
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ThesisSearchForm searchForm = new ThesisSearchForm();
            searchForm.ShowDialog();
        }

        private void updateThesisBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
