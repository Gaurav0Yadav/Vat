﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag01000
    {
        public int AaUdfid { get; set; }
        public string AaUdfstring { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
