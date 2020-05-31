using System.Collections.Generic;

namespace LPPA.WebSite.Models
{
    public class Dominio
    {
        private static List<Producto> productos = new List<Producto>();

        public static void Add(Producto producto)
        {
            productos.Add(producto);
        }

        public static List<Producto> Get()
        {
            return productos;
        }
    }
}