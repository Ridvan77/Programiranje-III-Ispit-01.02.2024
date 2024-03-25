using DLWMS.Data;
using DLWMS.Data.IB210224;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB210224
{
    public partial class frmNovaPorukaIB210224 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;

        public frmNovaPorukaIB210224()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB210224(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmNovaPorukaIB210224_Load(object sender, EventArgs e)
        {
            cbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbSlike_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlike.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.ObaveznaVrijednost) && 
                Validator.ValidirajKontrolu(dtpValidnost, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cbHitnost, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtSadrzaj, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(pbSlike, err, Kljucevi.ObaveznaVrijednost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cbPredmet.SelectedItem as PredmetiIB210224;
                var validnost = dtpValidnost.Value;
                var hitnost = cbHitnost.SelectedItem.ToString();
                var sadrzaj = txtSadrzaj.Text;
                var slika = ImageHelper.FromImageToByte(pbSlike.Image);

                var novaPoruka = new StudentiPorukeIB210224()
                {
                    StudentId = student.Id,
                    PredmetId = predmet.Id,
                    Validnost = validnost,
                    Hitnost = hitnost,
                    Sadrzaj = sadrzaj,
                    Slika = slika,
                };
                db.StudentiPorukeIB210224.Add(novaPoruka);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

    }
}
