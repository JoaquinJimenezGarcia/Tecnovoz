using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductoController
    {
        public Producto ObtenerProducto()
        {
            return new Producto()
            {
                Cadena = "Producto uno"
            };
        }

        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto()
            {
                Cadena = "Producto Primero"
            };

            var producto2 = new Producto()
            {
                Cadena = "Producto Secundario"
            };

            var producto3 = new Producto()
            {
                Cadena = "Producto Tercero"
            };

            return new List<Producto>{ producto1, producto2, producto3};
        }
    }
}