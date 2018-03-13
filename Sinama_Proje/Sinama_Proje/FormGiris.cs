using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinama_Proje
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxAd.Text == "Admin" && textBoxSifre.Text == "12345")
            {
                FormMDI form = new FormMDI();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "Giriş başarısız.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
