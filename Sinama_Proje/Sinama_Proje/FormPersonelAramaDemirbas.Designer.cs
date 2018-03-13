namespace Sinama_Proje
{
    partial class FormPersonelAramaDemirbas
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
            this.dataGridViewPersonelDemirbasListesi = new System.Windows.Forms.DataGridView();
            this.btnPersonelAramaAra = new System.Windows.Forms.Button();
            this.textBoxPersonelAramaAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelDemirbasListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonelDemirbasListesi
            // 
            this.dataGridViewPersonelDemirbasListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonelDemirbasListesi.Location = new System.Drawing.Point(8, 36);
            this.dataGridViewPersonelDemirbasListesi.Name = "dataGridViewPersonelDemirbasListesi";
            this.dataGridViewPersonelDemirbasListesi.Size = new System.Drawing.Size(556, 209);
            this.dataGridViewPersonelDemirbasListesi.TabIndex = 97;
            // 
            // btnPersonelAramaAra
            // 
            this.btnPersonelAramaAra.Location = new System.Drawing.Point(347, 8);
            this.btnPersonelAramaAra.Name = "btnPersonelAramaAra";
            this.btnPersonelAramaAra.Size = new System.Drawing.Size(79, 22);
            this.btnPersonelAramaAra.TabIndex = 95;
            this.btnPersonelAramaAra.Text = "Ara";
            this.btnPersonelAramaAra.UseVisualStyleBackColor = true;
            // 
            // textBoxPersonelAramaAdiSoyadi
            // 
            this.textBoxPersonelAramaAdiSoyadi.Location = new System.Drawing.Point(150, 9);
            this.textBoxPersonelAramaAdiSoyadi.MaxLength = 25;
            this.textBoxPersonelAramaAdiSoyadi.Name = "textBoxPersonelAramaAdiSoyadi";
            this.textBoxPersonelAramaAdiSoyadi.Size = new System.Drawing.Size(191, 20);
            this.textBoxPersonelAramaAdiSoyadi.TabIndex = 94;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(12, 11);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(132, 16);
            this.lblAd.TabIndex = 96;
            this.lblAd.Text = "Personel Adi-Soyadi";
            // 
            // FormPersonelAramaDemirbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 254);
            this.Controls.Add(this.dataGridViewPersonelDemirbasListesi);
            this.Controls.Add(this.btnPersonelAramaAra);
            this.Controls.Add(this.textBoxPersonelAramaAdiSoyadi);
            this.Controls.Add(this.lblAd);
            this.Name = "FormPersonelAramaDemirbas";
            this.Text = "Personel Uzerindeki Demirbas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonelDemirbasListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonelDemirbasListesi;
        public System.Windows.Forms.Button btnPersonelAramaAra;
        public System.Windows.Forms.TextBox textBoxPersonelAramaAdiSoyadi;
        public System.Windows.Forms.Label lblAd;
    }
}