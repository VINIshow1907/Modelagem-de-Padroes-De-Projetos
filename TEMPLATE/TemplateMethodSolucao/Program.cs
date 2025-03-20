using TemplateMethodSolucao.GatewayCobranca;
using TemplateMethodSolucao.MetodoPagamento;

double valor =  1000;
Gateway gateway = new Gateway();

Console.WriteLine("Crédito");
PagamentoCredito pgCred = new PagamentoCredito(valor, gateway);
pgCred.realizarCobranca();

Console.WriteLine("Débito");
PagamentoDebito pgDeb = new PagamentoDebito(valor,gateway);
pgDeb.realizarCobranca();

Console.WriteLine("Dinheiro");
PagamentoDinheiro pgDin = new PagamentoDinheiro(valor,gateway);
pgDin.realizarCobranca();
