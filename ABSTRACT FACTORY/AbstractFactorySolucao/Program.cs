
using AbstractFactorySolucao.Boleto;
using AbstractFactorySolucao.Boleto.Familia;

Banco banco = new Banco();

CalculosFactory factoryCaixa = new CaixaCalculosFactory();

CalculosFactory factoryBB = new BBCalculosFactory();

Console.WriteLine(" criar boleto caixa");
banco.gerarBoleto(100,factoryCaixa);

Console.WriteLine("criar boleto BB");
banco.gerarBoleto(100, factoryBB);