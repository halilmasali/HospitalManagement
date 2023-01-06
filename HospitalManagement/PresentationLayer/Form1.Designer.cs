
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.btn_appointment = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(315, 224);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sekreter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(315, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doktor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hasta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_appointment);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmb_patient);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmb_clock);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dt_date);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmb_doctor);
            this.tabPage1.Controls.Add(this.cmb_branch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(311, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randevu";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 281);
            this.tabControl1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 281);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}

