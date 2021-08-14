namespace PrisonManagementSystem
{
    partial class PrisonerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrisonerPage));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_bloodGrp = new System.Windows.Forms.ComboBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txt_emergencycontact = new System.Windows.Forms.TextBox();
            this.txt_prisoner_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrisonerGridView = new System.Windows.Forms.DataGridView();
            this.prisonerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalcondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencycontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimedetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrancedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_medicalcondition = new System.Windows.Forms.ComboBox();
            this.cmb_maritalstatus = new System.Windows.Forms.ComboBox();
            this.cmb_religion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dtp_releasedate = new System.Windows.Forms.DateTimePicker();
            this.dtp_entrancedate = new System.Windows.Forms.DateTimePicker();
            this.txt_crimedetails = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(1161, 66);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(241, 28);
            this.txt_search.TabIndex = 28;
            // 
            // cmb_bloodGrp
            // 
            this.cmb_bloodGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bloodGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bloodGrp.FormattingEnabled = true;
            this.cmb_bloodGrp.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmb_bloodGrp.Location = new System.Drawing.Point(604, 297);
            this.cmb_bloodGrp.Name = "cmb_bloodGrp";
            this.cmb_bloodGrp.Size = new System.Drawing.Size(344, 28);
            this.cmb_bloodGrp.TabIndex = 27;
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_gender.Location = new System.Drawing.Point(604, 263);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(344, 28);
            this.cmb_gender.TabIndex = 26;
            // 
            // dtp_dateofbirth
            // 
            this.dtp_dateofbirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofbirth.Location = new System.Drawing.Point(604, 131);
            this.dtp_dateofbirth.Name = "dtp_dateofbirth";
            this.dtp_dateofbirth.Size = new System.Drawing.Size(344, 22);
            this.dtp_dateofbirth.TabIndex = 25;
            // 
            // txt_emergencycontact
            // 
            this.txt_emergencycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emergencycontact.Location = new System.Drawing.Point(604, 399);
            this.txt_emergencycontact.Name = "txt_emergencycontact";
            this.txt_emergencycontact.Size = new System.Drawing.Size(344, 27);
            this.txt_emergencycontact.TabIndex = 21;
            // 
            // txt_prisoner_id
            // 
            this.txt_prisoner_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prisoner_id.Location = new System.Drawing.Point(604, 65);
            this.txt_prisoner_id.Name = "txt_prisoner_id";
            this.txt_prisoner_id.Size = new System.Drawing.Size(344, 27);
            this.txt_prisoner_id.TabIndex = 24;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(604, 98);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(344, 27);
            this.txt_name.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(373, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Emergency Contact:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(373, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Blood Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(373, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(372, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prisoner ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1034, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.Location = new System.Drawing.Point(1034, 212);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(183, 74);
            this.btn_view_all.TabIndex = 2;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(1223, 212);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(179, 74);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1288, 117);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 73);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1161, 117);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 73);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(11, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 32);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisoner";
            // 
            // PrisonerGridView
            // 
            this.PrisonerGridView.AllowUserToAddRows = false;
            this.PrisonerGridView.AllowUserToDeleteRows = false;
            this.PrisonerGridView.BackgroundColor = System.Drawing.Color.White;
            this.PrisonerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrisonerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prisonerid,
            this.name,
            this.dateofbirth,
            this.address,
            this.religion,
            this.gender,
            this.bloodgroup,
            this.maritalstatus,
            this.medicalcondition,
            this.emergencycontact,
            this.crimedetails,
            this.entrancedate,
            this.releasedate});
            this.PrisonerGridView.Location = new System.Drawing.Point(25, 532);
            this.PrisonerGridView.Name = "PrisonerGridView";
            this.PrisonerGridView.ReadOnly = true;
            this.PrisonerGridView.RowHeadersWidth = 51;
            this.PrisonerGridView.RowTemplate.Height = 24;
            this.PrisonerGridView.Size = new System.Drawing.Size(1387, 281);
            this.PrisonerGridView.TabIndex = 0;
            this.PrisonerGridView.DoubleClick += new System.EventHandler(this.PrisonerGridView_DoubleClick);
            // 
            // prisonerid
            // 
            this.prisonerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prisonerid.DataPropertyName = "prisonerid";
            this.prisonerid.HeaderText = "PRISONER ID";
            this.prisonerid.MinimumWidth = 6;
            this.prisonerid.Name = "prisonerid";
            this.prisonerid.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DATE OF BIRTH";
            this.dateofbirth.MinimumWidth = 6;
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "RELIGION";
            this.religion.MinimumWidth = 6;
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BLOOD GROUP";
            this.bloodgroup.MinimumWidth = 6;
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // maritalstatus
            // 
            this.maritalstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maritalstatus.DataPropertyName = "maritalstatus";
            this.maritalstatus.HeaderText = "MARITAL STATUS";
            this.maritalstatus.MinimumWidth = 6;
            this.maritalstatus.Name = "maritalstatus";
            this.maritalstatus.ReadOnly = true;
            // 
            // medicalcondition
            // 
            this.medicalcondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicalcondition.DataPropertyName = "medicalcondition";
            this.medicalcondition.HeaderText = "MEDICAL CONDITION";
            this.medicalcondition.MinimumWidth = 6;
            this.medicalcondition.Name = "medicalcondition";
            this.medicalcondition.ReadOnly = true;
            // 
            // emergencycontact
            // 
            this.emergencycontact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emergencycontact.DataPropertyName = "emergencycontact";
            this.emergencycontact.HeaderText = "EMERGENCY CONTACT";
            this.emergencycontact.MinimumWidth = 6;
            this.emergencycontact.Name = "emergencycontact";
            this.emergencycontact.ReadOnly = true;
            // 
            // crimedetails
            // 
            this.crimedetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.crimedetails.DataPropertyName = "crimedetails";
            this.crimedetails.HeaderText = "CRIME DETAILS";
            this.crimedetails.MinimumWidth = 6;
            this.crimedetails.Name = "crimedetails";
            this.crimedetails.ReadOnly = true;
            // 
            // entrancedate
            // 
            this.entrancedate.DataPropertyName = "entrancedate";
            this.entrancedate.HeaderText = "ENTRANCE DATE";
            this.entrancedate.MinimumWidth = 6;
            this.entrancedate.Name = "entrancedate";
            this.entrancedate.ReadOnly = true;
            this.entrancedate.Width = 125;
            // 
            // releasedate
            // 
            this.releasedate.DataPropertyName = "releasedate";
            this.releasedate.HeaderText = "RELEASE DATE";
            this.releasedate.MinimumWidth = 6;
            this.releasedate.Name = "releasedate";
            this.releasedate.ReadOnly = true;
            this.releasedate.Width = 125;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1034, 117);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 73);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.cmb_medicalcondition);
            this.panel1.Controls.Add(this.cmb_maritalstatus);
            this.panel1.Controls.Add(this.cmb_bloodGrp);
            this.panel1.Controls.Add(this.cmb_religion);
            this.panel1.Controls.Add(this.cmb_gender);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dtp_releasedate);
            this.panel1.Controls.Add(this.dtp_entrancedate);
            this.panel1.Controls.Add(this.dtp_dateofbirth);
            this.panel1.Controls.Add(this.txt_emergencycontact);
            this.panel1.Controls.Add(this.txt_crimedetails);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.txt_prisoner_id);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_view_all);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrisonerGridView);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 991);
            this.panel1.TabIndex = 1;
            // 
            // cmb_medicalcondition
            // 
            this.cmb_medicalcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_medicalcondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_medicalcondition.FormattingEnabled = true;
            this.cmb_medicalcondition.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Hospitalized"});
            this.cmb_medicalcondition.Location = new System.Drawing.Point(604, 365);
            this.cmb_medicalcondition.Name = "cmb_medicalcondition";
            this.cmb_medicalcondition.Size = new System.Drawing.Size(344, 28);
            this.cmb_medicalcondition.TabIndex = 27;
            // 
            // cmb_maritalstatus
            // 
            this.cmb_maritalstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maritalstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_maritalstatus.FormattingEnabled = true;
            this.cmb_maritalstatus.Items.AddRange(new object[] {
            "Unmarried",
            "Married"});
            this.cmb_maritalstatus.Location = new System.Drawing.Point(604, 331);
            this.cmb_maritalstatus.Name = "cmb_maritalstatus";
            this.cmb_maritalstatus.Size = new System.Drawing.Size(344, 28);
            this.cmb_maritalstatus.TabIndex = 27;
            // 
            // cmb_religion
            // 
            this.cmb_religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_religion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_religion.FormattingEnabled = true;
            this.cmb_religion.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Cristian",
            "Buddhist",
            "Others"});
            this.cmb_religion.Location = new System.Drawing.Point(604, 229);
            this.cmb_religion.Name = "cmb_religion";
            this.cmb_religion.Size = new System.Drawing.Size(344, 28);
            this.cmb_religion.TabIndex = 26;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(-491, 92);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(344, 22);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // dtp_releasedate
            // 
            this.dtp_releasedate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_releasedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_releasedate.Location = new System.Drawing.Point(604, 460);
            this.dtp_releasedate.Name = "dtp_releasedate";
            this.dtp_releasedate.Size = new System.Drawing.Size(344, 22);
            this.dtp_releasedate.TabIndex = 25;
            // 
            // dtp_entrancedate
            // 
            this.dtp_entrancedate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_entrancedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrancedate.Location = new System.Drawing.Point(604, 432);
            this.dtp_entrancedate.Name = "dtp_entrancedate";
            this.dtp_entrancedate.Size = new System.Drawing.Size(344, 22);
            this.dtp_entrancedate.TabIndex = 25;
            // 
            // txt_crimedetails
            // 
            this.txt_crimedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crimedetails.Location = new System.Drawing.Point(30, 102);
            this.txt_crimedetails.Multiline = true;
            this.txt_crimedetails.Name = "txt_crimedetails";
            this.txt_crimedetails.Size = new System.Drawing.Size(304, 377);
            this.txt_crimedetails.TabIndex = 24;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(604, 159);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(344, 64);
            this.txt_address.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(373, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Madical Condition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(372, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Marital Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Religion:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-988, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Date Of Birth:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-480, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Date Of Birth:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(373, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Release Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(372, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Entrance Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(89, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Crime Details";
            // 
            // PrisonerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 990);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrisonerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrisonerPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_bloodGrp;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.DateTimePicker dtp_dateofbirth;
        private System.Windows.Forms.TextBox txt_emergencycontact;
        private System.Windows.Forms.TextBox txt_prisoner_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PrisonerGridView;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_medicalcondition;
        private System.Windows.Forms.ComboBox cmb_maritalstatus;
        private System.Windows.Forms.ComboBox cmb_religion;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dtp_releasedate;
        private System.Windows.Forms.DateTimePicker dtp_entrancedate;
        private System.Windows.Forms.TextBox txt_crimedetails;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisonerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalcondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencycontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn crimedetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrancedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedate;
    }
}