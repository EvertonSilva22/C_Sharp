namespace  Realizandoamultiplicaçãodedoisvalores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obter os valores
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade =   Convert.Toint32(Console.ReadLine());

            //Calcular
            decimal resultado = quantidade * valor;

            //Exibir
            Console.WriteLine("Total da Compra:{0:c}", resultado);
            Console.ReadLine();
        }
    }
}