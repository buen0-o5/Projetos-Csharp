using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PretoPDV.Web.Controllers
{
    public class ProdutoController : Controller
    {
        [Authorize]
        public ActionResult CadastrarProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastrarCategoria()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioCategoria()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastrarTratamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioTratamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult Impostos()
        {
            return View();
        }
        [Authorize]
        public ActionResult NFCe()
        {
            return View();
        }














    }
}