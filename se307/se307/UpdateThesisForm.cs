using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace se307
{
    public partial class UpdateThesisForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-8POO7R8;Initial Catalog=\"GTS 1.1\";Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        private DataTable universityTable;
        private DataTable authorTable;
        private DataTable instituteTable;

        private SqlDataAdapter universityDataAdapter;
        private SqlDataAdapter authorDataAdapter;
        private SqlDataAdapter instituteDataAdapter;
        public UpdateThesisForm()
        {
            InitializeComponent();
            universityTable = new DataTable("University");
            authorTable = new DataTable("Author");
            instituteTable = new DataTable("Institute");

            universityDataAdapter = new SqlDataAdapter("SELECT * FROM University", ConnectionString);
            authorDataAdapter = new SqlDataAdapter("SELECT * FROM Author", ConnectionString);
            instituteDataAdapter = new SqlDataAdapter("SELECT * FROM Institute", ConnectionString);


            universityDataAdapter.Fill(universityTable);
            authorDataAdapter.Fill(authorTable);
            instituteDataAdapter.Fill(instituteTable);

            universityDataGridView.DataSource = universityTable;
            authorDataGridView.DataSource = authorTable;
            instituteDataGridView.DataSource = instituteTable;

        }
        private void UpdateThesis(int thesisID, string title, string abstractText, int year, string type, int pages, string language, DateTime subDate, int instituteID, int universityID, int authorID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Thesis SET Title = @Title, Abstract = @Abstract, Year = @Year, Type = @Type, Pages = @Pages, Language = @Language, SubDate = @SubDate, InstituteID = @InstituteID, UniversityID = @UniversityID, AuthorID = @AuthorID WHERE ThesisID = @ThesisID";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@ThesisID", thesisID);
                    updateCmd.Parameters.AddWithValue("@Title", title);
                    updateCmd.Parameters.AddWithValue("@Abstract", abstractText);
                    updateCmd.Parameters.AddWithValue("@Year", year);
                    updateCmd.Parameters.AddWithValue("@Type", type);
                    updateCmd.Parameters.AddWithValue("@Pages", pages);
                    updateCmd.Parameters.AddWithValue("@Language", language);
                    updateCmd.Parameters.AddWithValue("@SubDate", subDate);
                    updateCmd.Parameters.AddWithValue("@InstituteID", instituteID);
                    updateCmd.Parameters.AddWithValue("@UniversityID", universityID);
                    updateCmd.Parameters.AddWithValue("@AuthorID", authorID);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thesis updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error updating thesis.");
                    }
                }
            }
        }

        private void AddUniversityControls(TabPage universityTab)
        {
            
            Label universityLabel = new Label();
            universityLabel.Text = "University Name:";
            TextBox universityNameTextBox = new TextBox();
            Button addUniversityBtn = new Button();
            Button updateUniversityBtn = new Button();
            Button deleteUniversityBtn = new Button();
            DataGridView universityDataGridView = new DataGridView();

            
            universityDataGridView.DataSource = universityTable;

           
            addUniversityBtn.Text = "Add University";
            updateUniversityBtn.Text = "Update University";
            deleteUniversityBtn.Text = "Delete University";

            
            addUniversityBtn.Click += (sender, e) =>
            {
                string universityName = universityNameTextBox.Text;
                AddUniversity(universityName);
            };

            updateUniversityBtn.Click += (sender, e) =>
            {
                if (universityDataGridView.SelectedRows.Count > 0)
                {
                    int universityID = Convert.ToInt32(universityDataGridView.SelectedRows[0].Cells["UniversityID"].Value);
                    string universityName = universityNameTextBox.Text;
                    UpdateUniversity(universityID, universityName);
                }
            };

            deleteUniversityBtn.Click += (sender, e) =>
            {
                
                if (universityDataGridView.SelectedRows.Count > 0)
                {
                    int universityID = Convert.ToInt32(universityDataGridView.SelectedRows[0].Cells["UniversityID"].Value);
                    DeleteUniversity(universityID);
                }
            };

            universityTab.Controls.Add(universityLabel);
            universityTab.Controls.Add(universityNameTextBox);
            universityTab.Controls.Add(addUniversityBtn);
            universityTab.Controls.Add(updateUniversityBtn);
            universityTab.Controls.Add(deleteUniversityBtn);
            universityTab.Controls.Add(universityDataGridView);
        }

        private void AddAuthorControls(TabPage authorTab)
        {
            
            Label authorLabel = new Label();
            authorLabel.Text = "Author Name:";
            TextBox authorNameTextBox = new TextBox();
            Button addAuthorBtn = new Button();
            Button updateAuthorBtn = new Button();
            Button deleteAuthorBtn = new Button();
            DataGridView authorDataGridView = new DataGridView();

           
            authorDataGridView.DataSource = authorTable;

            
            addAuthorBtn.Text = "Add Author";
            updateAuthorBtn.Text = "Update Author";
            deleteAuthorBtn.Text = "Delete Author";

            
            addAuthorBtn.Click += (sender, e) =>
            {
                string authorName = authorNameTextBox.Text;
                AddAuthor(authorName);
            };

            updateAuthorBtn.Click += (sender, e) =>
            {
                
                if (authorDataGridView.SelectedRows.Count > 0)
                {
                    int authorID = Convert.ToInt32(authorDataGridView.SelectedRows[0].Cells["AuthorID"].Value);
                    string authorName = authorNameTextBox.Text;
                    UpdateAuthor(authorID, authorName);
                }
            };

            deleteAuthorBtn.Click += (sender, e) =>
            {
               
                if (authorDataGridView.SelectedRows.Count > 0)
                {
                    int authorID = Convert.ToInt32(authorDataGridView.SelectedRows[0].Cells["AuthorID"].Value);
                    DeleteAuthor(authorID);
                }
            };


            authorTab.Controls.Add(authorLabel);
            authorTab.Controls.Add(authorNameTextBox);
            authorTab.Controls.Add(addAuthorBtn);
            authorTab.Controls.Add(updateAuthorBtn);
            authorTab.Controls.Add(deleteAuthorBtn);
            authorTab.Controls.Add(authorDataGridView);
        }

        private void AddUniversity(string universityName)
        {
            DataRow newRow = universityTable.NewRow();

            int maxUniversityID = (universityTable.Rows.Count > 0) ? universityTable.AsEnumerable().Max(row => row.Field<int>("UniversityID")) : 0;
            newRow["UniversityID"] = maxUniversityID + 1;

            newRow["UniversityName"] = universityName;
            universityTable.Rows.Add(newRow);
            universityDataAdapter.Update(universityTable);
           
        }

        private void UpdateUniversity(int universityID, string universityName)
        {
            DataRow[] rows = universityTable.Select($"UniversityID = {universityID}");
            if (rows.Length > 0)
            {
                rows[0]["UniversityName"] = universityName;
                universityDataAdapter.Update(universityTable);
            }
        }

        private void DeleteUniversity(int universityID)
        {
            DataRow[] rows = universityTable.Select($"UniversityID = {universityID}");
             if (rows.Length > 0)
             {
                rows[0].Delete();
                universityDataAdapter.Update(universityTable);
             }
        }

        private void AddAuthor(string authorName)
        {
            DataRow newRow = authorTable.NewRow();

            int maxAuthorID = (authorTable.Rows.Count > 0) ? authorTable.AsEnumerable().Max(row => row.Field<int>("AuthorID")) : 0;
            newRow["AuthorID"] = maxAuthorID + 1;

            newRow["AuthorName"] = authorName;
            authorTable.Rows.Add(newRow);
            authorDataAdapter.Update(authorTable);
        }

        private void UpdateAuthor(int authorID, string authorName)
        {
            DataRow[] rows = authorTable.Select($"AuthorID = {authorID}");
            if (rows.Length > 0)
            {
                rows[0]["AuthorName"] = authorName;
                authorDataAdapter.Update(authorTable);
            }
        }

        private void DeleteAuthor(int authorID)
        {
            DataRow[] rows = authorTable.Select($"AuthorID = {authorID}");
            if (rows.Length > 0)
            {
                rows[0].Delete();
                authorDataAdapter.Update(authorTable);
            }
        }

        private void AddInstituteControls(TabPage instituteTab)
        {
            Label instituteLabel = new Label();
            instituteLabel.Text = "Institute Name:";
            TextBox instituteNameTextBox = new TextBox();
            Button addInstituteBtn = new Button();
            Button updateInstituteBtn = new Button();
            Button deleteInstituteBtn = new Button();
            DataGridView instituteDataGridView = new DataGridView();

            instituteDataGridView.DataSource = instituteTable;

            addInstituteBtn.Text = "Add Institute";
            updateInstituteBtn.Text = "Update Institute";
            deleteInstituteBtn.Text = "Delete Institute";

            addInstituteBtn.Click += (sender, e) =>
            {
                string instituteName = instituteNameTextBox.Text;
                AddInstitute(instituteName);
            };

            updateInstituteBtn.Click += (sender, e) =>
            {
                if (instituteDataGridView.SelectedRows.Count > 0)
                {
                    int instituteID = Convert.ToInt32(instituteDataGridView.SelectedRows[0].Cells["InstituteID"].Value);
                    string instituteName = instituteNameTextBox.Text;
                    UpdateInstitute(instituteID, instituteName);
                }
            };

            deleteInstituteBtn.Click += (sender, e) =>
            {
                if (instituteDataGridView.SelectedRows.Count > 0)
                {
                    int instituteID = Convert.ToInt32(instituteDataGridView.SelectedRows[0].Cells["InstituteID"].Value);
                    DeleteInstitute(instituteID);
                }
            };

            instituteTab.Controls.Add(instituteLabel);
            instituteTab.Controls.Add(instituteNameTextBox);
            instituteTab.Controls.Add(addInstituteBtn);
            instituteTab.Controls.Add(updateInstituteBtn);
            instituteTab.Controls.Add(deleteInstituteBtn);
            instituteTab.Controls.Add(instituteDataGridView);
        }

        private void AddInstitute(string instituteName)
        {
            DataRow newRow = instituteTable.NewRow();

            int maxInstituteID = (instituteTable.Rows.Count > 0) ? instituteTable.AsEnumerable().Max(row => row.Field<int>("InstituteID")) : 0;
            newRow["InstituteID"] = maxInstituteID + 1;

            newRow["InstituteName"] = instituteName;
            instituteTable.Rows.Add(newRow);
            instituteDataAdapter.Update(instituteTable);
        }

        private void UpdateInstitute(int instituteID, string instituteName)
        {
            DataRow[] rows = instituteTable.Select($"InstituteID = {instituteID}");
            if (rows.Length > 0)
            {
                rows[0]["InstituteName"] = instituteName;
                instituteDataAdapter.Update(instituteTable);
            }
        }

        private void DeleteInstitute(int instituteID)
        {
            DataRow[] rows = instituteTable.Select($"InstituteID = {instituteID}");
            if (rows.Length > 0)
            {
                rows[0].Delete();
                instituteDataAdapter.Update(instituteTable);
            }
        }

        private void UpdateThesisForm_Load(object sender, EventArgs e)
        {

        }

        private void Universities_Click(object sender, EventArgs e)
        {

        }

        private void Institutes_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void universityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtnUni_Click(object sender, EventArgs e)
        {

        }

        private void changeBtnUni_Click(object sender, EventArgs e)
        {

        }

        private void delBtnUni_Click(object sender, EventArgs e)
        {

        }

        private void uniIdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
