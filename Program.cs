using System;

namespace Aula20Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Marcelo", "Vila Carrão");
            System.Console.WriteLine( cliente1.MostrarDados() );

            Restaurante BK = new Restaurante("Burger King", "Tatuapé");
            System.Console.WriteLine( BK.MostrarDados() );
            
            Pedido pedido1 = new Pedido("Whooper e Coca-Cola","Marcelo");
            pedido1.Cliente = cliente1.Nome;
            pedido1.Restaurante = BK.Nome;
            System.Console.WriteLine($"Detalhes do pedido: itens,{pedido1.Itens}. cliente,{pedido1.Cliente}");
            

            System.Console.WriteLine( pedido1.EntregarPedido() );
        }
    }
}
