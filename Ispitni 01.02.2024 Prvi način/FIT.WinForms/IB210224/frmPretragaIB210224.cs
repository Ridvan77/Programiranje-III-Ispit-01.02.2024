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
        DrzaveIB210224 odabranaDrzava;
        public frmPretragaIB210224()
        {
            InitializeComponent();
        }

        private void UcitajSve()
        {
            odabranaDrzava = cbDrzava.SelectedItem as DrzaveIB210224;
            var odabraniGrad = cbGrad.SelectedItem == null ? "Svi" : cbGrad.SelectedItem.ToString();
            studenti = db.Studenti.Include(x => x.Grad).ThenInclude(x => x.Drzava).Where
                (x => x.Grad.Drzava.Id == odabranaDrzava.Id && (x.Grad.NazivGrada == odabraniGrad || odabraniGrad == "Svi"))
                .ToList();
            if (studenti != null)
            {
                for (int i = 0; i < studenti.Count(); i++)
                {
                    studenti[i].Prosjek = db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Count() == 0
                        ? 5 : db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Average(x => x.Ocjena);
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
        }
        private void frmPretragaIB210224_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.DrzaveIB210224.ToList();
            UcitajSve();
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajSve();
            cbGrad.DataSource = db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajSve();
        }
    }
}
