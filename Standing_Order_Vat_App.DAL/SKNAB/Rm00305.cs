﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00305
    {
        public string Salsterr { get; set; } = null!;
        public short Histtype { get; set; }
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public DateTime Smrydate { get; set; }
        public decimal Costamnt { get; set; }
        public decimal Ttlcomam { get; set; }
        public decimal Comsltdt { get; set; }
        public decimal Ncomamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
