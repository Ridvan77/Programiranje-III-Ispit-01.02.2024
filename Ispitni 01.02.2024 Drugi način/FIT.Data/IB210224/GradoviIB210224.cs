﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB210224
{
    public class GradoviIB210224
    {
        public int Id { get; set; }
        public string NazivGrada { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public DrzaveIB210224 Drzava { get; set; }
        public override string ToString()
        {
            return NazivGrada;
        }
    }
}
