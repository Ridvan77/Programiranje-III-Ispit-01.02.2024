using DLWMS.Data;
using DLWMS.Data.IB210224;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB210224
{
    public partial class frmPretragaIB210224 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB210224> studentiPredmeti;
        public frmPretragaIB210224()
        {
            InitializeComponent();
        }
        private void UcitajSve()
        {
            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();
            if (studentiPredmeti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studentiPredmeti;
            }
        }

        private void frmPretragaIB210224_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            UcitajSve();
        }
        private void UcitajStudente()
        {
            var ocjenaOd = cbOcjenaOd.SelectedItem == null ? "6" : cbOcjenaOd.SelectedItem.ToString();
            var ocjenaDo = cbOcjenaDo.SelectedItem == null ? "10" : cbOcjenaDo.SelectedItem.ToString();
            var aktivan = chbAktivan.Checked;
            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;

            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").Where(x =>
                (x.Ocjena >= int.Parse(ocjenaOd) && x.Ocjena <= int.Parse(ocjenaDo)) &&
                (x.Student.Aktivan == aktivan) &&
                (x.Datum >= datumOd && x.Datum <= datumDo)
                ).ToList();
            if (studentiPredmeti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studentiPredmeti;
            }
            if (studentiPredmeti.Count() == 0)
            {
                MessageBox.Show($"U periodu od {datumOd} - {datumDo} godine ne " +
                    $"postoje evidentirane ocjene u opsegu od {ocjenaOd}" +
                    $" do {ocjenaDo} za bilo kojeg (ne)aktivnog studenta.",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudentPredmet = studentiPredmeti[e.RowIndex];
            if(e.ColumnIndex == 6)
            {
                frmPorukeIB210224 frmPoruke = new frmPorukeIB210224(odabraniStudentPredmet.Student);
                frmPoruke.ShowDialog();
            }
        }
    }
}
