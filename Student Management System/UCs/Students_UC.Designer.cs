namespace Student_Management_System.UCs
{
    partial class Students_UC
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
            this.SearchStatusLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchNameTextField = new System.Windows.Forms.TextBox();
            this.SearchUSNTextField = new System.Windows.Forms.TextBox();
            this.ClearedLabel = new System.Windows.Forms.Label();
            this.RefreshedLabel = new System.Windows.Forms.Label();
            this.UpdateStatusLabel = new System.Windows.Forms.Label();
            this.AddedLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteStatusLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTextField = new System.Windows.Forms.TextBox();
            this.AddressTextField = new System.Windows.Forms.TextBox();
            this.NameTextField = new System.Windows.Forms.TextBox();
            this.USNTextField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.infoLabel5 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchStatusLabel
            // 
            this.SearchStatusLabel.AutoSize = true;
            this.SearchStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.SearchStatusLabel.Location = new System.Drawing.Point(625, 87);
            this.SearchStatusLabel.Name = "SearchStatusLabel";
            this.SearchStatusLabel.Size = new System.Drawing.Size(96, 13);
            this.SearchStatusLabel.TabIndex = 48;
            this.SearchStatusLabel.Text = "Search completed!";
            this.SearchStatusLabel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Student_Management_System.Properties.Resources.if_search_322497;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(620, 52);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(102, 29);
            this.SearchButton.TabIndex = 47;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(387, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "or Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(164, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "USN :";
            // 
            // SearchNameTextField
            // 
            this.SearchNameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchNameTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchNameTextField.Location = new System.Drawing.Point(446, 57);
            this.SearchNameTextField.Name = "SearchNameTextField";
            this.SearchNameTextField.Size = new System.Drawing.Size(158, 20);
            this.SearchNameTextField.TabIndex = 44;
            this.SearchNameTextField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchNameTextField_MouseClick);
            this.SearchNameTextField.TextChanged += new System.EventHandler(this.SearchNameTextField_TextChanged);
            this.SearchNameTextField.MouseLeave += new System.EventHandler(this.SearchNameTextField_MouseLeave);
            this.SearchNameTextField.MouseHover += new System.EventHandler(this.SearchNameTextField_MouseHover);
            // 
            // SearchUSNTextField
            // 
            this.SearchUSNTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchUSNTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchUSNTextField.Location = new System.Drawing.Point(207, 57);
            this.SearchUSNTextField.Name = "SearchUSNTextField";
            this.SearchUSNTextField.Size = new System.Drawing.Size(158, 20);
            this.SearchUSNTextField.TabIndex = 43;
            this.SearchUSNTextField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchUSNTextField_MouseClick);
            this.SearchUSNTextField.TextChanged += new System.EventHandler(this.SearchUSNTextField_TextChanged);
            this.SearchUSNTextField.MouseLeave += new System.EventHandler(this.SearchUSNTextField_MouseLeave);
            this.SearchUSNTextField.MouseHover += new System.EventHandler(this.SearchUSNTextField_MouseHover);
            // 
            // ClearedLabel
            // 
            this.ClearedLabel.AutoSize = true;
            this.ClearedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClearedLabel.ForeColor = System.Drawing.Color.Green;
            this.ClearedLabel.Location = new System.Drawing.Point(750, 451);
            this.ClearedLabel.Name = "ClearedLabel";
            this.ClearedLabel.Size = new System.Drawing.Size(43, 13);
            this.ClearedLabel.TabIndex = 54;
            this.ClearedLabel.Text = "Cleared";
            this.ClearedLabel.Visible = false;
            // 
            // RefreshedLabel
            // 
            this.RefreshedLabel.AutoSize = true;
            this.RefreshedLabel.BackColor = System.Drawing.Color.Transparent;
            this.RefreshedLabel.ForeColor = System.Drawing.Color.Green;
            this.RefreshedLabel.Location = new System.Drawing.Point(573, 451);
            this.RefreshedLabel.Name = "RefreshedLabel";
            this.RefreshedLabel.Size = new System.Drawing.Size(77, 13);
            this.RefreshedLabel.TabIndex = 55;
            this.RefreshedLabel.Text = "View refreshed";
            this.RefreshedLabel.Visible = false;
            // 
            // UpdateStatusLabel
            // 
            this.UpdateStatusLabel.AutoSize = true;
            this.UpdateStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.UpdateStatusLabel.Location = new System.Drawing.Point(236, 451);
            this.UpdateStatusLabel.Name = "UpdateStatusLabel";
            this.UpdateStatusLabel.Size = new System.Drawing.Size(108, 13);
            this.UpdateStatusLabel.TabIndex = 56;
            this.UpdateStatusLabel.Text = "Updated successfully";
            this.UpdateStatusLabel.Visible = false;
            // 
            // AddedLabel
            // 
            this.AddedLabel.AutoSize = true;
            this.AddedLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddedLabel.ForeColor = System.Drawing.Color.Green;
            this.AddedLabel.Location = new System.Drawing.Point(77, 451);
            this.AddedLabel.Name = "AddedLabel";
            this.AddedLabel.Size = new System.Drawing.Size(98, 13);
            this.AddedLabel.TabIndex = 53;
            this.AddedLabel.Text = "Added successfully";
            this.AddedLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = global::Student_Management_System.Properties.Resources.if_broom_stick_3_896656;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(716, 409);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 29);
            this.ClearButton.TabIndex = 52;
            this.ClearButton.Text = "Clear Fields";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RefreshButton.FlatAppearance.BorderSize = 2;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Image = global::Student_Management_System.Properties.Resources.if_Update_984748;
            this.RefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshButton.Location = new System.Drawing.Point(557, 409);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(102, 29);
            this.RefreshButton.TabIndex = 51;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.UpdateButton.Location = new System.Drawing.Point(239, 409);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 29);
            this.UpdateButton.TabIndex = 50;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseLeave += new System.EventHandler(this.UpdateButton_MouseLeave);
            this.UpdateButton.MouseHover += new System.EventHandler(this.UpdateButton_MouseHover);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::Student_Management_System.Properties.Resources.if_user_add_216490;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(80, 409);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 29);
            this.AddButton.TabIndex = 49;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.DeleteButton.Location = new System.Drawing.Point(398, 409);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 29);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteStatusLabel
            // 
            this.DeleteStatusLabel.AutoSize = true;
            this.DeleteStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.DeleteStatusLabel.Location = new System.Drawing.Point(395, 451);
            this.DeleteStatusLabel.Name = "DeleteStatusLabel";
            this.DeleteStatusLabel.Size = new System.Drawing.Size(104, 13);
            this.DeleteStatusLabel.TabIndex = 56;
            this.DeleteStatusLabel.Text = "Deleted successfully";
            this.DeleteStatusLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 158);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(474, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(110, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(125, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "USN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(120, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Name :";
            // 
            // PhoneTextField
            // 
            this.PhoneTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhoneTextField.Location = new System.Drawing.Point(524, 284);
            this.PhoneTextField.Name = "PhoneTextField";
            this.PhoneTextField.Size = new System.Drawing.Size(198, 20);
            this.PhoneTextField.TabIndex = 58;
            this.PhoneTextField.MouseLeave += new System.EventHandler(this.PhoneTextField_MouseLeave);
            this.PhoneTextField.MouseHover += new System.EventHandler(this.PhoneTextField_MouseHover);
            // 
            // AddressTextField
            // 
            this.AddressTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddressTextField.Location = new System.Drawing.Point(167, 365);
            this.AddressTextField.Name = "AddressTextField";
            this.AddressTextField.Size = new System.Drawing.Size(198, 20);
            this.AddressTextField.TabIndex = 59;
            this.AddressTextField.MouseLeave += new System.EventHandler(this.AddressTextField_MouseLeave);
            this.AddressTextField.MouseHover += new System.EventHandler(this.AddressTextField_MouseHover);
            // 
            // NameTextField
            // 
            this.NameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameTextField.Location = new System.Drawing.Point(167, 324);
            this.NameTextField.Name = "NameTextField";
            this.NameTextField.Size = new System.Drawing.Size(198, 20);
            this.NameTextField.TabIndex = 60;
            this.NameTextField.MouseLeave += new System.EventHandler(this.NameTextField_MouseLeave);
            this.NameTextField.MouseHover += new System.EventHandler(this.NameTextField_MouseHover);
            // 
            // USNTextField
            // 
            this.USNTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.USNTextField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.USNTextField.Location = new System.Drawing.Point(167, 284);
            this.USNTextField.Name = "USNTextField";
            this.USNTextField.Size = new System.Drawing.Size(198, 20);
            this.USNTextField.TabIndex = 61;
            this.USNTextField.TextChanged += new System.EventHandler(this.USNTextField_TextChanged);
            this.USNTextField.MouseLeave += new System.EventHandler(this.USNTextField_MouseLeave);
            this.USNTextField.MouseHover += new System.EventHandler(this.USNTextField_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(469, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender :";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.GenderComboBox.Location = new System.Drawing.Point(524, 324);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(198, 21);
            this.GenderComboBox.Sorted = true;
            this.GenderComboBox.TabIndex = 66;
            this.GenderComboBox.Text = "Choose one...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "Students Details";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel.Location = new System.Drawing.Point(279, 391);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(140, 13);
            this.infoLabel.TabIndex = 71;
            this.infoLabel.Text = "Only Phone can be updated";
            this.infoLabel.Visible = false;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel1.Location = new System.Drawing.Point(204, 41);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(142, 13);
            this.infoLabel1.TabIndex = 72;
            this.infoLabel1.Text = "Not more than 10 characters";
            this.infoLabel1.Visible = false;
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel3.Location = new System.Drawing.Point(164, 268);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(142, 13);
            this.infoLabel3.TabIndex = 72;
            this.infoLabel3.Text = "Not more than 10 characters";
            this.infoLabel3.Visible = false;
            // 
            // infoLabel4
            // 
            this.infoLabel4.AutoSize = true;
            this.infoLabel4.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel4.Location = new System.Drawing.Point(164, 308);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(142, 13);
            this.infoLabel4.TabIndex = 72;
            this.infoLabel4.Text = "Not more than 15 characters";
            this.infoLabel4.Visible = false;
            // 
            // infoLabel5
            // 
            this.infoLabel5.AutoSize = true;
            this.infoLabel5.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel5.Location = new System.Drawing.Point(164, 349);
            this.infoLabel5.Name = "infoLabel5";
            this.infoLabel5.Size = new System.Drawing.Size(142, 13);
            this.infoLabel5.TabIndex = 72;
            this.infoLabel5.Text = "Not more than 50 characters";
            this.infoLabel5.Visible = false;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel2.Location = new System.Drawing.Point(443, 41);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(142, 13);
            this.infoLabel2.TabIndex = 72;
            this.infoLabel2.Text = "Not more than 15 characters";
            this.infoLabel2.Visible = false;
            // 
            // infoLabel6
            // 
            this.infoLabel6.AutoSize = true;
            this.infoLabel6.BackColor = System.Drawing.Color.Khaki;
            this.infoLabel6.Location = new System.Drawing.Point(521, 268);
            this.infoLabel6.Name = "infoLabel6";
            this.infoLabel6.Size = new System.Drawing.Size(142, 13);
            this.infoLabel6.TabIndex = 72;
            this.infoLabel6.Text = "Not more than 13 characters";
            this.infoLabel6.Visible = false;
            // 
            // Students_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.infoLabel6);
            this.Controls.Add(this.infoLabel5);
            this.Controls.Add(this.infoLabel4);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTextField);
            this.Controls.Add(this.AddressTextField);
            this.Controls.Add(this.NameTextField);
            this.Controls.Add(this.USNTextField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearedLabel);
            this.Controls.Add(this.RefreshedLabel);
            this.Controls.Add(this.DeleteStatusLabel);
            this.Controls.Add(this.UpdateStatusLabel);
            this.Controls.Add(this.AddedLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchStatusLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchNameTextField);
            this.Controls.Add(this.SearchUSNTextField);
            this.Name = "Students_UC";
            this.Size = new System.Drawing.Size(890, 480);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Students_UC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchStatusLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchNameTextField;
        private System.Windows.Forms.TextBox SearchUSNTextField;
        private System.Windows.Forms.Label ClearedLabel;
        private System.Windows.Forms.Label RefreshedLabel;
        private System.Windows.Forms.Label UpdateStatusLabel;
        private System.Windows.Forms.Label AddedLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteStatusLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneTextField;
        private System.Windows.Forms.TextBox AddressTextField;
        private System.Windows.Forms.TextBox NameTextField;
        private System.Windows.Forms.TextBox USNTextField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel4;
        private System.Windows.Forms.Label infoLabel5;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel6;
    }
}
