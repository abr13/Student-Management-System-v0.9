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
    public partial class Students_UC : UserControl
    {
        public Students_UC()
        {
            InitializeComponent();

            StudentdataGridView();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
                if (USNTextField.Text != "" && NameTextField.Text != "" && AddressTextField.Text != "" && GenderComboBox.Text != "Choose one...")
                {
                    using (SqlCommand cmd = new SqlCommand("AddStudent_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@usn", USNTextField.Text);
                        cmd.Parameters.AddWithValue("@name", NameTextField.Text);
                        cmd.Parameters.AddWithValue("@address", AddressTextField.Text);
                        cmd.Parameters.AddWithValue("@phone", PhoneTextField.Text);
                        cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text);

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            AddedLabel.ForeColor = Color.Green;
                            AddedLabel.Text = "Added successfully";
                            AddedLabel.Show();
                            USNTextField.Text = "";
                            NameTextField.Text = "";
                            AddressTextField.Text = "";
                            PhoneTextField.Text = "";
                            GenderComboBox.Text = "";
                        }
                        catch (Exception)
                        {
                            AddedLabel.ForeColor = Color.Red;
                            AddedLabel.Text = "Error!";
                            AddedLabel.Show();
                        }
                        con.Close();
                        StudentdataGridView();
                    }                    
                }
                else
                {
                    AddedLabel.ForeColor = Color.Red;
                    AddedLabel.Text = "Empty!";
                    AddedLabel.Show();
                }
        }

        public void StudentdataGridView()
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ShowStudent_SP", con))
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
                            }                            
                        }                        
                    }                   
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er);
                }
        }

        string tempUSN = "", tempName = "";
        private void SearchButton_Click(object sender, EventArgs e)
        {
            tempUSN = SearchUSNTextField.Text;
            tempName = SearchNameTextField.Text;                
                try
                {                    
                    using (SqlCommand cmd = new SqlCommand("SearchStudent_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (SearchUSNTextField.Text != "" || SearchNameTextField.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@usn", tempUSN);
                            cmd.Parameters.AddWithValue("@name", tempName);

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

        private void SearchUSNTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchNameTextField.Text = "";
            SearchStatusLabel.Hide();
            UpdateStatusLabel.Hide();
        }

        private void SearchNameTextField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchUSNTextField.Text = "";
            SearchStatusLabel.Hide();
            UpdateStatusLabel.Hide();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            StudentdataGridView();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchUSNTextField.Text = "";
            SearchNameTextField.Text = "";
            USNTextField.Text = "";
            NameTextField.Text = "";
            AddressTextField.Text = "";
            PhoneTextField.Text = "";
            tempUSN = "";
            tempName = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(USNTextField.Text!="")
            {
                DialogResult result = MessageBox.Show("Do you really want to delete student with usn '"+USNTextField.Text+"' ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteStudent_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@usn", tempUSN);
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
                        StudentdataGridView();
                    }
                }
                else if (result == DialogResult.No)
                {
                    DeleteStatusLabel.ForeColor = Color.Red;
                    DeleteStatusLabel.Text = "Cancelled!";
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

        private void Students_UC_MouseClick(object sender, MouseEventArgs e)
        {
            AddedLabel.Hide();
            UpdateStatusLabel.Hide();
            DeleteStatusLabel.Hide();
            RefreshedLabel.Hide();
            ClearedLabel.Hide();
            SearchStatusLabel.Text = "";
        }

        private void SearchUSNTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchNameTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void USNTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tempUSN=USNTextField.Text = row.Cells[0].Value.ToString();
                tempName=NameTextField.Text = row.Cells[1].Value.ToString();
                AddressTextField.Text = row.Cells[2].Value.ToString();
                PhoneTextField.Text = row.Cells[3].Value.ToString();
                GenderComboBox.Text = row.Cells[4].Value.ToString();                
            }
        }

        private void UpdateButton_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Show();
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Hide();
        }

        private void SearchUSNTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void SearchUSNTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }

        private void SearchNameTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel2.Show();
        }

        private void SearchNameTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel2.Hide();
        }

        private void USNTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void USNTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void NameTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel4.Show();
        }

        private void NameTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel4.Hide();
        }

        private void AddressTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel5.Show();
        }

        private void AddressTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel5.Hide();
        }

        private void PhoneTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel6.Show();
        }

        private void PhoneTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel6.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
                if (tempUSN != "")
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateStudent_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@usn", tempUSN);
                        cmd.Parameters.AddWithValue("@phone", PhoneTextField.Text);

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
                        StudentdataGridView();
                    }                    
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
