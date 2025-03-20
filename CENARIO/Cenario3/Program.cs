using Cenario3.Pedido;

try
{
    //Cria pedido eletronico
    Pedido pedidoEletro = new PedidoEletronico();
    //define valor do pedido
    pedidoEletro.valor = 100;
    //calcula frete comum
    Console.WriteLine("Frete Comum" + pedidoEletro.nomeSetor + "R$" + pedidoEletro.calcularFreteComum());
    //calcula frete expresso
    Console.WriteLine("Frete Comum" + pedidoEletro.nomeSetor + "R$" + pedidoEletro.calcularFreteExpresso());

    //Cria pedido moveis
    Pedido pedidoMoveis = new PedidoMoveis();
    //define valor do pedido
    pedidoMoveis.valor = 100;
    //calcula frete comum
    Console.WriteLine("Frete Comum" + pedidoMoveis.nomeSetor + "R$" + pedidoMoveis.calcularFreteComum());
    //calcula frete expresso
    Console.WriteLine("Frete Expresso" + pedidoMoveis.nomeSetor + "R$" + pedidoMoveis.calcularFreteExpresso());
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}