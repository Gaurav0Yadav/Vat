﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00105
    {
        public string Techid { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Dscriptn { get; set; } = null!;
        public decimal Quantity { get; set; }
        public DateTime Datedone { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
