using DesignPatternAlura;
using DesignPatternAlura._03_Template;
using DesignPatternAlura._04_Decorator.DesafioIKCV_ICPP;
using DesignPatternAlura._04_Decorator.DesafioImpostoAlto;
using DesignPatternAlura._06_Builder;
using DesignPatternAlura._06_Builder.DesafioBuilderItemNota;
using DesignPatternAlura._06_Builder.DesafioBuilderParametroOpcional;
using DesignPatternAlura.Responsability.DesafioVendaCasada.Descontos;
using DesignPatternAlura.Strategy.DesafioICCC;

Orcamento orcamento = new Orcamento(500.0);
orcamento.AdicionaItem(new Item("CANETA", 250.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));

Console.WriteLine("Valor do orçamento: R$" + orcamento.Valor);
LinhaEncerramento();

#region Strategy
Console.WriteLine("\nDesáfios Strategy: \n");

Imposto impostICCC = new ICCC();
Console.WriteLine("Calculando ICCC: " + impostICCC.Calcula(orcamento));

LinhaEncerramento();
#endregion

#region Responsability
Console.WriteLine("\nDesáfios Responsability: \n");

CalculadorDeDescontos calculador = new CalculadorDeDescontos();
double desconto = calculador.Calcula(orcamento);

Console.WriteLine("Calculando desconto: " + desconto);

LinhaEncerramento();
#endregion

#region Template
Console.WriteLine("\nDesáfios Template: \n");

TemplateDeImpostoCondicional icpp = new ICPP();
TemplateDeImpostoCondicional ikvc = new IKCV();

Console.WriteLine("Calculando ICPP: " + icpp.Calcula(orcamento));
Console.WriteLine("Calculando IKVC: " + ikvc.Calcula(orcamento));

LinhaEncerramento();
#endregion

#region Decorator
Console.WriteLine("\nDesáfios Decorator: \n");

Imposto impostos = new ImpostoMuitoAlto(new IHIT());

Console.WriteLine("Calculando imposto muito alto (20%): " + impostos.Calcula(orcamento));

LinhaEncerramento();
#endregion

#region State
Console.WriteLine("\nDesáfios State: \n");

orcamento.AplicaDescontoExtra();
Console.WriteLine(orcamento.Valor); // imprime 475,00 pois descontou 5%
orcamento.Aprova();

orcamento.AplicaDescontoExtra();
Console.WriteLine(orcamento.Valor); // imprime 465,50 pois descontou 2%

orcamento.Finaliza();

LinhaEncerramento();
#endregion

#region Builder
Console.WriteLine("\nDesáfios Builder: \n");

ItemDaNota inf1 = new ItemDaNotaBuilder()
                        .ComValor(100.0)
                        .ComNome("Item 1")
                        .Constroi();

ItemDaNota inf2 = new ItemDaNotaBuilder()
                        .ComValor(250.0)
                        .ComNome("Item 2")
                        .Constroi();

NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")
                          .ComCnpj("123.456.789/0001-10")
                          .Com(inf1)
                          .Com(inf2)
                          .Com(new ItemDaNota("item 3", 300.0))
                          .ComObservacoes("entregar nf pessoalmente")
                          .Constroi();

Console.WriteLine("Total de notas fiscais: " + nf.Itens.Count);

LinhaEncerramento();
#endregion

#region Observer
Console.WriteLine("\nDesáfios Observer: \n");

//NotaFiscalBuilderModificada builder = new NotaFiscalBuilderModificada();

//NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
//    .ComCnpj("123.456.789/0001-10")
//    .Com(new ItemDaNota("item 1", 100.0))
//    .Com(new ItemDaNota("item 2", 200.0))
//    .Com(new ItemDaNota("item 3", 300.0))
//    .ComObservacoes("entregar notaFiscal pessoalmente")
//    .Constroi();

LinhaEncerramento();
#endregion

static void LinhaEncerramento()
{
    Console.WriteLine("\n--------------||---------------");
}