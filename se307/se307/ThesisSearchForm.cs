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
    public partial class ThesisSearchForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-8POO7R8;Initial Catalog=\"GTS 1.1\";Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        private const string DefaultOrderBy = "Year DESC"; 
        public ThesisSearchForm()
        {
            InitializeComponent();
        }

        private void ThesisSearchForm_Load(object sender, EventArgs e)
        {
            typeBox2.Items.Add("Master");
            typeBox2.Items.Add("Doctorate");
            typeBox2.Items.Add("Specialization in Medicine");
            typeBox2.Items.Add("Proficiency in Art");
            typeBox2.Items.Add("Specialization in Dentistry");
            typeBox2.Items.Add("Minor Specialization in Medicine");
            typeBox2.Items.Add("Expertise in Pharmacy");

            searchInBox.Items.Add("Title");
            searchInBox.Items.Add("Author");
            searchInBox.Items.Add("Supervisor");
            searchInBox.Items.Add("Subject");
            searchInBox.Items.Add("Keyword");
            searchInBox.Items.Add("Abstract");
            searchInBox.Items.Add("ThesisNo");
            typeBox2.Items.Add("All");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typeBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enterTermBox.Text = string.Empty;
            yearBox.Text = string.Empty;
            typeBox2.SelectedIndex = -1;
            searchInBox.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void SearchInBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PerformSearch()
        {
            string searchTerm = enterTermBox.Text.Trim();
            string searchIn = searchInBox.Text.Trim();
            string searchType = typeBox2.Text;

            string query = "SELECT * FROM Thesis WHERE 1=1";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += $" AND (Title LIKE '%{searchTerm}%' OR Abstract LIKE '%{searchTerm}%')";
            }

            if (!string.IsNullOrEmpty(searchIn))
            {
                switch (searchIn)
                {
                    case "Title":
                        query += $" AND Title LIKE '%{searchTerm}%'";
                        break;
                    case "Author":
                        query += $" AND AuthorID IN (SELECT AuthorID FROM Author WHERE Name LIKE '%{searchTerm}%')";
                        break;
                    case "Supervisor":
                        query += $" AND SupervisorID IN (SELECT SupervisorID FROM ThesisSupervisor WHERE SupervisorID IN " +
                                 $"(SELECT SupervisorID FROM Supervisor WHERE Name LIKE '%{searchTerm}%'))";
                        break;
                    case "Subject":
                        query += $" AND SubTopicID IN (SELECT SubTopicID FROM ThesisSubjectTopic WHERE SubTopicID IN " +
                                 $"(SELECT SubTopicID FROM SubjectTopic WHERE Name LIKE '%{searchTerm}%'))";
                        break;
                    case "Keyword":
                        query += $" AND KeywordID IN (SELECT KeywordID FROM ThesisKeyword WHERE KeywordID IN " +
                                 $"(SELECT KeywordID FROM Keyword WHERE Name LIKE '%{searchTerm}%'))";
                        break;
                    case "Abstract":
                        query += $" AND Abstract LIKE '%{searchTerm}%'";
                        break;
                    case "ThesisNo":
                        query += $" AND ThesisNo = {searchTerm}";
                        break;
                    case "Year":
                        if (int.TryParse(searchTerm, out int year))
                        {
                            query += $" AND Year = {year}";
                        }
                        else
                        {
                            MessageBox.Show("Invalid year format. Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }
            }

            if (!string.IsNullOrEmpty(searchType) && searchType != "All")
            {
                query += $" AND Type = '{searchType}'";
            }

            query += $" ORDER BY {DefaultOrderBy}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void enterTermBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchInBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
