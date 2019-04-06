using Student_Management_System.UCs;
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

namespace Student_Management_System
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        
        SignupUC signupUC = new SignupUC();
        private void GetInButton_Click(object sender, EventArgs e)
        {
            signupUC.Hide();
            panel1.Left = GetInButton.Left;
        }
        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            Panel.Controls.Add(signupUC);
            signupUC.Dock = DockStyle.Fill;
            signupUC.BringToFront();
            signupUC.Show();

            panel1.Left = AddAdminButton.Left;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\SMSDatabase.mdf\";Integrated Security=True");
        SqlDataReader dr;

        private void LoginButton_Click(object sender, EventArgs e)
        {       
                if (UsernameTextField.Text != "" && PasswordTextField.Text != "")
                {
                    MainSystem mainSystem = new MainSystem();
                    mainSystem.AdminName(UsernameTextField.Text);
                    string Tpassword;
                    using (SqlCommand cmd = new SqlCommand("LoginAdmin_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", UsernameTextField.Text);

                        con.Open();
                        try
                        {
                            dr = cmd.ExecuteReader();
                            dr.Read();
                        }
                        catch (Exception z)
                        {
                            MessageBox.Show("" + z);
                        }
                        try
                        {
                            Tpassword = dr[0].ToString();
                            if (Tpassword == PasswordTextField.Text)
                            {
                                UsernameTextField.Text = "";
                                PasswordTextField.Text = "";

                                mainSystem.Show();
                                this.Hide();
                            }
                            else
                            {
                                WrongCredentialsLabel.Text = "Credentials are wrong!";
                                WrongCredentialsLabel.Show();
                            }
                        }
                        catch (Exception)
                        {
                            WrongCredentialsLabel.Text = "Credentials are wrong!";
                            WrongCredentialsLabel.Show();
                        }
                        con.Close();                        
                    }
                }
                else
                {
                    WrongCredentialsLabel.Text = "Values cannot be empty!";
                    WrongCredentialsLabel.Show();
                }
            GC.Collect();
        }       
    }
}
