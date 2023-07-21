namespace DesignPatternAlura._03_Template.DesafioRelatorios
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Complexo");
            Console.WriteLine("Rua X, 1234");
            Console.WriteLine("+55 (11) 1234-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@exemplo.com");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
    }
}
