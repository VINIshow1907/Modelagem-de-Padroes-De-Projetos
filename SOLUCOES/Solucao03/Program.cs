using Solucao03.domains;

try
{
    Console.WriteLine("---------- PEDIDO 01 ----------");
    //Faça seus testes aqui!!!
    Pedido pedido = new Pedido();
    pedido.sucessoAoPagar();
    pedido.despacharPedido();

    Console.WriteLine("---------- PEDIDO 02 ----------");
    Pedido pedido2 = new Pedido();
    pedido2.sucessoAoPagar();
    pedido2.despacharPedido();
    pedido2.cancelarPedido();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}