using FIT.Data.IB210224;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;
using System.DirectoryServices;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private DrzaveIB210224 odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB210224> gradovi;
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
            gradovi = db.GradoviIB210224.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
            var tbl = new dsGradovi.dsGradoviDataTable();
            for (int i = 0; i < gradovi.Count(); i++)
            {
                var red = tbl.NewdsGradoviRow();
                red.Rb = (i + 1).ToString();
                red.Grad = gradovi[i].NazivGrada;
                red.Drzava = odabranaDrzava.NazivDrzave;
                red.Aktivan = gradovi[i].Status == true ? "DA" : "NE";
                tbl.AdddsGradoviRow(red);
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
