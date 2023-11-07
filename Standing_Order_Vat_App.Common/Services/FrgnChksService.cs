using GbRegister.Core.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class FrgnChksService : IFrgnChks
    {
        private readonly SKNANBLIVEContext _sknanbLiveContext;
        private readonly General_Banking_RegistersContext _generalBankingRegistersContext;

        public FrgnChksService(SKNANBLIVEContext sknanbLiveContext, General_Banking_RegistersContext generalBankingRegistersContext)
        {
            _sknanbLiveContext = sknanbLiveContext;
            _generalBankingRegistersContext = generalBankingRegistersContext;
        }

        public List<Bank> GetBanks()
        {
            var banks = _sknanbLiveContext.Banks.FromSqlRaw("exec getBank").ToList();
            return banks;
        }


        //public ForeignCheckVm AddFrgnCheck(ForeignCheckVm foreignChecksDetail)
        //{
        //    var parameter = new List<SqlParameter>();
        //    parameter.Add(new SqlParameter("@", product.ProductName));
        //    parameter.Add(new SqlParameter("@ProductDescription", product.ProductDescription));
        //    parameter.Add(new SqlParameter("@ProductPrice", product.ProductPrice));
        //    parameter.Add(new SqlParameter("@ProductStock", product.ProductStock));

        //    var result = await Task.Run(() => _generalBankingRegistersContext.Database
        //   .ExecuteSqlRawAsync(@"exec AddProduct @ProductName, @ProductDescription, @ProductPrice, @ProductStock", parameter.ToArray()));

        //    return result;
        //}

        //public ForeignCheckVm UpdateFrgn(int recordId)
        //{

        //}

        //public ForeignCheckVm UpdateFrgn(ForeignCheckVm foreignCheck)
        //{



        //}

        //public List<ForeignCheckBatchVm> ViewFrgn(ForeignCheckBatchVm foreignCheck, string search, int pg = 1)
        //{

        //}

        //public ForeignCheckVm DeleteFrgn(int recordId)
        //{
        //    return 1;
        //}

        public async Task<int> AddFrgnCheack(ForeignCheckVm foreignCheckVm)
        {

            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@btchId", foreignCheckVm.BatchId));
            parameter.Add(new SqlParameter("@chkNum", foreignCheckVm.CheckNumber));
            parameter.Add(new SqlParameter("@payAcctName", foreignCheckVm.PayerAcctName));
            parameter.Add(new SqlParameter("@depAcctNum", foreignCheckVm.DepositAcctNumber));
            parameter.Add(new SqlParameter("@depAcctName", foreignCheckVm.DepositAcctName));
            parameter.Add(new SqlParameter("@chkAmt", foreignCheckVm.CheckAmount));

            var result = await Task.Run(() => _generalBankingRegistersContext.Database
          .ExecuteSqlRawAsync(@"exec NewFrgnChkDetails @btchId,@chkNum,@payAcctName, @depAcctNum,@depAcctName,@chkAmt", parameter.ToArray()));

            return result;

        }
    }
}

