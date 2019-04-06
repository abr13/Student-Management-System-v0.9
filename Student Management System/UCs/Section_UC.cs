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
    public partial class Section_UC : UserControl
    {
        public Section_UC()
        {
            InitializeComponent();

            SectiondataGridView();//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\abdur\source\repos\Projects\Student Management System v0.4\Student Management System\SMSDatabase.mdf";Integrated Security=True
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
                if (SSIDTextField.Text != "" && SemesterTextField.Text != "" && SectionTextField.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("AddSection_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ssid", SSIDTextField.Text);
                        cmd.Parameters.AddWithValue("@sem", SemesterTextField.Text);
                        cmd.Parameters.AddWithValue("@sec", SectionTextField.Text);

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            AddStatusLabel.ForeColor = Color.Green;
                            AddStatusLabel.Text = "Added successfully";
                            AddStatusLabel.Show();
                            SSIDTextField.Text = "";
                            SemesterTextField.Text = "";
                            SectionTextField.Text = "";
                        }
                        catch (Exception z)
                        {
                            AddStatusLabel.ForeColor = Color.Red;
                            AddStatusLabel.Text = "Error!";
                            AddStatusLabel.Show();
                            MessageBox.Show("" + z);
                        }
                        con.Close();
                        SectiondataGridView();
                    }                    
                }
                else
                {
                    AddStatusLabel.ForeColor = Color.Red;
                    AddStatusLabel.Text = "Empty!";
                    AddStatusLabel.Show();
                }                
        }

        public void SectiondataGridView()
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ShowSection_SP", con))
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
                            }                            
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
            SectiondataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(SSIDTextField.Text!="")
            {
                DialogResult result = MessageBox.Show("Do you really want to delete '"+SSIDTextField.Text+"' ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteSection_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ssid", SSIDTextField.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            DeleteStatusLabel.ForeColor = Color.Green;
                            DeleteStatusLabel.Text = "Deleted successfully";
                            DeleteStatusLabel.Show();
                        }
                        catch (Exception z)
                        {
                            DeleteStatusLabel.ForeColor = Color.Red;
                            DeleteStatusLabel.Text = "Error!";
                            DeleteStatusLabel.Show();
                            MessageBox.Show("" + z);
                        }
                        con.Close();
                    }
                    SectiondataGridView();
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

        private void Section_UC_MouseClick(object sender, MouseEventArgs e)
        {
            AddStatusLabel.Hide();
            DeleteStatusLabel.Hide();
            RefreshStatusLabel.Hide();
            ClearedLabel.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SSIDTextField.Text = "";
            SemesterTextField.Text = "";
            SectionTextField.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                SSIDTextField.Text = row.Cells[0].Value.ToString();
                SemesterTextField.Text = row.Cells[1].Value.ToString();
                SectionTextField.Text = row.Cells[2].Value.ToString();
            }
        }

        private void SSIDTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void SSIDTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void SemesterTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel2.Show();
        }

        private void SemesterTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel2.Hide();
        }

        private void SectionTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void SectionTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }
    }
}
