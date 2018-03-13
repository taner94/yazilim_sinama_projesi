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
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            FormGiris form = new FormGiris();
            this.Hide();
            form.Show();
            
        }

        FormStokKayit formstk;
        FormDemirbasArama formDmrAra;
        FormOdaDemirbasIslemleri formOdaDmrIslem;
        FormOdaTanimlama formOdaTnmlm;
        FormPersonelAramaDemirbas formPerson;
        FormOdaDemirbasListesi formDmrList;

        private void odaDemirbasListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDmrList == null)
            {
                formDmrList = new FormOdaDemirbasListesi();
                formDmrList.FormClosed += new FormClosedEventHandler(FormDmrList_FormClosed);
                formDmrList.MdiParent = this;
                formDmrList.Show();
            }
            else
                formDmrList.Activate();
        }

        private void personelUzerindekiDemirbasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPerson == null)
            {
                formPerson = new FormPersonelAramaDemirbas();
                formPerson.FormClosed += new FormClosedEventHandler(FormPerson_FormClosed);
                formPerson.MdiParent = this;
                formPerson.Show();
            }
            else
                formPerson.Activate();
        }
        private void odaTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDmrAra == null)
            {
                formOdaTnmlm = new FormOdaTanimlama();
                formOdaTnmlm.FormClosed += new FormClosedEventHandler(FormOdaTnmlm_FormClosed);
                formOdaTnmlm.MdiParent = this;
                formOdaTnmlm.Show();
            }
            else
                formOdaDmrIslem.Activate();
        }

        private void personelUzerindekiDemirbaslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formOdaDmrIslem == null)
            {
                formOdaDmrIslem = new FormOdaDemirbasIslemleri();
                formOdaDmrIslem.FormClosed += new FormClosedEventHandler(FormOdaDmrIslem_FormClosed);
                formOdaDmrIslem.MdiParent = this;
                formOdaDmrIslem.Show();
            }
            else
                formOdaDmrIslem.Activate();
        }
        private void demirbasAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDmrAra == null)
            {
                formDmrAra = new FormDemirbasArama();
                formDmrAra.FormClosed += new FormClosedEventHandler(FormDmrAra_FormClosed);
                formDmrAra.MdiParent = this;
                formDmrAra.Show();
            }
            else
                formDmrAra.Activate();
        }
        private void stokKaydiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formstk == null)
            {
                formstk = new FormStokKayit();
                formstk.FormClosed += new FormClosedEventHandler(Formstk_FormClosed);
                formstk.MdiParent = this;
                formstk.Show();
            }
            else
                formstk.Activate();

        }


        private void Formstk_FormClosed(object sender, FormClosedEventArgs e)
        {
            formstk = null;
        }
        private void FormDmrAra_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDmrAra = null;
        }
        private void FormOdaDmrIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDmrAra = null;
        }
        private void FormOdaTnmlm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDmrAra = null;
        }
        private void FormDmrList_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDmrList = null;
        }
        private void FormPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPerson = null;
        }
    }
}
