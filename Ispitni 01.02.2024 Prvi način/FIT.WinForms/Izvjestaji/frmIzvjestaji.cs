using FIT.Data.IB210224;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB210224> gradovi;
        private DrzaveIB210224 odabranaDrzava;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(DrzaveIB210224 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            gradovi = db.GradoviIB210224.Include("Drzava").Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
            var tbl = new dsGradovi.dsGradoviDataTable();
            for (int i = 0; i < gradovi.Count(); i++)
            {
                var Red = tbl.NewdsGradoviRow();
                Red.Rb = (i + 1).ToString();
                Red.Grad = gradovi[i].NazivGrada;
                Red.Drzava = gradovi[i].Drzava.NazivDrzave;
                Red.Aktivan = gradovi[i].Status == true ? "DA" : "NE";
                tbl.Rows.Add(Red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dsGradovi";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("brojGradova", gradovi.Count().ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
