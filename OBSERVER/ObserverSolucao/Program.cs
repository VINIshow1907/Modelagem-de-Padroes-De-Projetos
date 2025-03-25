// criação newslleter (subject)
using ObserverSolucao.Observers;
using ObserverSolucao.Subjects;

Newsletter newsletter = new Newsletter();

//criação funcionarios
Funcionario funcionario1 = new Funcionario(nome: "Func01", email: "func01@teste.com");
newsletter.registerObserver(funcionario1);
Funcionario funcionario2 = new Funcionario(nome: "Func02", email: "func02@teste.com");
newsletter.registerObserver(funcionario2);

//criacao cliente
Cliente cliente = new Cliente(nome: "Cli01", email: "cli01@teste.com");
newsletter.registerObserver(cliente);

//criação parceiro
Parceiro parceiro = new Parceiro(nome: "Parça01", email: "parca01@teste.com");
newsletter.registerObserver(parceiro);

//criação fornecedor
Fornecedor fornecedor = new Fornecedor(nome: "forn01", email: "forn01@teste.com");
newsletter.registerObserver(fornecedor);

//envio primeiro mensagem
Console.WriteLine("----------TESTE PRIMEIRA MENSAGEM----------");
newsletter.addMessage("Primeira Mensagem");

newsletter.removeObserver(funcionario2);

Console.WriteLine("----------TESTE SEGUNDA MENSAGEM----------");
newsletter.addMessage("Segunda mensagem");

newsletter.registerObserver(funcionario2);

Console.WriteLine("----------TESTE TERCEIRA MENSAGEM----------");
newsletter.addMessage("Terceira mensagem");
