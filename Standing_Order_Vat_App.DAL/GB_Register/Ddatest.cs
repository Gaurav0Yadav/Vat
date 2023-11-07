﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class Ddatest
    {
        public double? CurrentBalance { get; set; }
        public double? MemoBalance { get; set; }
        public double? CtdAverageBalance { get; set; }
        public double? CtdLowestBalance { get; set; }
        public double? LastStmtBalance { get; set; }
        public double? DateLastCheque { get; set; }
        public double? DateLastDeposit { get; set; }
        public double? DateLastCycled { get; set; }
        public double? TypeCode { get; set; }
        public double? RateCode { get; set; }
        public double? CtdDebits { get; set; }
        public double? CtdCredits { get; set; }
        public double? InterestRate { get; set; }
        public double? ServiceChargeCode { get; set; }
        public double? YtdODDays { get; set; }
        public double? ODDaysLastYear { get; set; }
        public double? ConsecutiveDaysOd { get; set; }
        public double? DateLastOverdraft { get; set; }
        public double? _1DayFloatAm { get; set; }
        public double? _2DayFloatAm { get; set; }
        public double? _3DayFloatAm { get; set; }
        public double? AggregateFloatAmt { get; set; }
        public double? CardholderNumber { get; set; }
        public double? StatementRequest { get; set; }
        public double? StmtCycleCode { get; set; }
        public double? CtdChecks { get; set; }
        public double? LastChequeAm { get; set; }
        public double? LastDepositA { get; set; }
        public double? DatePreviousStmt { get; set; }
        public double? PreviousStmtBal { get; set; }
        public double? InterestEarned { get; set; }
        public double? YtdInterestP { get; set; }
        public double? YtdAverageBalance { get; set; }
        public double? YtdServiceCh { get; set; }
        public double? OdType { get; set; }
        public double? ODLimitWhole { get; set; }
        public double? OverdraftRate { get; set; }
        public double? ODInterestCode { get; set; }
        public double? DdaMiscFld1 { get; set; }
        public double? DdaMiscFld2 { get; set; }
        public double? DateODExpires { get; set; }
        public double? ODInterest { get; set; }
        public double? ODIntrstPai { get; set; }
        public double? ExemptOdNsfChrg { get; set; }
        public double? StatementSortCode { get; set; }
        public double? FixedMoneyMktRate { get; set; }
        public double? ODPenaltyRate { get; set; }
        public double? UnpostToday { get; set; }
        public double? CtdAtmWithdrawals { get; set; }
        public double? TransitDic { get; set; }
        public double? ClearingDic { get; set; }
        public double? LowCollectedBal { get; set; }
        public double? AggregateCred { get; set; }
        public double? CtdDaysOverdrawn { get; set; }
        public double? AggregateOdBalance { get; set; }
        public double? StmtMessageCode { get; set; }
        public double? YtdNsfChecks { get; set; }
        public double? YtdDebits { get; set; }
        public double? YtdCredits { get; set; }
        public double? PreviousYearDebits { get; set; }
        public double? PrevYearCredits { get; set; }
        public double? PrevYearNsfChks { get; set; }
        public double? PrevYrAverageBal { get; set; }
        public double? LowBalanceMtd { get; set; }
        public double? OnUsDic { get; set; }
        public double? DiscountOnSerChg { get; set; }
        public double? SerChgRunningBal { get; set; }
        public double? FixedSerChgAmount { get; set; }
        public double? MaximumServCharge { get; set; }
        public double? CdXYSCCyclTd { get; set; }
        public double? CalcSerChargeCtd { get; set; }
        public double? TargetBalance { get; set; }
        public double? CounterChecksCtd { get; set; }
        public double? HighBalanceAmount { get; set; }
        public double? TransferToType { get; set; }
        public double? TransferToAccount { get; set; }
        public double? LowBalanceAmount { get; set; }
        public double? TransferFromType { get; set; }
        public double? AcctToTrnsfrFrom { get; set; }
        public double? AcctForInterest { get; set; }
        public double? AcctTypeForIntr { get; set; }
        public double? TransferOutAmount { get; set; }
        public double? TrnsfrSCIn { get; set; }
        public double? TrnsfrSCOut { get; set; }
        public double? BankClubCode { get; set; }
        public double? BankClubChgAmt { get; set; }
        public double? FieldNotUsed { get; set; }
        public double? YtdTransitItmCnt { get; set; }
        public double? YtdClringItemCnt { get; set; }
        public double? _45DayFloat { get; set; }
        public double? _610DayFloat { get; set; }
        public double? _1115DayFloa { get; set; }
        public double? Over15DayFl { get; set; }
        public double? ODOrNsfCurMo { get; set; }
        public double? ODOrNsfPrevMo { get; set; }
        public double? ODOrNsfPrevMo2 { get; set; }
        public double? ODOrNsfPrevMo3 { get; set; }
        public double? ODOrNsfPrevMo4 { get; set; }
        public double? ODOrNsfPrevMo5 { get; set; }
        public double? ODOrNsfPrevMo6 { get; set; }
        public double? DtLstODNsf5000 { get; set; }
        public double? MtdCredCnt { get; set; }
        public double? ClubChargeCode { get; set; }
        public double? CheckSizeCode { get; set; }
        public double? MtdHiBal { get; set; }
        public double? MultiStmtGrenada { get; set; }
        public double? YtdHiBal { get; set; }
        public double? MtdCreditTot { get; set; }
        public double? MtdAggrBalan { get; set; }
        public double? DailyODAccrual { get; set; }
        public double? ComtelBalance { get; set; }
        public double? AggrDebits { get; set; }
        public double? ChargedOff { get; set; }
        public double? AutoClose { get; set; }
        public double? AmtChargedOff { get; set; }
        public double? MiscField2 { get; set; }
        public double? MiscField3 { get; set; }
        public double? ExemptChgBack { get; set; }
        public double? CheckTruncation { get; set; }
        public double? OpenDepAmt { get; set; }
        public double? MtdAggBal { get; set; }
        public double? PrevCycleCode { get; set; }
        public double? PrevSerChgCode { get; set; }
        public double? CtdSerChgDebits { get; set; }
        public double? CtdSerChgCredits { get; set; }
        public double? PersMmdaTrans { get; set; }
        public double? TotTransferDebits { get; set; }
        public double? TotInclearings { get; set; }
        public double? CurrentViolation { get; set; }
        public double? ViolationHistory { get; set; }
        public double? SpecPostageSC { get; set; }
        public double? ForeignAtmWDs { get; set; }
        public double? ExemptForAtmSC { get; set; }
        public double? IntrEarndNot { get; set; }
        public double? PrevExcessViol { get; set; }
        public double? DownloadAcct { get; set; }
        public double? ExemptFromPosChg { get; set; }
        public double? DsiImageHorizontal { get; set; }
        public double? DsiImageVertical { get; set; }
        public double? DsiImagePgFormat { get; set; }
        public double? DsiImageFrontBck { get; set; }
        public double? DsiImageDrCr { get; set; }
        public double? QtdHighBalance { get; set; }
        public double? QtdHighODBal { get; set; }
        public double? QtdIntrstExp { get; set; }
        public double? QtdIntrstInc { get; set; }
        public double? LoanLossProv { get; set; }
        public double? SpecificProv { get; set; }
        public double? SecurityValue { get; set; }
        public double? SecurityCodes { get; set; }
        public double? PosTransCtd { get; set; }
        public double? CtdAverageBalance1 { get; set; }
        public double? CtdAverageFl { get; set; }
        public double? YtdAverageBalance1 { get; set; }
        public double? YtdAverageCo { get; set; }
        public double? AvailableBalance { get; set; }
        public double? AvailCrSafetyChk { get; set; }
        public double? NsfItemFee { get; set; }
        public double? DateChargedOff { get; set; }
        public double? ChargeOffRecovery { get; set; }
        public double? DateOfRecovery { get; set; }
        public double? YtdNsfPresented { get; set; }
        public double? PrevYearNsfItems { get; set; }
        public double? YtdNsfReturns { get; set; }
        public double? PrevYrNsfReturns { get; set; }
        public double? ODIntRateCode { get; set; }
        public double? ODIntRateAdj { get; set; }
        public double? YtdODIntEa { get; set; }
        public double? TotalAtmWDMtd { get; set; }
        public double? ForeignAtmWDMtd { get; set; }
        public double? TotalAtmWDYtd { get; set; }
        public double? ForeignAtmWDYtd { get; set; }
        public double? TotalAtmWDPrYr { get; set; }
        public double? ForiegnAtmWDPrY { get; set; }
        public double? PosTransactionsMtd { get; set; }
        public double? PosAmountMtd { get; set; }
        public double? PosTransactionsYtd { get; set; }
        public double? AmountOfPos { get; set; }
        public double? NumberOfPosPrYr { get; set; }
        public double? PosAmountLas { get; set; }
        public double? AnalysisCounter1 { get; set; }
        public double? AnalysisCounter2 { get; set; }
        public double? AnalysisCounter3 { get; set; }
        public double? AnalysisCounter4 { get; set; }
        public double? AnalysisCounter5 { get; set; }
        public double? AnalysisCounter6 { get; set; }
        public double? AnalysisCounter7 { get; set; }
        public double? AnalysisCounter8 { get; set; }
        public double? AnalysisCounter9 { get; set; }
        public double? AnalysisCounter10 { get; set; }
        public double? AnalysisAmounT1 { get; set; }
        public double? AnalysisAmounT2 { get; set; }
        public double? AnalysisAmounT3 { get; set; }
        public double? AnalysisAmounT4 { get; set; }
        public double? AnalysisAmounT5 { get; set; }
        public double? AnalysisAmounT6 { get; set; }
        public double? AnalysisAmounT7 { get; set; }
        public double? AnalysisAmounT8 { get; set; }
        public double? AnalysisAmounT9 { get; set; }
        public double? AnalysisAmounT10 { get; set; }
        public double? StopPyNoticeFlag { get; set; }
        public double? StopPyAutoChgFlg { get; set; }
        public double? UncollectedBalance { get; set; }
        public double? PriorDayUncollBal { get; set; }
        public double? AtmCreditsCtd { get; set; }
        public double? ForeignAtmCrCtd { get; set; }
        public double? TotalAtmCreditMtd { get; set; }
        public double? ForeignAtmCrMtd { get; set; }
        public double? TotlAtmCreditsYtd { get; set; }
        public double? ForeignAtmCrYtd { get; set; }
        public double? AtmCreditsPriorYr { get; set; }
        public double? ForeignAtmCrPrYr { get; set; }
        public double? AnalysisPrimAcct { get; set; }
        public double? _2ndTransferToType { get; set; }
        public double? _2ndTransferToAcct { get; set; }
        public double? _2ndTrfFromType { get; set; }
        public double? _2ndTrfFromAcct { get; set; }
        public double? CashMgmtRepoFlag { get; set; }
        public double? CshMgtCollBalFlg { get; set; }
        public double? OdLoanPymtFlag { get; set; }
        public double? InterestDispCode { get; set; }
        public double? AchRoutingNumber { get; set; }
        public double? AchTransactionCode { get; set; }
        public double? AchAccountNumber { get; set; }
        public double? StmtSrtPrAcctFlg { get; set; }
        public double? JanAvgBal { get; set; }
        public double? FebAvgBal { get; set; }
        public double? MarAvgBal { get; set; }
        public double? AprAvgBal { get; set; }
        public double? MayAvgBal { get; set; }
        public double? JunAvgBal { get; set; }
        public double? JulAvgBal { get; set; }
        public double? AugAvgBal { get; set; }
        public double? SepAvgBal { get; set; }
        public double? OctAvgBal { get; set; }
        public double? NovAvgBal { get; set; }
        public double? DecAvgBal { get; set; }
        public double? ServiceChgWaiveCd { get; set; }
        public double? SerChrgWaiveDate { get; set; }
        public double? SerChgsWaivedYtd { get; set; }
        public double? SerChgsWaivedLYr { get; set; }
        public double? SChgsReversedYtd { get; set; }
        public double? SChgsReversedPyr { get; set; }
        public double? NsfWaivedYtdAcct { get; set; }
        public double? NsfWaivedPyrAcct { get; set; }
        public double? NsfWaivedOperYtd { get; set; }
        public double? NsfWaivedOperPyr { get; set; }
        public double? NsfReversedYtd { get; set; }
        public double? NsfReversedPyr { get; set; }
        public double? AcctAnalysisType { get; set; }
        public double? AnalysisSettlmtMo { get; set; }
        public double? AnalysisSettleFrq { get; set; }
        public double? PrvMonthCarr { get; set; }
        public double? CurMonthCarr { get; set; }
        public double? ExemptSalesTax { get; set; }
    }
}
