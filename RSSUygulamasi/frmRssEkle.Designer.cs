
namespace RSSUygulamasi
{
    partial class frmRssEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRssEkle = new System.Windows.Forms.TextBox();
            this.btnRssEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSS Adı :";
            // 
            // txtRssEkle
            // 
            this.txtRssEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRssEkle.Location = new System.Drawing.Point(150, 25);
            this.txtRssEkle.Name = "txtRssEkle";
            this.txtRssEkle.Size = new System.Drawing.Size(599, 28);
            this.txtRssEkle.TabIndex = 1;
            // 
            // btnRssEkle
            // 
            this.btnRssEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRssEkle.Location = new System.Drawing.Point(628, 77);
            this.btnRssEkle.Name = "btnRssEkle";
            this.btnRssEkle.Size = new System.Drawing.Size(121, 34);
            this.btnRssEkle.TabIndex = 3;
            this.btnRssEkle.Text = "Ekle";
            this.btnRssEkle.UseVisualStyleBackColor = true;
            this.btnRssEkle.Click += new System.EventHandler(this.btnRssEkle_Click);
            // 
            // frmRssEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 134);
            this.Controls.Add(this.btnRssEkle);
            this.Controls.Add(this.txtRssEkle);
            this.Controls.Add(this.label1);
            this.Name = "frmRssEkle";
            this.Text = "frmRssEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRssEkle;
        private System.Windows.Forms.Button btnRssEkle;
    }
}