using DecoratorSolucao.Produto;

//Criacção de uma pizza
Console.WriteLine("Cria uma pizza de queijo");
Pizza pizzaQueijo = new PizzaQueijo();

//impressão de sua descrição
Console.WriteLine("Produto--> "+ pizzaQueijo.getDescricao()+ "Valor R$"+ pizzaQueijo.getPreco());

Console.WriteLine(" ");
//adicionada borda de requeijão
Console.WriteLine("Adiciona borda de requeijão");
//um decorator é criado para englobar a pizza
Pizza pizzaQueijoBorda = new BordaRequeijao(pizzaQueijo);

Console.WriteLine("Produto --> " + pizzaQueijoBorda.getDescricao() + "Valor R$" + pizzaQueijoBorda.getPreco());

Console.WriteLine(" ");
//adiciona borda de requeijão
Console.WriteLine("Adiciona massa integral");
//um decorator é criado para englobar a pizza
Pizza pizzaQueijoBordaMassaIntegral = new MassaIntegral(pizzaQueijoBorda);
Console.WriteLine("Produto --> " + pizzaQueijoBordaMassaIntegral.getDescricao() + "Valor R$" + pizzaQueijoBordaMassaIntegral.getPreco());