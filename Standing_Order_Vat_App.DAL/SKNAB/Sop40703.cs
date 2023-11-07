﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40703
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Unitprce { get; set; }
        public int DexRowId { get; set; }
    }
}
