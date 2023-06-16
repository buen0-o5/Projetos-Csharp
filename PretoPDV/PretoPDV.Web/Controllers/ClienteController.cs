using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PretoPDV.Web.Controllers
{
    public class ClienteController : Controller
    {
        [Authorize]
        public ActionResult CadastrarCliente()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioCliente()
        {
            return View();
        }
                           

    }
}