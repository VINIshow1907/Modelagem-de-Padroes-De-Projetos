using Cenario2.Pedidos;
//Cria pedido eletronico
Pedido pedidoEletro = new PedidoEletronico();
//define valor do pedido
pedidoEletro.valor = 100;
//Calcula frete comum
Console.WriteLine("Frete Comum"+ pedidoEletro.nomeSetor+" R$"+pedidoEletro.calcularFreteComum());
//Calcula frete expresso
Console.WriteLine("Frete Comum" + pedidoEletro.nomeSetor + "R$" + pedidoEletro.calcularFreteExpresso());