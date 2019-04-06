namespace Student_Management_System.UCs
{
    partial class Section_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SSIDTextField = new System.Windows.Forms.TextBox();
            this.SemesterTextField = new System.Windows.Forms.TextBox();
            this.ClearedLabel = new System.Windows.Forms.Label();
            this.RefreshStatusLabel = new System.Windows.Forms.Label();
            this.DeleteStatusLabel = new System.Windows.Forms.Label();
            this.AddStatusLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SectionTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(81, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "SSID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(302, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Semester :";
            // 
            // SSIDTextField
            // 
            this.SSIDTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SSIDTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SSIDTextField.Location = new System.Drawing.Point(125, 318);
            this.SSIDTextField.Name = "SSIDTextField";
            this.SSIDTextField.Size = new System.Drawing.Size(158, 20);
            this.SSIDTextField.TabIndex = 43;
            this.SSIDTextField.MouseLeave += new System.EventHandler(this.SSIDTextField_MouseLeave);
            this.SSIDTextField.MouseHover += new System.EventHandler(this.SSIDTextField_MouseHover);
            // 
            // SemesterTextField
            // 
            this.SemesterTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SemesterTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SemesterTextField.Location = new System.Drawing.Point(365, 317);
            this.SemesterTextField.Name = "SemesterTextField";
            this.SemesterTextField.Size = new System.Drawing.Size(158, 20);
            this.SemesterTextField.TabIndex = 42;
            this.SemesterTextField.MouseLeave += new System.EventHandler(this.SemesterTextField_MouseLeave);
            this.SemesterTextField.MouseHover += new System.EventHandler(this.SemesterTextField_MouseHover);
            // 
            // ClearedLabel
            // 
            this.ClearedLabel.AutoSize = true;
            this.ClearedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClearedLabel.ForeColor = System.Drawing.Color.Green;
            this.ClearedLabel.Location = new System.Drawing.Point(693, 415);
            this.ClearedLabel.Name = "ClearedLabel";
            this.ClearedLabel.Size = new System.Drawing.Size(43, 13);
            this.ClearedLabel.TabIndex = 51;
            this.ClearedLabel.Text = "Cleared";
            this.ClearedLabel.Visible = false;
            // 
            // RefreshStatusLabel
            // 
            this.RefreshStatusLabel.AutoSize = true;
            this.RefreshStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.RefreshStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.RefreshStatusLabel.Location = new System.Drawing.Point(502, 415);
            this.RefreshStatusLabel.Name = "RefreshStatusLabel";
            this.RefreshStatusLabel.Size = new System.Drawing.Size(77, 13);
            this.RefreshStatusLabel.TabIndex = 52;
            this.RefreshStatusLabel.Text = "View refreshed";
            this.RefreshStatusLabel.Visible = false;
            // 
            // DeleteStatusLabel
            // 
            this.DeleteStatusLabel.AutoSize = true;
            this.DeleteStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.DeleteStatusLabel.Location = new System.Drawing.Point(317, 415);
            this.DeleteStatusLabel.Name = "DeleteStatusLabel";
            this.DeleteStatusLabel.Size = new System.Drawing.Size(108, 13);
            this.DeleteStatusLabel.TabIndex = 53;
            this.DeleteStatusLabel.Text = "Updated successfully";
            this.DeleteStatusLabel.Visible = false;
            // 
            // AddStatusLabel
            // 
            this.AddStatusLabel.AutoSize = true;
            this.AddStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.AddStatusLabel.Location = new System.Drawing.Point(154, 415);
            this.AddStatusLabel.Name = "AddStatusLabel";
            this.AddStatusLabel.Size = new System.Drawing.Size(98, 13);
            this.AddStatusLabel.TabIndex = 50;
            this.AddStatusLabel.Text = "Added successfully";
            this.AddStatusLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = global::Student_Management_System.Properties.Resources.if_broom_stick_3_896656;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(660, 373);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 29);
            this.ClearButton.TabIndex = 49;
            this.ClearButton.Text = "Clear Fields";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RefreshButton.FlatAppearance.BorderSize = 2;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Image = global::Student_Management_System.Properties.Resources.if_Update_984748;
            this.RefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshButton.Location = new System.Drawing.Point(490, 373);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(102, 29);
            this.RefreshButton.TabIndex = 48;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::Student_Management_System.Properties.Resources.if_ic_delete_48px_352303;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(320, 373);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 29);
            this.DeleteButton.TabIndex = 47;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::Student_Management_System.Properties.Resources.if_More_372914;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(150, 373);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 29);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SectionTextField
            // 
            this.SectionTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SectionTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SectionTextField.Location = new System.Drawing.Point(605, 317);
            this.SectionTextField.Name = "SectionTextField";
            this.SectionTextField.Size = new System.Drawing.Size(158, 20);
            this.SectionTextField.TabIndex = 42;
            this.SectionTextField.MouseLeave += new System.EventHandler(this.SectionTextField_MouseLeave);
            this.SectionTextField.MouseHover += new System.EventHandler(this.SectionTextField_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(550, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Section :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 158);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 26);
            this.label4.TabIndex = 68;
            this.label4.Text = "Semesters and Sections Details";
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel3.Location = new System.Drawing.Point(122, 302);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(136, 13);
            this.infoLabel3.TabIndex = 73;
            this.infoLabel3.Text = "Not more than 5 characters";
            this.infoLabel3.Visible = false;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel1.Location = new System.Drawing.Point(602, 302);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(131, 13);
            this.infoLabel1.TabIndex = 73;
            this.infoLabel1.Text = "Not more than 1 character";
            this.infoLabel1.Visible = false;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel2.Location = new System.Drawing.Point(362, 302);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(136, 13);
            this.infoLabel2.TabIndex = 73;
            this.infoLabel2.Text = "Not more than 2 characters";
            this.infoLabel2.Visible = false;
            // 
            // Section_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearedLabel);
            this.Controls.Add(this.RefreshStatusLabel);
            this.Controls.Add(this.DeleteStatusLabel);
            this.Controls.Add(this.AddStatusLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSIDTextField);
            this.Controls.Add(this.SectionTextField);
            this.Controls.Add(this.SemesterTextField);
            this.Name = "Section_UC";
            this.Size = new System.Drawing.Size(890, 480);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Section_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SSIDTextField;
        private System.Windows.Forms.TextBox SemesterTextField;
        private System.Windows.Forms.Label ClearedLabel;
        private System.Windows.Forms.Label RefreshStatusLabel;
        private System.Windows.Forms.Label DeleteStatusLabel;
        private System.Windows.Forms.Label AddStatusLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SectionTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
    }
}
