
namespace RSSUygulamasi
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
            this.btnVeritabaniBagla = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVeritabaniBagla
            // 
            this.btnVeritabaniBagla.Location = new System.Drawing.Point(141, 83);
            this.btnVeritabaniBagla.Name = "btnVeritabaniBagla";
            this.btnVeritabaniBagla.Size = new System.Drawing.Size(127, 60);
            this.btnVeritabaniBagla.TabIndex = 0;
            this.btnVeritabaniBagla.Text = "Veritabanı Oluştur";
            this.btnVeritabaniBagla.UseVisualStyleBackColor = true;
            this.btnVeritabaniBagla.Click += new System.EventHandler(this.btnVeritabaniBagla_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(333, 83);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(149, 60);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 256);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnVeritabaniBagla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeritabaniBagla;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

