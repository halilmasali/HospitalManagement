
namespace HospitalManagement
{
    partial class Form1
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
            this.tabPage_Secreter = new System.Windows.Forms.TabPage();
            this.tabPage_Doctor = new System.Windows.Forms.TabPage();
            this.tabPage_Patient = new System.Windows.Forms.TabPage();
            this.dtGViewPatient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_patient_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_patient_name = new System.Windows.Forms.TextBox();
            this.btn_patient_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_patient_email = new System.Windows.Forms.TextBox();
            this.txt_patient_lastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_Appointment = new System.Windows.Forms.TabPage();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_clock = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_doctor = new System.Windows.Forms.ComboBox();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_patient_update = new System.Windows.Forms.Button();
            this.btn_patient_delete = new System.Windows.Forms.Button();
            this.txt_patient_search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage_Patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGViewPatient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage_Appointment.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_Secreter
            // 
            this.tabPage_Secreter.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Secreter.Name = "tabPage_Secreter";
            this.tabPage_Secreter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Secreter.Size = new System.Drawing.Size(907, 516);
            this.tabPage_Secreter.TabIndex = 3;
            this.tabPage_Secreter.Text = "Sekreter";
            this.tabPage_Secreter.UseVisualStyleBackColor = true;
            // 
            // tabPage_Doctor
            // 
            this.tabPage_Doctor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Doctor.Name = "tabPage_Doctor";
            this.tabPage_Doctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Doctor.Size = new System.Drawing.Size(907, 516);
            this.tabPage_Doctor.TabIndex = 2;
            this.tabPage_Doctor.Text = "Doktor";
            this.tabPage_Doctor.UseVisualStyleBackColor = true;
            // 
            // tabPage_Patient
            // 
            this.tabPage_Patient.Controls.Add(this.label10);
            this.tabPage_Patient.Controls.Add(this.txt_patient_search);
            this.tabPage_Patient.Controls.Add(this.dtGViewPatient);
            this.tabPage_Patient.Controls.Add(this.groupBox1);
            this.tabPage_Patient.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Patient.Name = "tabPage_Patient";
            this.tabPage_Patient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Patient.Size = new System.Drawing.Size(907, 516);
            this.tabPage_Patient.TabIndex = 1;
            this.tabPage_Patient.Text = "Hasta";
            this.tabPage_Patient.UseVisualStyleBackColor = true;
            // 
            // dtGViewPatient
            // 
            this.dtGViewPatient.AllowUserToAddRows = false;
            this.dtGViewPatient.AllowUserToDeleteRows = false;
            this.dtGViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGViewPatient.Location = new System.Drawing.Point(381, 64);
            this.dtGViewPatient.Name = "dtGViewPatient";
            this.dtGViewPatient.ReadOnly = true;
            this.dtGViewPatient.Size = new System.Drawing.Size(507, 431);
            this.dtGViewPatient.TabIndex = 14;
            this.dtGViewPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGViewPatient_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_patient_delete);
            this.groupBox1.Controls.Add(this.btn_patient_update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_patient_phone);
            this.groupBox1.Controls.Add(this.txt_patient_name);
            this.groupBox1.Controls.Add(this.btn_patient_save);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_patient_email);
            this.groupBox1.Controls.Add(this.txt_patient_lastname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 475);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt Yönetim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hasta Adı";
            // 
            // txt_patient_phone
            // 
            this.txt_patient_phone.Location = new System.Drawing.Point(117, 140);
            this.txt_patient_phone.Mask = "(999) 000-0000";
            this.txt_patient_phone.Name = "txt_patient_phone";
            this.txt_patient_phone.Size = new System.Drawing.Size(187, 20);
            this.txt_patient_phone.TabIndex = 12;
            // 
            // txt_patient_name
            // 
            this.txt_patient_name.Location = new System.Drawing.Point(117, 36);
            this.txt_patient_name.Name = "txt_patient_name";
            this.txt_patient_name.Size = new System.Drawing.Size(187, 20);
            this.txt_patient_name.TabIndex = 1;
            // 
            // btn_patient_save
            // 
            this.btn_patient_save.Location = new System.Drawing.Point(24, 246);
            this.btn_patient_save.Name = "btn_patient_save";
            this.btn_patient_save.Size = new System.Drawing.Size(280, 37);
            this.btn_patient_save.TabIndex = 11;
            this.btn_patient_save.Text = "Hasta Kaydet";
            this.btn_patient_save.UseVisualStyleBackColor = true;
            this.btn_patient_save.Click += new System.EventHandler(this.btn_patient_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hasta Soyadı";
            // 
            // txt_patient_email
            // 
            this.txt_patient_email.Location = new System.Drawing.Point(117, 192);
            this.txt_patient_email.Name = "txt_patient_email";
            this.txt_patient_email.Size = new System.Drawing.Size(187, 20);
            this.txt_patient_email.TabIndex = 7;
            // 
            // txt_patient_lastname
            // 
            this.txt_patient_lastname.Location = new System.Drawing.Point(117, 88);
            this.txt_patient_lastname.Name = "txt_patient_lastname";
            this.txt_patient_lastname.Size = new System.Drawing.Size(187, 20);
            this.txt_patient_lastname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "E-posta Adresi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Telefon Numarası";
            // 
            // tabPage_Appointment
            // 
            this.tabPage_Appointment.Controls.Add(this.btn_appointment);
            this.tabPage_Appointment.Controls.Add(this.label5);
            this.tabPage_Appointment.Controls.Add(this.cmb_patient);
            this.tabPage_Appointment.Controls.Add(this.label4);
            this.tabPage_Appointment.Controls.Add(this.cmb_clock);
            this.tabPage_Appointment.Controls.Add(this.label3);
            this.tabPage_Appointment.Controls.Add(this.dt_date);
            this.tabPage_Appointment.Controls.Add(this.label2);
            this.tabPage_Appointment.Controls.Add(this.label1);
            this.tabPage_Appointment.Controls.Add(this.cmb_doctor);
            this.tabPage_Appointment.Controls.Add(this.cmb_branch);
            this.tabPage_Appointment.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Appointment.Name = "tabPage_Appointment";
            this.tabPage_Appointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Appointment.Size = new System.Drawing.Size(907, 516);
            this.tabPage_Appointment.TabIndex = 0;
            this.tabPage_Appointment.Text = "Randevu";
            this.tabPage_Appointment.UseVisualStyleBackColor = true;
            // 
            // btn_appointment
            // 
            this.btn_appointment.Location = new System.Drawing.Point(79, 199);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(187, 37);
            this.btn_appointment.TabIndex = 10;
            this.btn_appointment.Text = "Randevu Oluştur";
            this.btn_appointment.UseVisualStyleBackColor = true;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta";
            // 
            // cmb_patient
            // 
            this.cmb_patient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_patient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(79, 96);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(187, 21);
            this.cmb_patient.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat";
            // 
            // cmb_clock
            // 
            this.cmb_clock.FormattingEnabled = true;
            this.cmb_clock.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.cmb_clock.Location = new System.Drawing.Point(79, 163);
            this.cmb_clock.Name = "cmb_clock";
            this.cmb_clock.Size = new System.Drawing.Size(187, 21);
            this.cmb_clock.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            // 
            // dt_date
            // 
            this.dt_date.CustomFormat = "d/M/yyyy dddd";
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date.Location = new System.Drawing.Point(79, 130);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(187, 20);
            this.dt_date.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branş";
            // 
            // cmb_doctor
            // 
            this.cmb_doctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_doctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_doctor.Enabled = false;
            this.cmb_doctor.FormattingEnabled = true;
            this.cmb_doctor.Location = new System.Drawing.Point(79, 62);
            this.cmb_doctor.Name = "cmb_doctor";
            this.cmb_doctor.Size = new System.Drawing.Size(187, 21);
            this.cmb_doctor.TabIndex = 1;
            // 
            // cmb_branch
            // 
            this.cmb_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(79, 28);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(187, 21);
            this.cmb_branch.TabIndex = 0;
            this.cmb_branch.SelectedIndexChanged += new System.EventHandler(this.cmb_branch_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Appointment);
            this.tabControl1.Controls.Add(this.tabPage_Patient);
            this.tabControl1.Controls.Add(this.tabPage_Doctor);
            this.tabControl1.Controls.Add(this.tabPage_Secreter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 542);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // btn_patient_update
            // 
            this.btn_patient_update.Location = new System.Drawing.Point(24, 315);
            this.btn_patient_update.Name = "btn_patient_update";
            this.btn_patient_update.Size = new System.Drawing.Size(280, 37);
            this.btn_patient_update.TabIndex = 13;
            this.btn_patient_update.Text = "Hasta Güncelle";
            this.btn_patient_update.UseVisualStyleBackColor = true;
            this.btn_patient_update.Click += new System.EventHandler(this.btn_patient_update_Click);
            // 
            // btn_patient_delete
            // 
            this.btn_patient_delete.Location = new System.Drawing.Point(24, 384);
            this.btn_patient_delete.Name = "btn_patient_delete";
            this.btn_patient_delete.Size = new System.Drawing.Size(280, 37);
            this.btn_patient_delete.TabIndex = 14;
            this.btn_patient_delete.Text = "Hasta Sil";
            this.btn_patient_delete.UseVisualStyleBackColor = true;
            // 
            // txt_patient_search
            // 
            this.txt_patient_search.Location = new System.Drawing.Point(701, 20);
            this.txt_patient_search.Name = "txt_patient_search";
            this.txt_patient_search.Size = new System.Drawing.Size(187, 20);
            this.txt_patient_search.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(672, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_Patient.ResumeLayout(false);
            this.tabPage_Patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGViewPatient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Appointment.ResumeLayout(false);
            this.tabPage_Appointment.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_Secreter;
        private System.Windows.Forms.TabPage tabPage_Doctor;
        private System.Windows.Forms.TabPage tabPage_Patient;
        private System.Windows.Forms.TabPage tabPage_Appointment;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_doctor;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_clock;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.Button btn_patient_save;
        private System.Windows.Forms.TextBox txt_patient_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_patient_lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_patient_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_patient_phone;
        private System.Windows.Forms.DataGridView dtGViewPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_patient_search;
        private System.Windows.Forms.Button btn_patient_delete;
        private System.Windows.Forms.Button btn_patient_update;
    }
}

