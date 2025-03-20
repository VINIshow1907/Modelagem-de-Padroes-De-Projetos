using TemplateMethod.GateawyCobranca;
using TemplateMethod.Pagamento;

double valor = 100;
Gateway gateway = new Gateway();

Console.WriteLine("Credito");
PagamentoCredito pgCred = new PagamentoCredito(valor, gateway);
pgCred.realizarCobranca();
Console.WriteLine("Débito");
PagamentoDebito pgDeb = new PagamentoDebito(valor,gateway); 
pgDeb.realizarCobranca();
Console.WriteLine("Dinheiro");
PagamentoDinheiro pgDin = new PagamentoDinheiro(valor,gateway);
pgDin.realizarCobranca();