﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pavw30601
    {
        public string Papurordnum { get; set; } = null!;
        public int Ord { get; set; }
        public short Brkfld1 { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public decimal BackoutTradeDiscTax { get; set; }
        public byte CapitalItem { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal Denxrate { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Frtamnt { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal OrigBackoutTradeDiscTax { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public byte Pacbaddfrmfly { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int PacogsIdx { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public int PalineItemSeq { get; set; }
        public string Paprojname { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public short Patu { get; set; }
        public int Pacgbwipidx { get; set; }
        public string Pricelvl { get; set; } = null!;
        public decimal Qtycmtbase { get; set; }
        public decimal Qtyuncmtbase { get; set; }
        public short Ratecalc { get; set; }
        public decimal Trdisamt { get; set; }
        public string Ponumber { get; set; } = null!;
        public short Polnesta { get; set; }
        public short Potype { get; set; }
        public string Itemdesc { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Vnditdsc { get; set; } = null!;
        public short Noninven { get; set; }
        public string Locncode { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Umqtyinb { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public int Invindx { get; set; }
        public DateTime Reqdate { get; set; }
        public DateTime Prmdate { get; set; }
        public DateTime Prmshpdte { get; set; }
        public string Reqstdby { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public short Doctype { get; set; }
        public decimal Polneary1 { get; set; }
        public decimal Polneary2 { get; set; }
        public decimal Polneary3 { get; set; }
        public decimal Polneary4 { get; set; }
        public decimal Polneary5 { get; set; }
        public decimal Polneary6 { get; set; }
        public decimal Polneary7 { get; set; }
        public decimal Polneary8 { get; set; }
        public decimal Polneary9 { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Jobnumbr { get; set; } = null!;
        public string Costcode { get; set; } = null!;
        public short Costtype { get; set; }
        public short Currnidx { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Orextcst { get; set; }
        public short Lineorigin { get; set; }
        public short Freeonboard { get; set; }
        public short Odecplcu { get; set; }
        public short ProductIndicator { get; set; }
        public string SourceDocumentNumber { get; set; } = null!;
        public short SourceDocumentLineNum { get; set; }
        public DateTime Releasebydate { get; set; }
        public DateTime ReleasedDate { get; set; }
        public short PurchaseIvItemTaxable { get; set; }
        public string PurchaseItemTaxSchedu { get; set; } = null!;
        public string PurchaseSiteTaxSchedu { get; set; } = null!;
        public short Purchsitetxschsrc { get; set; }
        public byte Bsivcttl { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public string LandedCostGroupId { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public short LineNumber { get; set; }
        public DateTime Origprmdate { get; set; }
        public DateTime Fstrcptdt { get; set; }
        public DateTime Lstrcptdt { get; set; }
        public short Release { get; set; }
        public string Adrscode { get; set; } = null!;
        public string Cmpnynam { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public short Addrsource { get; set; }
        public short Flags { get; set; }
        public string ProjNum { get; set; } = null!;
        public string CostCatId { get; set; } = null!;
    }
}
