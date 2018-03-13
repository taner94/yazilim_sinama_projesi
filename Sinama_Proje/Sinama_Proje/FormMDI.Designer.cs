namespace Sinama_Proje
{
    partial class FormMDI
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokKaydiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbasAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelUzerindekiDemirbaslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDemirbasListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelUzerindekiDemirbasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokIslemleriToolStripMenuItem,
            this.aramaIslemleriToolStripMenuItem,
            this.odaIslemleriToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokIslemleriToolStripMenuItem
            // 
            this.stokIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokKaydiToolStripMenuItem});
            this.stokIslemleriToolStripMenuItem.Name = "stokIslemleriToolStripMenuItem";
            this.stokIslemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.stokIslemleriToolStripMenuItem.Text = "Stok Islemleri";
            // 
            // stokKaydiToolStripMenuItem
            // 
            this.stokKaydiToolStripMenuItem.Name = "stokKaydiToolStripMenuItem";
            this.stokKaydiToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.stokKaydiToolStripMenuItem.Text = "Stok Kaydi";
            this.stokKaydiToolStripMenuItem.Click += new System.EventHandler(this.stokKaydiToolStripMenuItem_Click);
            // 
            // aramaIslemleriToolStripMenuItem
            // 
            this.aramaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demirbasAramaToolStripMenuItem,
            this.personelUzerindekiDemirbaslarToolStripMenuItem});
            this.aramaIslemleriToolStripMenuItem.Name = "aramaIslemleriToolStripMenuItem";
            this.aramaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aramaIslemleriToolStripMenuItem.Text = "Arama Islemleri";
            // 
            // demirbasAramaToolStripMenuItem
            // 
            this.demirbasAramaToolStripMenuItem.Name = "demirbasAramaToolStripMenuItem";
            this.demirbasAramaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.demirbasAramaToolStripMenuItem.Text = "Demirbas Arama";
            this.demirbasAramaToolStripMenuItem.Click += new System.EventHandler(this.demirbasAramaToolStripMenuItem_Click);
            // 
            // personelUzerindekiDemirbaslarToolStripMenuItem
            // 
            this.personelUzerindekiDemirbaslarToolStripMenuItem.Name = "personelUzerindekiDemirbaslarToolStripMenuItem";
            this.personelUzerindekiDemirbaslarToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.personelUzerindekiDemirbaslarToolStripMenuItem.Text = "Personel Uzerindeki Demirbaslar";
            this.personelUzerindekiDemirbaslarToolStripMenuItem.Click += new System.EventHandler(this.personelUzerindekiDemirbaslarToolStripMenuItem_Click);
            // 
            // odaIslemleriToolStripMenuItem
            // 
            this.odaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaTanimlamaToolStripMenuItem,
            this.odaDemirbasListesiToolStripMenuItem});
            this.odaIslemleriToolStripMenuItem.Name = "odaIslemleriToolStripMenuItem";
            this.odaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.odaIslemleriToolStripMenuItem.Text = "Oda Islemleri";
            // 
            // odaTanimlamaToolStripMenuItem
            // 
            this.odaTanimlamaToolStripMenuItem.Name = "odaTanimlamaToolStripMenuItem";
            this.odaTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.odaTanimlamaToolStripMenuItem.Text = "Oda Tanimlama";
            this.odaTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.odaTanimlamaToolStripMenuItem_Click);
            // 
            // odaDemirbasListesiToolStripMenuItem
            // 
            this.odaDemirbasListesiToolStripMenuItem.Name = "odaDemirbasListesiToolStripMenuItem";
            this.odaDemirbasListesiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.odaDemirbasListesiToolStripMenuItem.Text = "Oda Demirbas Listesi";
            this.odaDemirbasListesiToolStripMenuItem.Click += new System.EventHandler(this.odaDemirbasListesiToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelUzerindekiDemirbasToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelUzerindekiDemirbasToolStripMenuItem
            // 
            this.personelUzerindekiDemirbasToolStripMenuItem.Name = "personelUzerindekiDemirbasToolStripMenuItem";
            this.personelUzerindekiDemirbasToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.personelUzerindekiDemirbasToolStripMenuItem.Text = "Personel Uzerindeki Demirbas";
            this.personelUzerindekiDemirbasToolStripMenuItem.Click += new System.EventHandler(this.personelUzerindekiDemirbasToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokKaydiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelUzerindekiDemirbaslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDemirbasListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbasAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelUzerindekiDemirbasToolStripMenuItem;
    }
}

