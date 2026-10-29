using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entity
{
    public class Compra

    {
        public int CompraId { get; set; }
        public DateTime FechaHora { get; set; }
        public string NumeroFactura { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public decimal Total { get; set; }
    }
}
