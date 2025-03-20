using CenarioNumero1.Pedidos;

//Criação do pedido
Pedido pedido = new Pedido();

//Atribuição do valor
pedido.valor = 100;

//Calculo para frete comum:
Console.WriteLine("Frete Comum: R$" + pedido.calcularFreteComum());
//Calculo para frete expresso
Console.WriteLine("Frete Expresso: R$" + pedido.calcularFreteExpresso());