using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB210224
{
    public class StudentiPorukeIB210224
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB210224 Predmet { get; set; }
        public DateTime Validnost { get; set; }
        public string Sadrzaj { get; set; }
        public string Hitnost { get; set; }
        public byte[] Slika { get; set; }
    }
}
