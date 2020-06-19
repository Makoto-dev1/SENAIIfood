using System;

namespace Aula20Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Marcelo", "Vila Carrão");

            Restaurante BK = new Restaurante("Burger King", "Tatuapé");
            
            Pedido pedido1 = new Pedido();
            pedido1.Cliente = cliente1;
            pedido1.Restaurante = BK;
            

            System.Console.WriteLine( pedido1.EntregarPedido() );
        }
    }
}   
