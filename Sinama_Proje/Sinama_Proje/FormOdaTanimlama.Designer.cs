namespace Sinama_Proje
{
    partial class FormOdaTanimlama
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
            this.btnOdaTanimlamaEkle = new System.Windows.Forms.Button();
            this.textBoxOdaTanimlamaSorumlu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOdaTanimlamaAdi = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdaTanimlamaEkle
            // 
            this.btnOdaTanimlamaEkle.Location = new System.Drawing.Point(160, 93);
            this.btnOdaTanimlamaEkle.Name = "btnOdaTanimlamaEkle";
            this.btnOdaTanimlamaEkle.Size = new System.Drawing.Size(143, 28);
            this.btnOdaTanimlamaEkle.TabIndex = 87;
            this.btnOdaTanimlamaEkle.Text = "Ekle";
            this.btnOdaTanimlamaEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxOdaTanimlamaSorumlu
            // 
            this.textBoxOdaTanimlamaSorumlu.Location = new System.Drawing.Point(112, 53);
            this.textBoxOdaTanimlamaSorumlu.MaxLength = 25;
            this.textBoxOdaTanimlamaSorumlu.Name = "textBoxOdaTanimlamaSorumlu";
            this.textBoxOdaTanimlamaSorumlu.Size = new System.Drawing.Size(191, 20);
            this.textBoxOdaTanimlamaSorumlu.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Oda Sorumlusu";
            // 
            // textBoxOdaTanimlamaAdi
            // 
            this.textBoxOdaTanimlamaAdi.Location = new System.Drawing.Point(112, 27);
            this.textBoxOdaTanimlamaAdi.MaxLength = 25;
            this.textBoxOdaTanimlamaAdi.Name = "textBoxOdaTanimlamaAdi";
            this.textBoxOdaTanimlamaAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxOdaTanimlamaAdi.TabIndex = 83;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(13, 29);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 16);
            this.lblAd.TabIndex = 89;
            this.lblAd.Text = "Oda Adi";
            // 
            // FormOdaTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 149);
            this.Controls.Add(this.btnOdaTanimlamaEkle);
            this.Controls.Add(this.textBoxOdaTanimlamaSorumlu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOdaTanimlamaAdi);
            this.Controls.Add(this.lblAd);
            this.Name = "FormOdaTanimlama";
            this.Text = "FormOdaTanimlama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOdaTanimlamaEkle;
        public System.Windows.Forms.TextBox textBoxOdaTanimlamaSorumlu;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxOdaTanimlamaAdi;
        public System.Windows.Forms.Label lblAd;
    }
}