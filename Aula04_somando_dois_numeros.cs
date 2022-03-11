namespace SomandoDoisNumeros
{
    //Classe
    class Program
    {
        //Método principal
        static void Main(string[] args)
        {
            //Somando dois numeros
            int N1, N2, Resultado;

            //Obtendo os Valores
            Console.Write("Digite o mnúmero 1: ");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mnúmero 2: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            //Processar
            Resultado = N1 + N2;

            //Exibir
            Console.WriteLine("A soma de {0} e {1} é de {2}", N1, N2, Resultado);
            Console.ReadLine();
        }
    }
}