﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00407
    {
        public int AaTrxDimId { get; set; }
        public byte AaAllowAdjustment { get; set; }
        public byte AaCodeReqdDrgAdj { get; set; }
        public int DexRowId { get; set; }
    }
}
