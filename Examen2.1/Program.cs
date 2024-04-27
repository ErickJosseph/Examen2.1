
using Examen2._1.Clase;
using Examen2._1.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        GestorPedidos gestorPedidos = new GestorPedidos(new ProveedorElectronicos());
        GestorPedidos gestorPedidos2 = new GestorPedidos(new ProveedoresRopa());

        Pedidos pedido = new Pedidos()
        {
            TipoPedidos = "electro",
            Categoria = "Electrónico",
            Nombre = "Refrigerador"
        };

        Pedidos pedido2 = new Pedidos()
        {
            TipoPedidos = "Ropa",
            Categoria = "Ropa",
            Nombre = "Camisa"
        };

        gestorPedidos.EnviarPedidoTipoProducto(pedido, new ProveedorElectronicos());
        gestorPedidos2.EnviarPedidoTipoProducto(pedido, new ProveedorElectronicos());
    }
}
