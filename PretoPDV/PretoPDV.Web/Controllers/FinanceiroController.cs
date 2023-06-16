using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PretoPDV.Web.Controllers
{
    public class FinanceiroController : Controller
    {
        [Authorize]
        public ActionResult ContasPagar()
        {
            return View();
        }
        [Authorize]
        public ActionResult ContasReceber()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioCPagar()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioCReceber()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioVendas()
        {
            return View();
        }
        [Authorize]
        public ActionResult FormaPagamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult RFpagamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioNFCe()
        {
            return View();
        }

    
    
    
    }
}