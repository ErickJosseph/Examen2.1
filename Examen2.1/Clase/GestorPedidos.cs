using Examen2._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2._1.Clase
{
    public class GestorPedidos
    {
        private readonly IProveedor _proveedor;

        public GestorPedidos(IProveedor proveedor)
        {
            _proveedor = proveedor;
        }

        public void EnviarPedidoTipoProducto(Pedidos pedidos, IProveedor proveedor)
        {
            _proveedor.EnviarPedidos(pedidos);
        }

    }
}
