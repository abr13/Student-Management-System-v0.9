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
    public partial class Classes_UC : UserControl
    {
        public Classes_UC()
        {
            InitializeComponent();

            ClassdataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (USNTextField.Text != "" && SSIDTextField.Text!="")
            {
                SqlCommand cmd = new SqlCommand("AddClass_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usn", USNTextField.Text);
                cmd.Parameters.AddWithValue("@ssid", SSIDTextField.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    AddStatusLabel.ForeColor = Color.Green;
                    AddStatusLabel.Text = "Added successfully";
                    AddStatusLabel.Show();
                    USNTextField.Text = "";
                    SSIDTextField.Text = "";
                }
                catch (Exception)
                {
                    AddStatusLabel.ForeColor = Color.Red;
                    AddStatusLabel.Text = "Error!";
                    AddStatusLabel.Show();
                    MessageBox.Show("Value is missing ;\nEither USN or SSID not found\nOr duplicate entry.\nTry with a valid details.");
                }
                con.Close();
                ClassdataGridView();
            }
            else
            {
                AddStatusLabel.ForeColor = Color.Red;
                AddStatusLabel.Text = "Empty!";
                AddStatusLabel.Show();
            }
        }

        public void ClassdataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowClass_SP", con);
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
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }
        string tempUSN="";
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchClass_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (SearchUSNTextField.Text != "")
                {
                    tempUSN = SearchUSNTextField.Text;
                    cmd.Parameters.AddWithValue("@usn", SearchUSNTextField.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
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
                }
                else
                {
                    SearchStatusLabel.ForeColor = Color.Red;
                    SearchStatusLabel.Text = "Value is empty!!";
                    SearchStatusLabel.Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClassdataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (tempUSN != "")
            {
                SqlCommand cmd = new SqlCommand("UpdateClass_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usn", tempUSN);
                cmd.Parameters.AddWithValue("@ssid", SSIDTextField.Text);

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
                    MessageBox.Show("Value is missing ;\nUSN or SSID not found,\nTry again with a valid details.");
                }
                con.Close();
                ClassdataGridView();
            }
            else
            {
                UpdateStatusLabel.ForeColor = Color.Red;
                UpdateStatusLabel.Text = "Value is empty!";
                UpdateStatusLabel.Show();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchUSNTextField.Text = "";
            USNTextField.Text = "";
            SSIDTextField.Text = "";
            tempUSN = "";
        }

        private void Classes_UC_MouseClick(object sender, MouseEventArgs e)
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

                tempUSN = USNTextField.Text = row.Cells[0].Value.ToString();
                SSIDTextField.Text = row.Cells[1].Value.ToString();
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

        private void USNTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel2.Show();
        }

        private void USNTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel2.Hide();
        }

        private void SSIDTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void SSIDTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void infoLabel1_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void infoLabel1_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }
    }
}
