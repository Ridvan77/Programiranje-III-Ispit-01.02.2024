using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB210224
{
    public class StudentiPredmetiIB210224
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB210224 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public string Indeks => Student == null ? "" : Student.BrojIndeksa;
        public bool Aktivan => Student == null ? false : Student.Aktivan;
    }
}
