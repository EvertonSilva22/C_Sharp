namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            string nome = "José";

            short quantidade = 100;
            int numero = 20;
            long numeroGrande = 120000;
            byte item = 20;

            double comissao = 32.45787898798;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 1000.56m;

            DateTime data = Datetime.now;
            DateTime dataExemplo = new  DateTime(2050, 12, 31);

            //Formatar

            Console.WriteLine("{0}", dataexemplo);

            Console.ReadLine();

        }
    }
}