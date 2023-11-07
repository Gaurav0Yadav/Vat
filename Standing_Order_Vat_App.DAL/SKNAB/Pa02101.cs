﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02101
    {
        public string Paprojnumber { get; set; } = null!;
        public int PalineItemSeq { get; set; }
        public string PafeeId { get; set; } = null!;
        public string PafeeName { get; set; } = null!;
        public short PafeeType { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PapercentCost { get; set; }
        public decimal PapercentRevenue { get; set; }
        public decimal PaRetentionPercent { get; set; }
        public short PafeeToUse { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public short PasalesTaxOptions { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public DateTime Pabegindate { get; set; }
        public DateTime PaenDate { get; set; }
        public short Pafrequency { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Parenew { get; set; }
        public DateTime ParenewalDate { get; set; }
        public decimal PatotAmt { get; set; }
        public short TmArFeeSrc { get; set; }
        public short TmPrjDeferredRevFee { get; set; }
        public short TmPrjRevFeeSrc { get; set; }
        public short PaffArFeeSrc { get; set; }
        public short FfPrjBillingsFeeSrc { get; set; }
        public short FfPrjRevFeeSrc { get; set; }
        public short FfRetentionFeeSrc { get; set; }
        public short FfWipFeeSrc { get; set; }
        public short FfPrjDeferredRevFee { get; set; }
        public short FfBieeFeeSrc { get; set; }
        public short FfEiebFeeSrc { get; set; }
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public short PaRenewDay { get; set; }
        public short PaRenewMonth { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public decimal PaserviceFeeAmount { get; set; }
        public decimal PaMcFeeAmount { get; set; }
        public decimal PaMcServiceFeeAmount { get; set; }
        public decimal PaMcTotalAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
