using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsToys.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto>ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();    
        }

       public List<Producto> ObtenerProductos()
        {

            ListadeProductos = _contexto.Productos.ToList();
            return ListadeProductos;
          
        }    
      
    }
}
