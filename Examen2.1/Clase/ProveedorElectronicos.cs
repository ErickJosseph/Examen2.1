using Examen2._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2._1.Clase
{
    public class ProveedorElectronicos : IProveedor
    {
        public void EnviarPedidos(Pedidos pedido)
        {
            Console.WriteLine("Se realizo el envío al proveedor electrónico");
        }

    }
}
