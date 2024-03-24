using FIT.Data;
using FIT.Data.IB210224;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaIB210224 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        public frmPretragaIB210224()
        {
            InitializeComponent();
        }

        private void UcitajStudente()
        {
            studenti = db.Studenti.Include(x => x.Grad).ThenInclude(x => x.Drzava).ToList();
            if (studenti != null)
            {
                for (int i = 0; i < studenti.Count(); i++)
                {
                    studenti[i].Prosjek = db.PolozeniPredmeti.ToList().Exists(x => x.StudentId == studenti[i].Id) ?
                        db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Average(x => x.Ocjena) : 5;
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
        }
        private void frmPretragaIB210224_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.DrzaveIB210224.ToList();
            var odabranaDrzava = cbDrzava.SelectedItem as DrzaveIB210224;
            cbGrad.DataSource = db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
            UcitajStudente();
        }

        private void FiltrirajStudente()
        {
            var odabranaDrzava = cbDrzava.SelectedItem as DrzaveIB210224;
            var odabraniGrad = cbGrad.SelectedItem as GradoviIB210224;
            studenti = db.Studenti.Include(x => x.Grad).ThenInclude(x => x.Drzava).
                Where(x => x.Grad.Id == odabraniGrad.Id).ToList();
            if (studenti != null)
            {
                for (int i = 0; i < studenti.Count(); i++)
                {
                    studenti[i].Prosjek = db.PolozeniPredmeti.ToList().Exists(x => x.StudentId == studenti[i].Id) ?
                        db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Average(x => x.Ocjena) : 5;
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
            if (studenti.Count() == 0)
            {
                MessageBox.Show($"U bazi nije evidentiran niti jedan student rođen u gradu {odabraniGrad}, {odabranaDrzava}");
            }
        }
        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaDrzava = cbDrzava.SelectedItem as DrzaveIB210224;
            cbGrad.DataSource = db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
            FiltrirajStudente();
        }


        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajStudente();
        }
    }
}
