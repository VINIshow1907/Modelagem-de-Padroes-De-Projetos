using Cenario4.Fretes;
using Cenario4.Pedidos;

try
{
    //criação dos tipos de frete
    Frete freteComum = new FreteComum();
    Frete freteExpresso = new FreteExpresso();

    //Cria pedido de eletronicos
    Pedido pedidoEletronico = new PedidoEletronicos();
    //define valor do pedido
    pedidoEletronico.valor = 100;
    //define o tipo do frete
    pedidoEletronico.tipoFrete = freteComum;
    //Calcula frete comum
    Console.WriteLine("Frete Comum " + pedidoEletronico.nomeSetor + " R$ " + pedidoEletronico.calculaFrete());

    //Altera o tipo do frete
    pedidoEletronico.tipoFrete = freteExpresso;
    //Calcula frete expresso
    Console.WriteLine("Frete Comum" + pedidoEletronico.nomeSetor + " R$ " + pedidoEletronico.calculaFrete());
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}