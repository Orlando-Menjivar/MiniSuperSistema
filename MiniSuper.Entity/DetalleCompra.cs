using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entity
{
    public class DetalleCompra
    {
        public int DetCompraId { get; set; }
        public  int CompraId   { get; set; } 
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public decimal PrecioCompra { get; set; }
        public  decimal  SubTotal { get; set; }
        
    }
}
