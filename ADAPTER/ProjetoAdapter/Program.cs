using ProjetoAdapter.Adapter;
using ProjetoAdapter.Cobranca;

Console.WriteLine("Configurando a cobrança");
Cobranca cobranca = new Cobranca();
cobranca.setValor(100);
cobranca.setNumeroCartao("99999999999");
cobranca.setCVV("163");


// Teste PagFacil

cobranca.setGateway(new PagFacilAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();

// Teste TopPagamentos
cobranca.setGateway(new TopPagamentoAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();
