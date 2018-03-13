namespace Sinama_Proje
{
    partial class FormOdaDemirbasListesi
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
            this.btnOdaDemitbasListesiAra = new System.Windows.Forms.Button();
            this.textBoxOdaDemibasListesiAdi = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dataGridViewOdaDemirbasListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaDemirbasListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdaDemitbasListesiAra
            // 
            this.btnOdaDemitbasListesiAra.Location = new System.Drawing.Point(274, 8);
            this.btnOdaDemitbasListesiAra.Name = "btnOdaDemitbasListesiAra";
            this.btnOdaDemitbasListesiAra.Size = new System.Drawing.Size(79, 22);
            this.btnOdaDemitbasListesiAra.TabIndex = 91;
            this.btnOdaDemitbasListesiAra.Text = "Ara";
            this.btnOdaDemitbasListesiAra.UseVisualStyleBackColor = true;
            // 
            // textBoxOdaDemibasListesiAdi
            // 
            this.textBoxOdaDemibasListesiAdi.Location = new System.Drawing.Point(77, 8);
            this.textBoxOdaDemibasListesiAdi.MaxLength = 25;
            this.textBoxOdaDemibasListesiAdi.Name = "textBoxOdaDemibasListesiAdi";
            this.textBoxOdaDemibasListesiAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxOdaDemibasListesiAdi.TabIndex = 90;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(14, 10);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 16);
            this.lblAd.TabIndex = 92;
            this.lblAd.Text = "Oda Adi";
            // 
            // dataGridViewOdaDemirbasListesi
            // 
            this.dataGridViewOdaDemirbasListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdaDemirbasListesi.Location = new System.Drawing.Point(5, 36);
            this.dataGridViewOdaDemirbasListesi.Name = "dataGridViewOdaDemirbasListesi";
            this.dataGridViewOdaDemirbasListesi.Size = new System.Drawing.Size(556, 209);
            this.dataGridViewOdaDemirbasListesi.TabIndex = 93;
            // 
            // FormOdaDemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 251);
            this.Controls.Add(this.dataGridViewOdaDemirbasListesi);
            this.Controls.Add(this.btnOdaDemitbasListesiAra);
            this.Controls.Add(this.textBoxOdaDemibasListesiAdi);
            this.Controls.Add(this.lblAd);
            this.Name = "FormOdaDemirbasListesi";
            this.Text = "Oda Demirbas Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdaDemirbasListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOdaDemitbasListesiAra;
        public System.Windows.Forms.TextBox textBoxOdaDemibasListesiAdi;
        public System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dataGridViewOdaDemirbasListesi;
    }
}