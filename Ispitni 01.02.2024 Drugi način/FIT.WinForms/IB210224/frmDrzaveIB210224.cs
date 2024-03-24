using FIT.Data.IB210224;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB210224
{
    public partial class frmDrzaveIB210224 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB210224> drzave;
        DrzaveIB210224 odabranaDrzava;
        public frmDrzaveIB210224()
        {
            InitializeComponent();
        }

        private void UcitajDrzave()
        {
            drzave = db.DrzaveIB210224.ToList();
            if (drzave != null)
            {
                for (int i = 0; i < drzave.Count(); i++)
                {
                    drzave[i].BrojGradova = db.GradoviIB210224.Where(x => x.DrzavaId == drzave[i].Id).Count();
                }
                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = drzave;
            }
        }
        private void frmDrzaveIB210224_Load(object sender, EventArgs e)
        {
            dgvDrzave.AutoGenerateColumns = false;
            lblVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
            UcitajDrzave();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB210224 frmNovaDrzava = new frmNovaDrzavaIB210224();
            frmNovaDrzava.ShowDialog();
            if (frmNovaDrzava.DialogResult == DialogResult.OK)
            {
                UcitajDrzave();
            }
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaDrzava = drzave[e.RowIndex];
            if (e.ColumnIndex != 4)
            {
                frmNovaDrzavaIB210224 frmNovaDrzava = new frmNovaDrzavaIB210224(odabranaDrzava);
                frmNovaDrzava.ShowDialog();
                if (frmNovaDrzava.DialogResult == DialogResult.OK)
                {
                    UcitajDrzave();
                }
            }
        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaDrzava = drzave[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                frmGradoviIB210224 frmGradovi = new frmGradoviIB210224(odabranaDrzava);
                frmGradovi.ShowDialog();
                if (frmGradovi.DialogResult == DialogResult.Cancel)
                {
                    UcitajDrzave();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (odabranaDrzava != null)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranaDrzava);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}