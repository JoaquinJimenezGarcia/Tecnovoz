using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FamiliaProductoController
    {
        public List<FamiliaProducto> ObtenerFamilias()
        {
            var familia1 = new FamiliaProducto()
            {
                nombre = "Ordenadores",
                nombreSubFamiliaActual = "Informatica",
                categoria = "Electrónica"
            };

            var familia2 = new FamiliaProducto()
            {
                nombre = "Cableado",
                nombreSubFamiliaActual = "Accesorios",
                categoria = "Electrónica"
            };

            var familia3 = new FamiliaProducto()
            {
                nombre = "Programas de seguridad",
                nombreSubFamiliaActual = "Informática",
                categoria = "Software"
            };

            return new List<FamiliaProducto> { familia1, familia2, familia3 };
        }
    }
}