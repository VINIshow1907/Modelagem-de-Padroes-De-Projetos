using FactoryMethod_SimpleFactory.boletobancario;

BancoCaixa bancoCaixa = new BancoCaixa(new BoletoSimpleFactory());

bancoCaixa.gerarBoleto(10, 100);
bancoCaixa.gerarBoleto(30,100);
bancoCaixa.gerarBoleto(60,100);
