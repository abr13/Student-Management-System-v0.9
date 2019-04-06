namespace Student_Management_System.UCs
{
    partial class Settings_UC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTextField = new System.Windows.Forms.TextBox();
            this.NameTextField = new System.Windows.Forms.TextBox();
            this.UsernameTextField = new System.Windows.Forms.TextBox();
            this.PasswordTextField = new System.Windows.Forms.TextBox();
            this.PhoneTextField = new System.Windows.Forms.TextBox();
            this.DeleteStatusLabel = new System.Windows.Forms.Label();
            this.UpdateStatusLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "Settings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 150);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDTextField
            // 
            this.IDTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IDTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDTextField.Location = new System.Drawing.Point(74, 258);
            this.IDTextField.Name = "IDTextField";
            this.IDTextField.Size = new System.Drawing.Size(138, 20);
            this.IDTextField.TabIndex = 71;
            // 
            // NameTextField
            // 
            this.NameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameTextField.Location = new System.Drawing.Point(74, 308);
            this.NameTextField.Name = "NameTextField";
            this.NameTextField.Size = new System.Drawing.Size(138, 20);
            this.NameTextField.TabIndex = 72;
            // 
            // UsernameTextField
            // 
            this.UsernameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UsernameTextField.Location = new System.Drawing.Point(74, 358);
            this.UsernameTextField.Name = "UsernameTextField";
            this.UsernameTextField.Size = new System.Drawing.Size(138, 20);
            this.UsernameTextField.TabIndex = 73;
            // 
            // PasswordTextField
            // 
            this.PasswordTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordTextField.Location = new System.Drawing.Point(288, 258);
            this.PasswordTextField.Name = "PasswordTextField";
            this.PasswordTextField.PasswordChar = '*';
            this.PasswordTextField.Size = new System.Drawing.Size(148, 20);
            this.PasswordTextField.TabIndex = 74;
            // 
            // PhoneTextField
            // 
            this.PhoneTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneTextField.Location = new System.Drawing.Point(288, 308);
            this.PhoneTextField.Name = "PhoneTextField";
            this.PhoneTextField.Size = new System.Drawing.Size(148, 20);
            this.PhoneTextField.TabIndex = 75;
            // 
            // DeleteStatusLabel
            // 
            this.DeleteStatusLabel.AutoSize = true;
            this.DeleteStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.DeleteStatusLabel.Location = new System.Drawing.Point(266, 448);
            this.DeleteStatusLabel.Name = "DeleteStatusLabel";
            this.DeleteStatusLabel.Size = new System.Drawing.Size(104, 13);
            this.DeleteStatusLabel.TabIndex = 78;
            this.DeleteStatusLabel.Text = "Deleted successfully";
            this.DeleteStatusLabel.Visible = false;
            // 
            // UpdateStatusLabel
            // 
            this.UpdateStatusLabel.AutoSize = true;
            this.UpdateStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.UpdateStatusLabel.Location = new System.Drawing.Point(107, 448);
            this.UpdateStatusLabel.Name = "UpdateStatusLabel";
            this.UpdateStatusLabel.Size = new System.Drawing.Size(108, 13);
            this.UpdateStatusLabel.TabIndex = 79;
            this.UpdateStatusLabel.Text = "Updated successfully";
            this.UpdateStatusLabel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::Student_Management_System.Properties.Resources.if_block_user_678157;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(269, 406);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 29);
            this.DeleteButton.TabIndex = 76;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateButton.FlatAppearance.BorderSize = 2;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Image = global::Student_Management_System.Properties.Resources.if_icons_update_1564533;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(110, 406);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 29);
            this.UpdateButton.TabIndex = 77;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.UpdateButton_MouseLeave);
            this.UpdateButton.MouseHover += new System.EventHandler(this.UpdateButton_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(44, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(223, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(238, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Phone :";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel.Location = new System.Drawing.Point(151, 390);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(210, 13);
            this.infoLabel.TabIndex = 81;
            this.infoLabel.Text = "Only Phone and Password can be updated";
            this.infoLabel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(455, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(413, 150);
            this.dataGridView2.TabIndex = 82;
            // 
            // clearLogButton
            // 
            this.clearLogButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearLogButton.FlatAppearance.BorderSize = 2;
            this.clearLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.clearLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLogButton.Image = global::Student_Management_System.Properties.Resources.if_broom_stick_3_896656;
            this.clearLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearLogButton.Location = new System.Drawing.Point(689, 272);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(102, 29);
            this.clearLogButton.TabIndex = 83;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = false;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewLogButton.FlatAppearance.BorderSize = 2;
            this.viewLogButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.viewLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogButton.Image = global::Student_Management_System.Properties.Resources.if_document_309087;
            this.viewLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewLogButton.Location = new System.Drawing.Point(540, 272);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(102, 29);
            this.viewLogButton.TabIndex = 84;
            this.viewLogButton.Text = "View";
            this.viewLogButton.UseVisualStyleBackColor = false;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(691, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Deleted successfully";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "Administrators Informations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(612, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "Log History";
            // 
            // Settings_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.bg6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteStatusLabel);
            this.Controls.Add(this.UpdateStatusLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PhoneTextField);
            this.Controls.Add(this.PasswordTextField);
            this.Controls.Add(this.UsernameTextField);
            this.Controls.Add(this.NameTextField);
            this.Controls.Add(this.IDTextField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Settings_UC";
            this.Size = new System.Drawing.Size(890, 480);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Settings_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDTextField;
        private System.Windows.Forms.TextBox NameTextField;
        private System.Windows.Forms.TextBox UsernameTextField;
        private System.Windows.Forms.TextBox PasswordTextField;
        private System.Windows.Forms.TextBox PhoneTextField;
        private System.Windows.Forms.Label DeleteStatusLabel;
        private System.Windows.Forms.Label UpdateStatusLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
