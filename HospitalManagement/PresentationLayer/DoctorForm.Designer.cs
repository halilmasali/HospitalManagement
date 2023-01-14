
namespace HospitalManagement.PresentationLayer
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_patientSearch = new System.Windows.Forms.TabPage();
            this.tabPage_appointmentDetails = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_patientNote = new System.Windows.Forms.RichTextBox();
            this.btn_sendmail = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_patientDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_patientEmail = new System.Windows.Forms.Label();
            this.lbl_patientPhone = new System.Windows.Forms.Label();
            this.lbl_patientLastName = new System.Windows.Forms.Label();
            this.lbl_patientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGViewAppointmentDetails = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage_appointmentDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGViewAppointmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_patientSearch);
            this.tabControl1.Controls.Add(this.tabPage_appointmentDetails);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 542);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage_patientSearch
            // 
            this.tabPage_patientSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPage_patientSearch.Name = "tabPage_patientSearch";
            this.tabPage_patientSearch.Size = new System.Drawing.Size(907, 516);
            this.tabPage_patientSearch.TabIndex = 0;
            this.tabPage_patientSearch.Text = "Hasta Ara";
            this.tabPage_patientSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage_appointmentDetails
            // 
            this.tabPage_appointmentDetails.Controls.Add(this.groupBox2);
            this.tabPage_appointmentDetails.Controls.Add(this.btn_sendmail);
            this.tabPage_appointmentDetails.Controls.Add(this.btn_print);
            this.tabPage_appointmentDetails.Controls.Add(this.btn_save);
            this.tabPage_appointmentDetails.Controls.Add(this.groupBox1);
            this.tabPage_appointmentDetails.Controls.Add(this.dtGViewAppointmentDetails);
            this.tabPage_appointmentDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPage_appointmentDetails.Name = "tabPage_appointmentDetails";
            this.tabPage_appointmentDetails.Size = new System.Drawing.Size(907, 516);
            this.tabPage_appointmentDetails.TabIndex = 0;
            this.tabPage_appointmentDetails.Text = "Randevu Detay";
            this.tabPage_appointmentDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_patientNote);
            this.groupBox2.Location = new System.Drawing.Point(337, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 302);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Görüşleri";
            // 
            // txt_patientNote
            // 
            this.txt_patientNote.Location = new System.Drawing.Point(6, 19);
            this.txt_patientNote.Name = "txt_patientNote";
            this.txt_patientNote.Size = new System.Drawing.Size(369, 271);
            this.txt_patientNote.TabIndex = 9;
            this.txt_patientNote.Text = "";
            // 
            // btn_sendmail
            // 
            this.btn_sendmail.Location = new System.Drawing.Point(748, 363);
            this.btn_sendmail.Name = "btn_sendmail";
            this.btn_sendmail.Size = new System.Drawing.Size(126, 37);
            this.btn_sendmail.TabIndex = 13;
            this.btn_sendmail.Text = "E-mail Gönder";
            this.btn_sendmail.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(748, 310);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(126, 37);
            this.btn_print.TabIndex = 12;
            this.btn_print.Text = "PDF - Yazdır";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(748, 257);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 37);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_patientDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_patientEmail);
            this.groupBox1.Controls.Add(this.lbl_patientPhone);
            this.groupBox1.Controls.Add(this.lbl_patientLastName);
            this.groupBox1.Controls.Add(this.lbl_patientName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 302);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // lbl_patientDate
            // 
            this.lbl_patientDate.AutoSize = true;
            this.lbl_patientDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_patientDate.Location = new System.Drawing.Point(125, 276);
            this.lbl_patientDate.Name = "lbl_patientDate";
            this.lbl_patientDate.Size = new System.Drawing.Size(0, 15);
            this.lbl_patientDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kayıt Tarihi";
            // 
            // lbl_patientEmail
            // 
            this.lbl_patientEmail.AutoSize = true;
            this.lbl_patientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_patientEmail.Location = new System.Drawing.Point(125, 215);
            this.lbl_patientEmail.Name = "lbl_patientEmail";
            this.lbl_patientEmail.Size = new System.Drawing.Size(0, 15);
            this.lbl_patientEmail.TabIndex = 8;
            // 
            // lbl_patientPhone
            // 
            this.lbl_patientPhone.AutoSize = true;
            this.lbl_patientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_patientPhone.Location = new System.Drawing.Point(125, 154);
            this.lbl_patientPhone.Name = "lbl_patientPhone";
            this.lbl_patientPhone.Size = new System.Drawing.Size(0, 15);
            this.lbl_patientPhone.TabIndex = 7;
            // 
            // lbl_patientLastName
            // 
            this.lbl_patientLastName.AutoSize = true;
            this.lbl_patientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_patientLastName.Location = new System.Drawing.Point(125, 93);
            this.lbl_patientLastName.Name = "lbl_patientLastName";
            this.lbl_patientLastName.Size = new System.Drawing.Size(0, 15);
            this.lbl_patientLastName.TabIndex = 6;
            // 
            // lbl_patientName
            // 
            this.lbl_patientName.AutoSize = true;
            this.lbl_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_patientName.Location = new System.Drawing.Point(125, 32);
            this.lbl_patientName.Name = "lbl_patientName";
            this.lbl_patientName.Size = new System.Drawing.Size(0, 15);
            this.lbl_patientName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-posta Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Soyadı";
            // 
            // dtGViewAppointmentDetails
            // 
            this.dtGViewAppointmentDetails.AllowUserToAddRows = false;
            this.dtGViewAppointmentDetails.AllowUserToDeleteRows = false;
            this.dtGViewAppointmentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGViewAppointmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGViewAppointmentDetails.Location = new System.Drawing.Point(8, 17);
            this.dtGViewAppointmentDetails.Name = "dtGViewAppointmentDetails";
            this.dtGViewAppointmentDetails.ReadOnly = true;
            this.dtGViewAppointmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGViewAppointmentDetails.Size = new System.Drawing.Size(891, 150);
            this.dtGViewAppointmentDetails.TabIndex = 0;
            this.dtGViewAppointmentDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGViewAppointmentDetails_CellDoubleClick);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 542);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.Text = "Doktor Ekranı";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_appointmentDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGViewAppointmentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_patientSearch;
        private System.Windows.Forms.TabPage tabPage_appointmentDetails;
        private System.Windows.Forms.DataGridView dtGViewAppointmentDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_patientNote;
        private System.Windows.Forms.Button btn_sendmail;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_patientEmail;
        private System.Windows.Forms.Label lbl_patientPhone;
        private System.Windows.Forms.Label lbl_patientLastName;
        private System.Windows.Forms.Label lbl_patientName;
        private System.Windows.Forms.Label lbl_patientDate;
        private System.Windows.Forms.Label label5;
    }
}