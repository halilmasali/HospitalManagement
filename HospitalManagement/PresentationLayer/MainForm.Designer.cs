
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 331);
            this.Controls.Add(this.btn_doctor);
            this.Controls.Add(this.btn_secretary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 370);
            this.Name = "MainForm";
            this.Text = "Hastane Randevu Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_secretary;
        private System.Windows.Forms.Button btn_doctor;
    }
}