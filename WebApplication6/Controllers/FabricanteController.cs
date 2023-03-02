using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Contexts;

namespace WebApplication6.Controllers
{
    public class FabricanteController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Fabricante
        public ActionResult Index()
        {
            return View(context.Fabicates.OrderBy(c => c.Nome));
        }
    }
}