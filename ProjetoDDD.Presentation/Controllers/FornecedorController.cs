using projetoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDDD.Presentation.Controllers
{
    public class FornecedorController : Controller
    {
        // GET: Fornecedor

        private IAppFornecedorService appFornecedorService;

        public FornecedorController(IAppFornecedorService iAppFornecedor)
        {
            this.appFornecedorService = iAppFornecedor;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObtemTodos()
        {
            return View(appFornecedorService.ObtemTodos());
        }

        public ActionResult ObtemFornecedor(int id)
        {
            return View(appFornecedorService.ObterFornecedor(id));
        }
    }
}