﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05630
    {
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short SvcDistributionType { get; set; }
        public string DistRef { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public int DexRowId { get; set; }
    }
}
