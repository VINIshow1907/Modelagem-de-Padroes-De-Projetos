using Solucao1.domains;

try
{
    Console.WriteLine("--------------- PEDIDO 01 ---------------");
    //Faça seus testes aqui!!!
    Pedido pedido = new Pedido();
    pedido.sucessoAoApagar();
    pedido.despacharPedido();

    Console.WriteLine("--------------- PEDIDO 02 ---------------");
    Pedido pedido02 = new Pedido();
    pedido02.sucessoAoApagar();
    pedido02.despacharPedido();
    pedido02.cancelarPedido();

} catch (Exception e)
{
    Console.WriteLine(e.Message);
}