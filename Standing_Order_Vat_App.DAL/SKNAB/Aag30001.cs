﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag30001
    {
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public string Interid { get; set; } = null!;
        public string CorrespondingUnit { get; set; } = null!;
        public int Actindx { get; set; }
        public short Accttype { get; set; }
        public short AaBrowseType { get; set; }
        public short Decplacs { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int Seqnumbr { get; set; }
        public int AaCustId { get; set; }
        public int AaVendId { get; set; }
        public int AaSiteId { get; set; }
        public int AaItemId { get; set; }
        public short AaCopyStatus { get; set; }
        public DateTime AaChangeDate { get; set; }
        public DateTime AaChangeTime { get; set; }
        public int DexRowId { get; set; }
    }
}
