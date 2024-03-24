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
    public partial class frmNovaDrzavaIB210224 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB210224 odabranaDrzava;

        public frmNovaDrzavaIB210224()
        {
            InitializeComponent();
        }

        public frmNovaDrzavaIB210224(DrzaveIB210224 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void frmNovaDrzavaIB210224_Load(object sender, EventArgs e)
        {
            if (odabranaDrzava != null)
            {
                pbZastava.Image = Helpers.Ekstenzije.ToImage(odabranaDrzava.Zastava);
                txtNaziv.Text = odabranaDrzava.NazivDrzave;
                chbAktivna.Checked = odabranaDrzava.Status;
            }
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(chbAktivna, err, Kljucevi.ReqiredValue);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (odabranaDrzava == null)
                {
                    DrzaveIB210224 drzava = new DrzaveIB210224()
                    {
                        NazivDrzave = txtNaziv.Text,
                        Status = chbAktivna.Checked,
                        Zastava = Ekstenzije.ToByteArray(pbZastava.Image)
                    };
                    db.DrzaveIB210224.Add(drzava);
                }
                else
                {
                    odabranaDrzava.NazivDrzave = txtNaziv.Text;
                    odabranaDrzava.Status = chbAktivna.Checked;
                    odabranaDrzava.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                    db.Entry(odabranaDrzava).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

    }
}
