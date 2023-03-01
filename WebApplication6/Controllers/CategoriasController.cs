using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class CategoriasController : Controller
    {

        private static IList<Categoria> categorias =
            new List<Categoria>() {
                new Categoria() {
                   CategoriaId =   1,
                    Nome    =   "Notebooks"
                },
                new Categoria() {
                CategoriaId =   2,
                Nome    =   "Monitores"
                },
                new Categoria() {
                CategoriaId =   3,
                Nome    =   "Impressoras"
                },
                new Categoria() {
                CategoriaId =   4,
                },
                new Categoria() {
                CategoriaId =   5,
                 Nome    =   "Desktops"
                }
            };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }
    }
}