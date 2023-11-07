using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class  ForeignCheckBatchVmw
    {

        public DateTime dateFrom { get; set; } = DateTime.Now;
        public DateTime DateTo { get; set; } = DateTime.Now;
        public List<ForeignCheckBatchVm> foreignCheckBatchVms { get; set; }
    }
}
