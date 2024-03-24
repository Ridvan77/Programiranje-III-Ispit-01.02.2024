using FIT.Data;
using FIT.Data.IB210224;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviIB210224 : Form
    {
        private DrzaveIB210224 odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB210224> gradovi;
        public frmGradoviIB210224()
        {
            InitializeComponent();
        }

        public frmGradoviIB210224(DrzaveIB210224 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void UcitajGradove()
        {
            gradovi = db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
            if (gradovi != null)
            {
                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = gradovi;
            }
        }
        private void frmGradoviIB210224_Load(object sender, EventArgs e)
        {
            pbZastava.Image = Ekstenzije.ToImage(odabranaDrzava.Zastava);
            lblNazivDrzave.Text = odabranaDrzava.NazivDrzave;
            dgvGradovi.AutoGenerateColumns = false;
            UcitajGradove();
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNazivGrada, err, Kljucevi.ReqiredValue);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList()
                    .Exists(x => x.NazivGrada.ToLower() == txtNazivGrada.Text.ToLower()))
                {
                    MessageBox.Show("Istoimeni grad vec postoji!");
                }
                else
                {
                    GradoviIB210224 novi = new GradoviIB210224()
                    {
                        NazivGrada = txtNazivGrada.Text,
                        Status = true,
                        DrzavaId = odabranaDrzava.Id,
                    };
                    db.GradoviIB210224.Add(novi);
                    db.SaveChanges();
                    UcitajGradove();
                }
            }
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranigrad = gradovi[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                odabranigrad.Status = !odabranigrad.Status;
                db.Entry(odabranigrad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                UcitajGradove();
            }
        }

        private bool Validiraj1()
        {
            return Validator.ProvjeriUnos(txtBrojGradova, err, Kljucevi.ReqiredValue);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj1())
            {
                Thread t1 = new Thread(() => Generisi());
                t1.Start();
            }
        }

        private async void Generisi()
        {
            Thread.Sleep(300);
            var brojgradova = int.Parse(txtBrojGradova.Text);
            var aktivni = chbAktivni.Checked;
            var info = "";
            for (int i = 0; i < brojgradova; i++)
            {
                GradoviIB210224 grad = new GradoviIB210224()
                {
                    NazivGrada = $"Grad {i + 1}.",
                    Status = aktivni,
                    DrzavaId = odabranaDrzava.Id,
                };
                db.GradoviIB210224.Add(grad);
                db.SaveChanges();
                info += $"{DateTime.Now} -> dodat Grad {i + 1}. za drzavu {odabranaDrzava.NazivDrzave}{Environment.NewLine}";
            }
            Action action = () =>
            {
                txtInfo.Text = info;
                MessageBox.Show("Dodavanje zavrseno!");
                UcitajGradove();
            };
            BeginInvoke(action);
        }
    }
}
