using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IFrgnChks
    {
        List<Bank> GetBanks();

        public Task<int>AddFrgnCheack(ForeignCheckVm foreignCheckVm);
        //ForeignCheckVm UpdateFrgn(int recordId);
        //ForeignCheckVm UpdateFrgn(ForeignCheckVm foreignCheck);
        //List<ForeignCheckBatchVm> ViewFrgn(ForeignCheckBatchVm foreignCheckbatchVm,string search,int pg = 1);
        //ForeignCheckVm DeleteFrgn(int recordId);

    }
}
