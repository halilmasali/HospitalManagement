
namespace HospitalManagement.PresentationLayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_secretary = new System.Windows.Forms.Button();
            this.grp_auth = new System.Windows.Forms.GroupBox();
            this.txt_phoneNum = new System.Windows.Forms.MaskedTextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackgroundImage = global::HospitalManagement.Properties.Resources.doctor;
            this.btn_doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doctor.Location = new System.Drawing.Point(12, 169);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(347, 150);
            this.btn_doctor.TabIndex = 1;
            this.btn_doctor.Text = "Doktor Girişi";
            this.btn_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doctor.UseVisualStyleBackColor = true;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_secretary
            // 
            this.btn_secretary.BackgroundImage = global::HospitalManagement.Properties.Resources.secretary;
            this.btn_secretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_secretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secretary.Location = new System.Drawing.Point(12, 13);
            this.btn_secretary.MaximumSize = new System.Drawing.Size(347, 150);
            this.btn_secretary.Name = "btn_secretary";
            this.btn_secretary.Size = new System.Drawing.Size(347, 150);
            this.btn_secretary.TabIndex = 0;
            this.btn_secretary.Text = "Sekreter Girişi";
            this.btn_secretary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_secretary.UseVisualStyleBackColor = true;
            this.btn_secretary.Click += new System.EventHandler(this.btn_secretary_Click);
            // 
            // grp_auth
            // 
            this.grp_auth.Controls.Add(this.txt_phoneNum);
            this.grp_auth.Controls.Add(this.btn_auth);
            this.grp_auth.Controls.Add(this.txt_password);
            this.grp_auth.Controls.Add(this.label2);
            this.grp_auth.Controls.Add(this.label1);
            this.grp_auth.Location = new System.Drawing.Point(12, 13);
            this.grp_auth.Name = "grp_auth";
            this.grp_auth.Size = new System.Drawing.Size(347, 306);
            this.grp_auth.TabIndex = 2;
            this.grp_auth.TabStop = false;
            this.grp_auth.Text = "Kullanıcı Girişi";
            this.grp_auth.Visible = false;
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Location = new System.Drawing.Point(146, 64);
            this.txt_phoneNum.Mask = "(999) 000-0000";
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(169, 20);
            this.txt_phoneNum.TabIndex = 5;
            this.txt_phoneNum.Text = "5380279357";
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(38, 209);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(277, 46);
            this.btn_auth.TabIndex = 4;
            this.btn_auth.Text = "Oturum Aç";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(146, 130);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(169, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon Numarası";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 331);
            this.Controls.Add(this.grp_auth);
            this.Controls.Add(this.btn_doctor);
            this.Controls.Add(this.btn_secretary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 370);
            this.Name = "MainForm";
            this.Text = "Hastane Randevu Sistemi";
            this.grp_auth.ResumeLayout(false);
            this.grp_auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_secretary;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.GroupBox grp_auth;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_phoneNum;
    }
}