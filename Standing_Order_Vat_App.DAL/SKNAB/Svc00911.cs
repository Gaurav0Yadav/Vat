﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00911
    {
        public string Srlstat { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}