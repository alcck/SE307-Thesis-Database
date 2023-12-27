using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace se307
{
    public partial class ThesisSubmissionForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-8POO7R8;Initial Catalog=\"GTS 1.1\";Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        private MainPage mainPage;

        public ThesisSubmissionForm(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage; 
        }
        private void ThesisSubmissionForm_Load(object sender, EventArgs e)
        {
            typeBox.Items.Add("Master");
            typeBox.Items.Add("Doctorate");
            typeBox.Items.Add("Specialization in Medicine");
            typeBox.Items.Add("Proficiency in Art");
            typeBox.Items.Add("Specialization in Dentistry");
            typeBox.Items.Add("Minor Specialization in Medicine");
            typeBox.Items.Add("Expertise in Pharmacy");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        
        {
            string title = titleBox.Text;
            string abstractText = abstractBox.Text;
            int year = int.Parse(yearBox.Text);
            string type = typeBox.Text;
            int pages = int.Parse(pagesBox.Text);
            string language = langBox.Text;
            DateTime subdate = DateTime.Parse(subDateBox.Text);

            InsertThesis(title, abstractText, year, type);

            mainPage.LoadThesisInfo();

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InsertThesis(string title, string abstractText, int year, string type)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string getMaxThesisNoQuery = "SELECT MAX(ThesisNo) FROM Thesis";
                using (SqlCommand getMaxThesisNoCmd = new SqlCommand(getMaxThesisNoQuery, connection))
                {
                    object result = getMaxThesisNoCmd.ExecuteScalar();
                    int maxThesisNo = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                    int nextThesisNo = maxThesisNo + 1;

                    string insertQuery = "INSERT INTO Thesis (ThesisNo, Title, Abstract, Year, Type) VALUES (@ThesisNo, @Title, @Abstract, @Year, @Type)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@ThesisNo", nextThesisNo);
                        insertCmd.Parameters.AddWithValue("@Title", title);
                        insertCmd.Parameters.AddWithValue("@Abstract", abstractText);
                        insertCmd.Parameters.AddWithValue("@Year", year);
                        insertCmd.Parameters.AddWithValue("@Type", type);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thesis submitted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error submitting thesis.");
                        }
                    }
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = string.Empty;
            abstractBox.Text = string.Empty;
            yearBox.Text = string.Empty;
            typeBox.SelectedIndex = -1;
            pagesBox.Text = string.Empty;
            langBox.Text = string.Empty;
            subDateBox.Text = DateTime.Now.Year.ToString();
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subDateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
