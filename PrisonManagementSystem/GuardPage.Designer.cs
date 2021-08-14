namespace PrisonManagementSystem
{
    partial class GuardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardPage));
            this.mobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_bloodGrp = new System.Windows.Forms.ComboBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txt_passportno = new System.Windows.Forms.TextBox();
            this.txt_nidno = new System.Windows.Forms.TextBox();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.txt_ParAddress = new System.Windows.Forms.TextBox();
            this.txt_PreAddress = new System.Windows.Forms.TextBox();
            this.presentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_conPass = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.parmanentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.passportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back_dada_gridview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardPageGridView = new System.Windows.Forms.DataGridView();
            this.nidNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GuardPageGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileNo.DataPropertyName = "mobileno";
            this.mobileNo.HeaderText = "MOBILE NO";
            this.mobileNo.MinimumWidth = 6;
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.ReadOnly = true;
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
            this.cmb_bloodGrp.Location = new System.Drawing.Point(557, 299);
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
            this.cmb_gender.Location = new System.Drawing.Point(557, 258);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(344, 28);
            this.cmb_gender.TabIndex = 26;
            // 
            // dtp_dateofbirth
            // 
            this.dtp_dateofbirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofbirth.Location = new System.Drawing.Point(557, 222);
            this.dtp_dateofbirth.Name = "dtp_dateofbirth";
            this.dtp_dateofbirth.Size = new System.Drawing.Size(344, 22);
            this.dtp_dateofbirth.TabIndex = 25;
            // 
            // txt_passportno
            // 
            this.txt_passportno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passportno.Location = new System.Drawing.Point(557, 473);
            this.txt_passportno.Name = "txt_passportno";
            this.txt_passportno.Size = new System.Drawing.Size(344, 27);
            this.txt_passportno.TabIndex = 23;
            // 
            // txt_nidno
            // 
            this.txt_nidno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nidno.Location = new System.Drawing.Point(557, 440);
            this.txt_nidno.Name = "txt_nidno";
            this.txt_nidno.Size = new System.Drawing.Size(344, 27);
            this.txt_nidno.TabIndex = 22;
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobileno.Location = new System.Drawing.Point(557, 407);
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.Size = new System.Drawing.Size(344, 27);
            this.txt_mobileno.TabIndex = 21;
            // 
            // txt_ParAddress
            // 
            this.txt_ParAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ParAddress.Location = new System.Drawing.Point(557, 373);
            this.txt_ParAddress.Name = "txt_ParAddress";
            this.txt_ParAddress.Size = new System.Drawing.Size(344, 27);
            this.txt_ParAddress.TabIndex = 20;
            // 
            // txt_PreAddress
            // 
            this.txt_PreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PreAddress.Location = new System.Drawing.Point(557, 337);
            this.txt_PreAddress.Name = "txt_PreAddress";
            this.txt_PreAddress.Size = new System.Drawing.Size(344, 27);
            this.txt_PreAddress.TabIndex = 19;
            // 
            // presentAddress
            // 
            this.presentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentAddress.DataPropertyName = "presentaddress";
            this.presentAddress.HeaderText = "PRESENT ADDRESS";
            this.presentAddress.MinimumWidth = 6;
            this.presentAddress.Name = "presentAddress";
            this.presentAddress.ReadOnly = true;
            // 
            // bloodGroup
            // 
            this.bloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodGroup.DataPropertyName = "bloodgroup";
            this.bloodGroup.HeaderText = "BLOOD GROUP";
            this.bloodGroup.MinimumWidth = 6;
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.ReadOnly = true;
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
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirth.DataPropertyName = "dateofbirth";
            this.dateOfBirth.HeaderText = "DATE OF BIRTH";
            this.dateOfBirth.MinimumWidth = 6;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "PASSWORD";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // txt_conPass
            // 
            this.txt_conPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conPass.Location = new System.Drawing.Point(557, 181);
            this.txt_conPass.Name = "txt_conPass";
            this.txt_conPass.Size = new System.Drawing.Size(344, 27);
            this.txt_conPass.TabIndex = 18;
            this.txt_conPass.UseSystemPasswordChar = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(557, 143);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(344, 27);
            this.txt_pass.TabIndex = 17;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(557, 62);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(344, 27);
            this.txt_id.TabIndex = 24;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(557, 104);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(344, 27);
            this.txt_name.TabIndex = 16;
            // 
            // parmanentAddress
            // 
            this.parmanentAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parmanentAddress.DataPropertyName = "parmanentaddress";
            this.parmanentAddress.HeaderText = "PARMANENT ADDRESS";
            this.parmanentAddress.MinimumWidth = 6;
            this.parmanentAddress.Name = "parmanentAddress";
            this.parmanentAddress.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(232, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Passport No:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(232, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "NID No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(232, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mobile No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(232, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Parmanent Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(232, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Present Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(232, 302);
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
            this.label7.Location = new System.Drawing.Point(232, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(232, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Of Birth:";
            // 
            // passportNo
            // 
            this.passportNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passportNo.DataPropertyName = "passportno";
            this.passportNo.HeaderText = "PASSPORT NO";
            this.passportNo.MinimumWidth = 6;
            this.passportNo.Name = "passportNo";
            this.passportNo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(232, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(232, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 104);
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
            // btn_back_dada_gridview
            // 
            this.btn_back_dada_gridview.Location = new System.Drawing.Point(11, 12);
            this.btn_back_dada_gridview.Name = "btn_back_dada_gridview";
            this.btn_back_dada_gridview.Size = new System.Drawing.Size(75, 32);
            this.btn_back_dada_gridview.TabIndex = 2;
            this.btn_back_dada_gridview.Text = "Back";
            this.btn_back_dada_gridview.UseVisualStyleBackColor = true;
            this.btn_back_dada_gridview.Click += new System.EventHandler(this.btn_back_guardPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guard";
            // 
            // GuardPageGridView
            // 
            this.GuardPageGridView.AllowUserToAddRows = false;
            this.GuardPageGridView.AllowUserToDeleteRows = false;
            this.GuardPageGridView.BackgroundColor = System.Drawing.Color.White;
            this.GuardPageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuardPageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.password,
            this.dateOfBirth,
            this.gender,
            this.bloodGroup,
            this.presentAddress,
            this.parmanentAddress,
            this.mobileNo,
            this.nidNo,
            this.passportNo});
            this.GuardPageGridView.Location = new System.Drawing.Point(25, 533);
            this.GuardPageGridView.Name = "GuardPageGridView";
            this.GuardPageGridView.ReadOnly = true;
            this.GuardPageGridView.RowHeadersWidth = 51;
            this.GuardPageGridView.RowTemplate.Height = 24;
            this.GuardPageGridView.Size = new System.Drawing.Size(1387, 281);
            this.GuardPageGridView.TabIndex = 0;
            this.GuardPageGridView.DoubleClick += new System.EventHandler(this.GuardPageGridView_DoubleClick);
            // 
            // nidNo
            // 
            this.nidNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nidNo.DataPropertyName = "nidno";
            this.nidNo.HeaderText = "NID NO";
            this.nidNo.MinimumWidth = 6;
            this.nidNo.Name = "nidNo";
            this.nidNo.ReadOnly = true;
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
            this.panel1.Controls.Add(this.cmb_bloodGrp);
            this.panel1.Controls.Add(this.cmb_gender);
            this.panel1.Controls.Add(this.dtp_dateofbirth);
            this.panel1.Controls.Add(this.txt_passportno);
            this.panel1.Controls.Add(this.txt_nidno);
            this.panel1.Controls.Add(this.txt_mobileno);
            this.panel1.Controls.Add(this.txt_ParAddress);
            this.panel1.Controls.Add(this.txt_PreAddress);
            this.panel1.Controls.Add(this.txt_conPass);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_view_all);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_back_dada_gridview);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GuardPageGridView);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 991);
            this.panel1.TabIndex = 1;
            // 
            // GuardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 990);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuardPage_FormClosed);
            this.Load += new System.EventHandler(this.GuardPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GuardPageGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_bloodGrp;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.DateTimePicker dtp_dateofbirth;
        private System.Windows.Forms.TextBox txt_passportno;
        private System.Windows.Forms.TextBox txt_nidno;
        private System.Windows.Forms.TextBox txt_mobileno;
        private System.Windows.Forms.TextBox txt_ParAddress;
        private System.Windows.Forms.TextBox txt_PreAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox txt_conPass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmanentAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back_dada_gridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GuardPageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidNo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
    }
}