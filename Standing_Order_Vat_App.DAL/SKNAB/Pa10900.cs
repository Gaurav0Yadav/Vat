﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10900
    {
        public string PaivDocumentNo { get; set; } = null!;
        public short PaivTransferType { get; set; }
        public string Ivdocnbr { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Parefno { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short Payr { get; set; }
        public DateTime Papd { get; set; }
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Pacomm { get; set; } = null!;
        public string Reqstdby { get; set; } = null!;
        public decimal Patqty { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Patacrv { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public byte[] PaivHdrErrors { get; set; } = null!;
        public byte[] PaivdistributionErrors { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public decimal Noteindx { get; set; }
        public string Taxschid { get; set; } = null!;
        public string Pavenaddressid { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public decimal Bktpuram { get; set; }
        public DateTime TaxDate { get; set; }
        public byte TaxInvRecvd { get; set; }
        public byte TaxInvReqd { get; set; }
        public int DexRowId { get; set; }
    }
}
