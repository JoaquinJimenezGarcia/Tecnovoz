using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bienvenidos a la página de Tecnovoz.";

            return View();
        }

        public ActionResult Productos()
        {
            var productoController = new ProductoController();
            var model = productoController.ObtenerProductos();

            ViewBag.Message = "Todos nuestros productos aquí.";

            return View(model);
        }

        public ActionResult FamiliaProductos()
        {
            var familiaProductosController = new FamiliaProductoController();
            var model = familiaProductosController.ObtenerFamilias();

            ViewBag.Message = "Todas nuestras familias de productos bajo la siguiente lista.";

            return View(model);
        }
    }
}