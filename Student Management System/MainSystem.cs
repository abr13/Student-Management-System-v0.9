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
using Student_Management_System.UCs;

namespace Student_Management_System
{
    public partial class MainSystem : Form
    {
        WelcomeForm welcomeForm = new WelcomeForm();
        public MainSystem()
        {
            InitializeComponent();
        }

        public void AdminName(string s)
        {
            AdminNameLabel.Text=s;
        }
        Exams_UC student_UC = new Exams_UC();
        Subjects_UC subjects_UC = new Subjects_UC();
        Classes_UC classes_UC = new Classes_UC();
        Section_UC section_UC = new Section_UC();
        Students_UC students_UC = new Students_UC();
        Settings_UC settings_UC = new Settings_UC();     
        
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Dispose();
            welcomeForm.Show();
            students_UC.Dispose();
            subjects_UC.Dispose();
            classes_UC.Dispose();
            section_UC.Dispose();
            students_UC.Dispose();
            settings_UC.Dispose();
        }

        private void ExamsButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(student_UC);
            student_UC.Dock = DockStyle.Fill;
            student_UC.BringToFront();

            //panel1.Width = ExamsButton.Width;
            panel1.Left = ExamsButton.Left;
            panel1.Show();
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(subjects_UC);
            subjects_UC.Dock = DockStyle.Fill;
            subjects_UC.BringToFront();

            //panel1.Width = SubjectsButton.Width;
            panel1.Left = SubjectsButton.Left;
            panel1.Show();
        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(classes_UC);
            classes_UC.Dock = DockStyle.Fill;
            classes_UC.BringToFront();

            //panel1.Width = ClassesButton.Width;
            panel1.Left = ClassesButton.Left;
            panel1.Show();
        }

        private void SectionsButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(section_UC);
            section_UC.Dock = DockStyle.Fill;
            section_UC.BringToFront();

            //panel1.Width = SectionsButton.Width;
            panel1.Left = SectionsButton.Left;
            panel1.Show();
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(students_UC);
            students_UC.Dock = DockStyle.Fill;
            students_UC.BringToFront();

            //panel1.Width = StudentsButton.Width;
            panel1.Left = StudentsButton.Left;
            panel1.Show();
        }

        private void AdminNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(settings_UC);
            settings_UC.Dock = DockStyle.Fill;
            settings_UC.BringToFront();

            //panel1.Width = SettingsButton.Width;
            panel1.Left = SettingsButton.Left;
            panel1.Show();
        }     

        private void AboutButton_Click(object sender, EventArgs e)
        {
            //ContentsPanel.Controls.Add(about_UC);
            //about_UC.Dock = DockStyle.Fill;
            //about_UC.BringToFront();
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();

            //panel1.Width = AboutButton.Width;
            panel1.Left = AboutButton.Left;
            panel1.Show();
        }
    }
}
