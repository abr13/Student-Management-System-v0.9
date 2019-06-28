namespace Student_Management_System
{
    partial class MainSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SectionsButton = new System.Windows.Forms.Button();
            this.ExamsButton = new System.Windows.Forms.Button();
            this.ClassesButton = new System.Windows.Forms.Button();
            this.SubjectsButton = new System.Windows.Forms.Button();
            this.ContentsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.ButtonsPanel.Controls.Add(this.panel2);
            this.ButtonsPanel.Controls.Add(this.panel1);
            this.ButtonsPanel.Controls.Add(this.SettingsButton);
            this.ButtonsPanel.Controls.Add(this.AboutButton);
            this.ButtonsPanel.Controls.Add(this.StudentsButton);
            this.ButtonsPanel.Controls.Add(this.LogoutButton);
            this.ButtonsPanel.Controls.Add(this.SectionsButton);
            this.ButtonsPanel.Controls.Add(this.ExamsButton);
            this.ButtonsPanel.Controls.Add(this.ClassesButton);
            this.ButtonsPanel.Controls.Add(this.SubjectsButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(890, 55);
            this.ButtonsPanel.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.AdminNameLabel);
            this.panel2.Location = new System.Drawing.Point(606, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 31);
            this.panel2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "User :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.if_user_man_678132;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.AutoSize = true;
            this.AdminNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameLabel.ForeColor = System.Drawing.Color.White;
            this.AdminNameLabel.Location = new System.Drawing.Point(85, 4);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(101, 22);
            this.AdminNameLabel.TabIndex = 29;
            this.AdminNameLabel.Text = "Name Here";
            this.AdminNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminNameLabel.Click += new System.EventHandler(this.AdminNameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 8);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.SettingsButton.FlatAppearance.BorderSize = 2;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = global::Student_Management_System.Properties.Resources.if_icons_settings_1564529;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(387, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(78, 50);
            this.SettingsButton.TabIndex = 33;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.AutoSize = true;
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.AboutButton.FlatAppearance.BorderSize = 2;
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Image = global::Student_Management_System.Properties.Resources.if_about_2639759;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(464, 2);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(78, 50);
            this.AboutButton.TabIndex = 32;
            this.AboutButton.Text = "About us";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // StudentsButton
            // 
            this.StudentsButton.AutoSize = true;
            this.StudentsButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.StudentsButton.FlatAppearance.BorderSize = 2;
            this.StudentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsButton.ForeColor = System.Drawing.Color.White;
            this.StudentsButton.Image = global::Student_Management_System.Properties.Resources.if_group2_309041;
            this.StudentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsButton.Location = new System.Drawing.Point(2, 2);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(78, 50);
            this.StudentsButton.TabIndex = 24;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoSize = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LogoutButton.FlatAppearance.BorderSize = 2;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::Student_Management_System.Properties.Resources.if_SignOut_1031505;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.Location = new System.Drawing.Point(811, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(78, 50);
            this.LogoutButton.TabIndex = 22;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SectionsButton
            // 
            this.SectionsButton.AutoSize = true;
            this.SectionsButton.BackColor = System.Drawing.Color.Transparent;
            this.SectionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SectionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.SectionsButton.FlatAppearance.BorderSize = 2;
            this.SectionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.SectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SectionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionsButton.ForeColor = System.Drawing.Color.White;
            this.SectionsButton.Image = global::Student_Management_System.Properties.Resources.if_sections_216718;
            this.SectionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SectionsButton.Location = new System.Drawing.Point(79, 2);
            this.SectionsButton.Name = "SectionsButton";
            this.SectionsButton.Size = new System.Drawing.Size(78, 50);
            this.SectionsButton.TabIndex = 25;
            this.SectionsButton.Text = "Sections";
            this.SectionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SectionsButton.UseVisualStyleBackColor = false;
            this.SectionsButton.Click += new System.EventHandler(this.SectionsButton_Click);
            // 
            // ExamsButton
            // 
            this.ExamsButton.AutoSize = true;
            this.ExamsButton.BackColor = System.Drawing.Color.Transparent;
            this.ExamsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExamsButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.ExamsButton.FlatAppearance.BorderSize = 2;
            this.ExamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ExamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamsButton.ForeColor = System.Drawing.Color.White;
            this.ExamsButton.Image = global::Student_Management_System.Properties.Resources.if_document_309087;
            this.ExamsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExamsButton.Location = new System.Drawing.Point(310, 2);
            this.ExamsButton.Name = "ExamsButton";
            this.ExamsButton.Size = new System.Drawing.Size(78, 50);
            this.ExamsButton.TabIndex = 28;
            this.ExamsButton.Text = "Exams";
            this.ExamsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExamsButton.UseVisualStyleBackColor = false;
            this.ExamsButton.Click += new System.EventHandler(this.ExamsButton_Click);
            // 
            // ClassesButton
            // 
            this.ClassesButton.AutoSize = true;
            this.ClassesButton.BackColor = System.Drawing.Color.Transparent;
            this.ClassesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.ClassesButton.FlatAppearance.BorderSize = 2;
            this.ClassesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ClassesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesButton.ForeColor = System.Drawing.Color.White;
            this.ClassesButton.Image = global::Student_Management_System.Properties.Resources.if_ic_class_48px_352268;
            this.ClassesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassesButton.Location = new System.Drawing.Point(156, 2);
            this.ClassesButton.Name = "ClassesButton";
            this.ClassesButton.Size = new System.Drawing.Size(78, 50);
            this.ClassesButton.TabIndex = 26;
            this.ClassesButton.Text = "Classes";
            this.ClassesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassesButton.UseVisualStyleBackColor = false;
            this.ClassesButton.Click += new System.EventHandler(this.ClassesButton_Click);
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.AutoSize = true;
            this.SubjectsButton.BackColor = System.Drawing.Color.Transparent;
            this.SubjectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.SubjectsButton.FlatAppearance.BorderSize = 2;
            this.SubjectsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.SubjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsButton.ForeColor = System.Drawing.Color.White;
            this.SubjectsButton.Image = global::Student_Management_System.Properties.Resources.if_editor_books_library_collection_glyph_763199;
            this.SubjectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsButton.Location = new System.Drawing.Point(233, 2);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(78, 50);
            this.SubjectsButton.TabIndex = 27;
            this.SubjectsButton.Text = "Subjects";
            this.SubjectsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubjectsButton.UseVisualStyleBackColor = false;
            this.SubjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.BackgroundImage = global::Student_Management_System.Properties.Resources.IMG_20180901_184342;
            this.ContentsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentsPanel.Controls.Add(this.label2);
            this.ContentsPanel.Controls.Add(this.label1);
            this.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentsPanel.Location = new System.Drawing.Point(0, 49);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Size = new System.Drawing.Size(890, 480);
            this.ContentsPanel.TabIndex = 30;
            this.ContentsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentsPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on TABs to get started";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Student Management System";
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(890, 529);
            this.Controls.Add(this.ContentsPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContentsPanel.ResumeLayout(false);
            this.ContentsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button SectionsButton;
        private System.Windows.Forms.Button ClassesButton;
        private System.Windows.Forms.Button SubjectsButton;
        private System.Windows.Forms.Button ExamsButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel ContentsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}