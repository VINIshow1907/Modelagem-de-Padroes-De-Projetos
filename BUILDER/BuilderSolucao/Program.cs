using BuilderSolucao.PDF;

BuilderA4 builderA4 = new BuilderA4();
GeradorPDFDirector director = new GeradorPDFDirector(builderA4);
director.criarGeradorPDF();
GeradorPDF pdfA4 = builderA4.GetGeradorPDF();
Console.WriteLine(pdfA4.ToString());


BuilderA3 builderA3 = new BuilderA3();
GeradorPDFDirector director2 = new GeradorPDFDirector(builderA3);
director2.criarGeradorPDFNotHeadernotFooter();
GeradorPDF pdfA3 = builderA3.GetGeradorPDF();
Console.WriteLine(pdfA3.ToString());