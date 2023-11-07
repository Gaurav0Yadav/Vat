using AspNetCoreHero.ToastNotification.Abstractions;
using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Web.Helpers;

namespace Standing_Order_Vat_App.Controllers
{
    public class FrgnChksController : Controller
    {
        private readonly IFrgnChks _frgnchks;
        private readonly General_Banking_RegistersContext _context;
        private readonly SKNANBLIVEContext _sKNANBLIVEContext;
        private readonly INotyfService _notyf;

        public FrgnChksController(IFrgnChks frgnChks, General_Banking_RegistersContext context, SKNANBLIVEContext sKNANBLIVEContext, INotyfService notyf)
        {
            _frgnchks = frgnChks;
            _context = context;
            _sKNANBLIVEContext = sKNANBLIVEContext;
            _notyf = notyf;
        }

        public IActionResult Index()
        {
            var rec = _frgnchks.GetBanks();
            ViewBag.BankName = rec;
            return View();
        }

        [HttpGet]
        public IActionResult AddFrgnCheck()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFrgnCheckAsync(ForeignCheckVm foreignChecksDetail)
        {
            if (foreignChecksDetail == null)
            {
                return BadRequest();
            }

            try
            {
                var response = await _frgnchks.AddFrgnCheack(foreignChecksDetail);

                return View(response);
            }
            catch
            {
                throw;
            }
        }

        //[HttpGet]
        //public IActionResult UpdateFrgnCheck(int recordId)
        //{
        //    var result = _frgnchks.UpdateFrgn(recordId);
        //    return View(result);
        //}

        //[HttpPost]
        //public IActionResult UpdateFrgnCheck(ForeignCheckVm foreignCheck)
        //{
        //    var result = _frgnchks.UpdateFrgn(foreignCheck);
        //    ViewBag.record = result;
        //    return RedirectToAction("ViewForeignCheck");
        //}

        public JsonResult Status()
        {
            var status = _context.EntryStatuses.ToList();
            return Json(status);
        }

        public JsonResult Banks()
        {
            var banks = _sKNANBLIVEContext.Banks.ToList();
            return Json(banks);
        }


        //[HttpGet]

        //public IActionResult ViewForeignCheck(ForeignCheckBatchVm foreignCheck,string search,int pg = 1)
        //{
        //    var frgncheck = _frgnchks.ViewFrgn(foreignCheck,search);
        //    const int pageSize = 2;
        //    if (pg < 1)
        //        pg = 1;
        //    int recsCount = frgncheck.Count();
        //    var pager = new Pager(recsCount, pg, pageSize);
        //    int recSkip = (pg - 1) * pageSize;
        //    var data = frgncheck.Skip(recSkip).Take(pager.PageSize).ToList();
        //    this.ViewBag.Pager = pager;
        //    ViewBag.search = search;
        //    ViewBag.result = data;
        //    return View(data);
        //}

        //[HttpGet]
        //public IActionResult DeleteteFrgnCheck(int recordId)
        //{
        //    var result = _frgnchks.DeleteFrgn(recordId);
        //    return RedirectToAction("ViewForeignCheck");
        //}

    }
}

