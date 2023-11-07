﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10402
    {
        public string Prcshid { get; set; } = null!;
        public string Epitmtyp { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Psitmval { get; set; }
        public decimal Equomqty { get; set; }
        public decimal Qtybsuom { get; set; }
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
