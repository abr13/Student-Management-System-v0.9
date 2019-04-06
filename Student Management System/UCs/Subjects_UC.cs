using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System.UCs
{
    public partial class Subjects_UC : UserControl
    {
        public Subjects_UC()
        {
            InitializeComponent();

            SubjectdataGridView();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
                if (SubcodeTextField.Text != "" && BookTitleTextField.Text != "" && SemTextField.Text != "" && CreditsTextField.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("AddSubject_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@subCode", SubcodeTextField.Text);
                        cmd.Parameters.AddWithValue("@title", BookTitleTextField.Text);
                        cmd.Parameters.AddWithValue("@sem", SemTextField.Text);
                        cmd.Parameters.AddWithValue("@credits", CreditsTextField.Text);

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            AddStatusLabel.ForeColor = Color.Green;
                            AddStatusLabel.Text = "Added successfully";
                            AddStatusLabel.Show();
                            SubcodeTextField.Text = "";
                            BookTitleTextField.Text = "";
                            SemTextField.Text = "";
                            CreditsTextField.Text = "";
                        }
                        catch (Exception)
                        {
                            AddStatusLabel.ForeColor = Color.Red;
                            AddStatusLabel.Text = "Error!";
                            AddStatusLabel.Show();
                        }
                        con.Close();
                        SubjectdataGridView();
                    }                    
                }
                else
                {
                    AddStatusLabel.ForeColor = Color.Red;
                    AddStatusLabel.Text = "Empty!";
                    AddStatusLabel.Show();
                }
        }

        public void SubjectdataGridView()
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ShowSubject_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("" + er);
                        }
                        con.Close();
                        dataGridView1.DataSource = ds.Tables[0];
                        this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }                    
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er);
                }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SubjectdataGridView();
            RefreshedLabel.Show();
        }

        private void SearchSubcodeTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchTitleTextField.Text = "";
        }

        private void SearchTitleTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchSubcodeTextField.Text = "";
        }

        private void Subjects_UC_MouseClick(object sender, MouseEventArgs e)
        {
            SearchStatusLabel.Hide();
            AddStatusLabel.Hide();
            DeleteStatusLabel.Hide();
            RefreshedLabel.Hide();
            ClearedLabel.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchSubcodeTextField.Text = "";
            SearchTitleTextField.Text = "";
            SubcodeTextField.Text = "";
            BookTitleTextField.Text = "";
            SemTextField.Text = "";
            CreditsTextField.Text = "";
            ClearedLabel.Show();
            tempSubcode = "";
            tempTitle = "";
        }
   
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(tempSubcode != "" || tempTitle != "")
            {
                DialogResult result = MessageBox.Show("Do you really want to delete subject with subject code '"+tempSubcode+"' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteSubject_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@subCode", tempSubcode);
                        cmd.Parameters.AddWithValue("@title", tempTitle);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            DeleteStatusLabel.ForeColor = Color.Green;
                            DeleteStatusLabel.Text = "Deleted successfully";
                            DeleteStatusLabel.Show();
                        }
                        catch (Exception)
                        {
                            DeleteStatusLabel.ForeColor = Color.Red;
                            DeleteStatusLabel.Text = "Error!";
                            DeleteStatusLabel.Show();
                        }
                        con.Close();
                        SubjectdataGridView();
                    }
                }
                else if (result == DialogResult.No)
                {
                    DeleteStatusLabel.ForeColor = Color.Red;
                    DeleteStatusLabel.Text = "Cancelled";
                    DeleteStatusLabel.Show();
                }
                else
                {
                    //
                }
            }
            else
            {
                DeleteStatusLabel.ForeColor = Color.Red;
                DeleteStatusLabel.Text = "Value is empty!";
                DeleteStatusLabel.Show();
            }
        }

        string tempSubcode = "", tempTitle = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tempSubcode = SubcodeTextField.Text = row.Cells[0].Value.ToString();
                tempTitle = BookTitleTextField.Text = row.Cells[1].Value.ToString();
                SemTextField.Text = row.Cells[2].Value.ToString();
                CreditsTextField.Text = row.Cells[3].Value.ToString();
            }
        }

        private void SearchSubcodeTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void SearchSubcodeTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }

        private void SearchTitleTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel2.Show();
        }

        private void SearchTitleTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel2.Hide();
        }

        private void SubcodeTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void SubcodeTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void BookTitleTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel4.Show();
        }

        private void BookTitleTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel4.Hide();
        }

        private void SemTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel5.Show();
        }

        private void SemTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel5.Hide();
        }

        private void CreditsTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel6.Hide();
        }

        private void CreditsTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel6.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SearchSubject_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (SearchSubcodeTextField.Text != "" || SearchTitleTextField.Text != "")
                        {
                            //tempSubcode = SearchSubcodeTextField.Text;
                            //tempTitle = SearchTitleTextField.Text;
                            cmd.Parameters.AddWithValue("@subCode", SearchSubcodeTextField.Text);
                            cmd.Parameters.AddWithValue("@title", SearchTitleTextField.Text);

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataSet ds = new DataSet())
                                {
                                    da.Fill(ds);

                                    con.Open();
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception er)
                                    {
                                        MessageBox.Show("" + er);
                                    }
                                    con.Close();
                                    SearchStatusLabel.ForeColor = Color.Green;
                                    SearchStatusLabel.Text = "Search completed!";
                                    SearchStatusLabel.Show();

                                    dataGridView1.DataSource = ds.Tables[0];
                                    this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }                                
                            }                            
                        }
                        else
                        {
                            SearchStatusLabel.ForeColor = Color.Red;
                            SearchStatusLabel.Text = "Value is empty!!";
                            SearchStatusLabel.Show();
                        }
                    }                    
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er);
                }
        }
    }
}
