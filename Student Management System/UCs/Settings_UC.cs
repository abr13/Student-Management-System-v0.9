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
    public partial class Settings_UC : UserControl       
    {
        public string p;
        public Settings_UC()
        {
            InitializeComponent();

            SettingdataGridView();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        public void SettingdataGridView()
        {
            try
            {               
                    using (SqlCommand cmd = new SqlCommand("ShowAdmin_SP", con))
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
                            }                            
                            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView1.Columns["Password"].Visible = false;
                            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }                        
                    }                                    
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                IDTextField.Text = row.Cells[0].Value.ToString();
                NameTextField.Text = row.Cells[1].Value.ToString();
                UsernameTextField.Text = row.Cells[2].Value.ToString();
                PasswordTextField.Text = row.Cells[3].Value.ToString();
                PhoneTextField.Text = row.Cells[4].Value.ToString();
            }
        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
                if (UsernameTextField.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateAdmin_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@username", UsernameTextField.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordTextField.Text);
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
                        SettingdataGridView();
                    }                    
                }
                else
                {
                    UpdateStatusLabel.ForeColor = Color.Red;
                    UpdateStatusLabel.Text = "Value is empty!";
                    UpdateStatusLabel.Show();
                }               
        }


        public void DeleteButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextField.Text!="")
            {
                DialogResult result = MessageBox.Show("Do you really want to delete the user '"+UsernameTextField.Text+"' ?\nThe user won't be able to login to the system after deletion.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DeleteAdmin_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", UsernameTextField.Text);
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
                    SettingdataGridView();
                }
                else if (result == DialogResult.No)
                {
                    DeleteStatusLabel.ForeColor = Color.Red;
                    DeleteStatusLabel.Text = "Cancelled";
                    DeleteStatusLabel.Show();
                }
                else
                {
                    //DeleteStatusLabel.ForeColor = Color.Red;
                    //DeleteStatusLabel.Text = "Value is empty!";
                    //DeleteStatusLabel.Show();
                }
            }
            else
            {
                DeleteStatusLabel.ForeColor = Color.Red;
                DeleteStatusLabel.Text = "value is empty!";
                DeleteStatusLabel.Show();
            }
        }

        private void Settings_UC_MouseClick(object sender, MouseEventArgs e)
        {
            IDTextField.Text = "";
            NameTextField.Text = "";
            UsernameTextField.Text = "";
            PasswordTextField.Text = "";
            PhoneTextField.Text = "";
            UpdateStatusLabel.Hide();
            DeleteStatusLabel.Hide();
        }

        private void UpdateButton_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Show();
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Hide();
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            viewLog();
        }

        public void viewLog()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ViewLog_SP", con))
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
                            dataGridView2.DataSource = ds.Tables[0];
                            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to clear all logs history?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("ClearLog_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Log Cleared!");
                }
                catch (Exception)
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Error!";
                    label7.Show();
                }
                con.Close();
                viewLog();
            }
            else if (result == DialogResult.No)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Cancelled!";
                label7.Show();
            }
            else
            {
                //
            }            
        }
    }
}
