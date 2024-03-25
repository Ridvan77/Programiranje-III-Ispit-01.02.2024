using DLWMS.Data;
using DLWMS.Data.IB210224;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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

namespace DLWMS.WinForms.IB210224
{
    public partial class frmPorukeIB210224 : Form
    {
        private Student student;
        List<StudentiPorukeIB210224> poruke;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmPorukeIB210224()
        {
            InitializeComponent();
        }

        public frmPorukeIB210224(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB210224.Include("Student").Include("Predmet").Where(x => x.Student.Id == student.Id && x.Validnost >= DateTime.Now)
                .ToList();
            if (poruke != null)
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }
            this.Text = $"Broj poruka: {poruke.Count()}";
            if (poruke.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        private void frmPorukeIB210224_Load(object sender, EventArgs e)
        {
            dgvPoruke.AutoGenerateColumns = false;
            lblStudent.Text = student.Ime + " " + student.Prezime;
            cbPredmeti.DataSource = db.Predmeti.ToList();
            UcitajPoruke();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaPoruka = poruke[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izbrisati ovu poruku?", "Upozorenje!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    db.StudentiPorukeIB210224.Remove(odabranaPoruka);
                    db.SaveChanges();
                }
            }
            UcitajPoruke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB210224 novaPoruka = new frmNovaPorukaIB210224(student);
            if (novaPoruka.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrojPoruka, err, Kljucevi.ObaveznaVrijednost);
        }
        private void GenerisiPoruke(PredmetiIB210224 predmet)
        {
            Thread.Sleep(300);
            var broj = int.Parse(txtBrojPoruka.Text);
            var validnost = dtpValidnost.Value;
            string info = "";

            for (int i = 0; i < broj; i++)
            {
                var novaPoruka = new StudentiPorukeIB210224()
                {
                    StudentId = student.Id,
                    PredmetId = predmet.Id,
                    Validnost = validnost,
                    Hitnost = "Srednja",
                    Sadrzaj = $"{i + 1}. GENERISAN PORUKA",
                    Slika = poruke[0].Slika
                };
                db.StudentiPorukeIB210224.Add(novaPoruka);
                db.SaveChanges();
                info += $"{validnost} -> generisana poruka za {student} na predmetu {predmet} {Environment.NewLine}";
            }

            Action action = () =>
            {
                UcitajPoruke();
                MessageBox.Show($"Generisano je {broj} poruka!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;
            };
            BeginInvoke(action);
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cbPredmeti.SelectedItem as PredmetiIB210224;
                Thread t1 = new Thread(() => GenerisiPoruke(predmet));
                t1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (poruke.Count() > 0)
            {
                frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(poruke);
                frmIzvjestaji.ShowDialog();
            }
        }
    }
}
