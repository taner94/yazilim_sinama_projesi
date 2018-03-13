namespace Sinama_Proje
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.lblGRVLTEL = new System.Windows.Forms.Label();
            this.lblGRVLAd = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(11, 110);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(82, 33);
            this.buttonGiris.TabIndex = 86;
            this.buttonGiris.Text = "Giris";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(105, 110);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(86, 33);
            this.buttonCikis.TabIndex = 87;
            this.buttonCikis.Text = "Cikis";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(11, 82);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBoxSifre.MaxLength = 20;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(180, 20);
            this.textBoxSifre.TabIndex = 83;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(11, 35);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBoxAd.MaxLength = 25;
            this.textBoxAd.Multiline = true;
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(180, 24);
            this.textBoxAd.TabIndex = 82;
            // 
            // lblGRVLTEL
            // 
            this.lblGRVLTEL.AutoSize = true;
            this.lblGRVLTEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRVLTEL.Location = new System.Drawing.Point(10, 62);
            this.lblGRVLTEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGRVLTEL.Name = "lblGRVLTEL";
            this.lblGRVLTEL.Size = new System.Drawing.Size(38, 18);
            this.lblGRVLTEL.TabIndex = 84;
            this.lblGRVLTEL.Text = "Sifre";
            // 
            // lblGRVLAd
            // 
            this.lblGRVLAd.AutoSize = true;
            this.lblGRVLAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRVLAd.Location = new System.Drawing.Point(9, 13);
            this.lblGRVLAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGRVLAd.Name = "lblGRVLAd";
            this.lblGRVLAd.Size = new System.Drawing.Size(86, 18);
            this.lblGRVLAd.TabIndex = 85;
            this.lblGRVLAd.Text = "Kullanici Adi";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(205, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 152);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.lblGRVLTEL);
            this.Controls.Add(this.lblGRVLAd);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonGiris;
        public System.Windows.Forms.Button buttonCikis;
        public System.Windows.Forms.TextBox textBoxSifre;
        public System.Windows.Forms.TextBox textBoxAd;
        public System.Windows.Forms.Label lblGRVLTEL;
        public System.Windows.Forms.Label lblGRVLAd;
        public System.Windows.Forms.PictureBox pictureBox3;
    }
}