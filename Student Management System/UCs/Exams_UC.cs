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
    public partial class Exams_UC : UserControl
    {
        public Exams_UC()
        {
            InitializeComponent();

            ExamdataGridView();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (USNTextField.Text != "" && SubcodeTextField.Text != "" && SSIDTextField.Text != "")
            {
                int a = Convert.ToInt32(numericUpDown1.Value);
                int b = Convert.ToInt32(numericUpDown2.Value);
                int c = Convert.ToInt32(numericUpDown3.Value);

                int f;
                if (a < b && a < c)
                {
                    f = (b + c) / 2;
                }
                else if (b < a && b < c)
                {
                    f = (a + c) / 2;
                }
                else
                {
                    f = (a + b) / 2;
                }
                using (SqlCommand cmd = new SqlCommand("AddExam_SP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usn", USNTextField.Text);
                    cmd.Parameters.AddWithValue("@subCode", SubcodeTextField.Text);
                    cmd.Parameters.AddWithValue("@ssid", SSIDTextField.Text);
                    cmd.Parameters.AddWithValue("@test1", a);
                    cmd.Parameters.AddWithValue("@test2", b);
                    cmd.Parameters.AddWithValue("@test3", c);
                    cmd.Parameters.AddWithValue("@final", f);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        AddStatusLabel.ForeColor = Color.Green;
                        AddStatusLabel.Text = "Added successfully";
                        AddStatusLabel.Show();
                        USNTextField.Text = "";
                        SSIDTextField.Text = "";
                        SubcodeTextField.Text = "";
                    }
                    catch (Exception)
                    {
                        AddStatusLabel.ForeColor = Color.Red;
                        AddStatusLabel.Text = "Error!";
                        AddStatusLabel.Show();
                        MessageBox.Show("Value is missing ;\nEither USN or SSID not found\nOr duplicate entry.\nTry with a valid details.");
                    }
                    con.Close();
                }
                ExamdataGridView();
            }
            else
            {
                AddStatusLabel.ForeColor = Color.Red;
                AddStatusLabel.Text = "Empty!";
                AddStatusLabel.Show();
            }
        }

        public void ExamdataGridView()
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ShowExam_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                                dataGridView1.DataSource = ds.Tables[0];

                                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }                                
                        }                            
                    }                                            
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er);
                }                
        }

        string tempUSN = "", tempSubcode = "";
        private void SearchButton_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SearchExam_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (SearchUSNTextField.Text != "" || SearchSubcodeTextField.Text != "")
                        {
                            tempUSN = SearchUSNTextField.Text;
                            tempSubcode = SearchSubcodeTextField.Text;
                            cmd.Parameters.AddWithValue("@usn", SearchUSNTextField.Text);
                            cmd.Parameters.AddWithValue("@subCode", SearchSubcodeTextField.Text);

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataSet ds = new DataSet())
                                {
                                    da.Fill(ds);

                                    con.Open();
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                        SearchStatusLabel.ForeColor = Color.Green;
                                        SearchStatusLabel.Text = "Search completed!";
                                        SearchStatusLabel.Show();
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
                                    this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                    this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ExamdataGridView();
            RefreshedLabel.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchUSNTextField.Text = "";
            SearchSubcodeTextField.Text = "";
            USNTextField.Text = "";
            SubcodeTextField.Text = "";
            SSIDTextField.Text = "";
            ClearedLabel.Show();
            tempUSN = "";
            tempSubcode = "";
        }

        private void SearchUSNTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchSubcodeTextField.Text = "";
        }

        private void SearchSubcodeTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchUSNTextField.Text = "";
        }

        private void Exams_UC_MouseClick(object sender, MouseEventArgs e)
        {
            SearchStatusLabel.Hide();
            AddStatusLabel.Hide();
            UpdateStatusLabel.Hide();
            RefreshedLabel.Hide();
            ClearedLabel.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tempUSN=USNTextField.Text = row.Cells[0].Value.ToString();
                tempSubcode=SubcodeTextField.Text = row.Cells[5].Value.ToString();
                SSIDTextField.Text = row.Cells[6].Value.ToString();
                numericUpDown1.Text = row.Cells[1].Value.ToString();
                numericUpDown2.Text = row.Cells[2].Value.ToString();
                numericUpDown3.Text = row.Cells[3].Value.ToString();
            }
        }

        private void UpdateStatusButton_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Show();
        }

        private void UpdateStatusButton_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Hide();
        }

        private void SearchSubcodeTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void SearchSubcodeTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }

        private void SearchUSNTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel4.Show();
        }

        private void SearchUSNTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel4.Hide();
        }

        private void USNTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel6.Show();
        }

        private void USNTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel6.Hide();
        }

        private void SubcodeTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void SubcodeTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void SSIDTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel5.Show();
        }

        private void SSIDTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel5.Hide();
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            if (tempUSN != "" || tempSubcode != "")
            {
                int a = Convert.ToInt32(numericUpDown1.Value);
                int b = Convert.ToInt32(numericUpDown2.Value);
                int c = Convert.ToInt32(numericUpDown3.Value);

                int f;
                if (a < b && a < c)
                {
                    f = (b + c) / 2;
                }
                else if (b < a && b < c)
                {
                    f = (a + c) / 2;
                }
                else
                {
                    f = (a + b) / 2;
                }
                using (SqlCommand cmd = new SqlCommand("UpdateExam_SP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usn", tempUSN);
                    cmd.Parameters.AddWithValue("@subCode", tempSubcode);
                    cmd.Parameters.AddWithValue("@test1", a);
                    cmd.Parameters.AddWithValue("@test2", b);
                    cmd.Parameters.AddWithValue("@test3", c);
                    cmd.Parameters.AddWithValue("@final", f);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        UpdateStatusLabel.ForeColor = Color.Green;
                        UpdateStatusLabel.Text = "Updated successfully";
                        UpdateStatusLabel.Show();
                    }
                    catch (Exception)
                    {
                        UpdateStatusLabel.ForeColor = Color.Red;
                        UpdateStatusLabel.Text = "Error!";
                        UpdateStatusLabel.Show();
                    }
                    con.Close();
                }
                ExamdataGridView();
            }
            else
            {
                UpdateStatusLabel.ForeColor = Color.Red;
                UpdateStatusLabel.Text = "Value is empty!";
                UpdateStatusLabel.Show();
            }
        }
    }
}
