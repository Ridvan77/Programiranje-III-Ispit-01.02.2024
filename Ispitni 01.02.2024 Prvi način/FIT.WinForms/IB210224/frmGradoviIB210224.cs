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
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB210224> gradovi;
        private DrzaveIB210224 odabranaDrzava;

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
            lblDrzava.Text = odabranaDrzava.NazivDrzave;
            dgvGradovi.AutoGenerateColumns = false;
            UcitajGradove();
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNoviGrad, err, Kljucevi.ReqiredValue);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                bool validnost = true;
                for (int i = 0; i < gradovi.Count(); i++)
                {
                    if (txtNoviGrad.Text.ToLower() == gradovi[i].NazivGrada.ToLower())
                    {
                        MessageBox.Show("Istoimeni grad vec postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        validnost = false;
                        break;
                    }
                }
                if (validnost)
                {
                    GradoviIB210224 grad = new GradoviIB210224()
                    {
                        NazivGrada = txtNoviGrad.Text,
                        Status = true,
                        DrzavaId = odabranaDrzava.Id
                    };
                    db.GradoviIB210224.Add(grad);
                    db.SaveChanges();
                    txtNoviGrad.Text = "";
                    UcitajGradove();
                }
            }
        }

        private void frmGradoviIB210224_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniGrad = gradovi[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                odabraniGrad.Status = !odabraniGrad.Status;
                db.SaveChanges();
                UcitajGradove();
            }
        }

        private bool Validiraj2()
        {
            return Validator.ProvjeriUnos(txtBrojGradova, err, Kljucevi.ReqiredValue);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj2())
            {
                Thread t1 = new Thread(() => Generisi());
                t1.Start();
            }
        }

        private void Generisi()
        {
            Thread.Sleep(300);
            var brojGradova = int.Parse(txtBrojGradova.Text);
            var aktivan = chbAktivni.Checked;
            string info = "";
            for (int i = 0; i < brojGradova; i++)
            {
                GradoviIB210224 grad = new GradoviIB210224()
                {
                    NazivGrada = $"Grad {i + 1}.",
                    Status = aktivan,
                    DrzavaId = odabranaDrzava.Id,
                };
                db.GradoviIB210224.Add(grad);
                db.SaveChanges();
                info += $"{DateTime.Now} -> dodat Grad {i + 1}. za drzavu {odabranaDrzava.NazivDrzave} {Environment.NewLine}";
            }
            Action action = () =>
            {
                txtInfo.Text = info;
                MessageBox.Show("Dodavanje je zavrseno!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajGradove();
            };
            BeginInvoke(action);
        }
    }
}
