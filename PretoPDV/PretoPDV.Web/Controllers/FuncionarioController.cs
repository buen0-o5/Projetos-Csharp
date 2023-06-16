using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PretoPDV.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        [Authorize]
        public ActionResult CadastrarFuncionario()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioFuncionario()
        {
            return View();
        }
        [Authorize]
        public ActionResult RelatorioComissao()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroComissao()
        {
            return View();
        }
   
   
    
    }
}