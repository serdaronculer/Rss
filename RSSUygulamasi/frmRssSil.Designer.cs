
namespace RSSUygulamasi
{
    partial class frmRssSil
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
            this.dgwRss = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRss)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRss
            // 
            this.dgwRss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwRss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRss.Location = new System.Drawing.Point(12, 12);
            this.dgwRss.Name = "dgwRss";
            this.dgwRss.RowHeadersWidth = 51;
            this.dgwRss.RowTemplate.Height = 24;
            this.dgwRss.Size = new System.Drawing.Size(681, 150);
            this.dgwRss.TabIndex = 0;
            this.dgwRss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRss_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(596, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 31);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // frmRssSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 350);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwRss);
            this.Name = "frmRssSil";
            this.Text = "frmRssSil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRssSil_FormClosing);
            this.Load += new System.EventHandler(this.frmRssSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRss;
        private System.Windows.Forms.Button btnSil;
    }
}