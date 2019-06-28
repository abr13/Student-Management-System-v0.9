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
    public partial class SignupUC : UserControl
    {
        public SignupUC()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");

        private void RegisterButton_Click(object sender, EventArgs e)
        {
                if (IDTextField.Text != "" && NameTextField.Text != "" && UsernameTextField.Text != "" && PasswordField.Text != "" && CPasswordField.Text != "")
                {
                    if (PasswordField.Text.Equals(CPasswordField.Text))
                    {
                        using (SqlCommand cmd = new SqlCommand("AddAdmin_SP", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", IDTextField.Text);
                            cmd.Parameters.AddWithValue("@name", NameTextField.Text);
                            cmd.Parameters.AddWithValue("@username", UsernameTextField.Text);
                            cmd.Parameters.AddWithValue("@password", PasswordField.Text);
                            cmd.Parameters.AddWithValue("@phone", PhoneTextField.Text);

                            con.Open();
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully registered - your username is :" + UsernameTextField.Text);
                                IDTextField.Text = "";
                                NameTextField.Text = "";
                                UsernameTextField.Text = "";
                                PasswordField.Text = "";
                                CPasswordField.Text = "";
                                PhoneTextField.Text = "";                                
                            }
                            catch (Exception z)
                            {
                                ErrorLabel.Text = "Error occured!";
                                ErrorLabel.Show();
                                MessageBox.Show("" + z);
                            }
                            con.Close();
                        }                        
                    }
                    else
                    {
                        ErrorLabel.Text = "Passwords do not match!";
                        ErrorLabel.Show();
                    }                    
                }
                else
                {
                    ErrorLabel.Text = "Values cannot be empty!";
                    ErrorLabel.Show();
                }
            GC.Collect();
        }

        private void IDTextField_MouseClick(object sender, MouseEventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void IDTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel1.Show();
        }

        private void IDTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel1.Hide();
        }

        private void NameTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel2.Show();
        }

        private void NameTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel2.Hide();
        }

        private void UsernameTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel3.Show();
        }

        private void UsernameTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel3.Hide();
        }

        private void PasswordField_MouseHover(object sender, EventArgs e)
        {
            infoLabel4.Show();
        }

        private void PasswordField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel4.Hide();
        }

        private void PhoneTextField_MouseHover(object sender, EventArgs e)
        {
            infoLabel5.Show();
        }

        private void PhoneTextField_MouseLeave(object sender, EventArgs e)
        {
            infoLabel5.Hide();
        }
        
    }
}
