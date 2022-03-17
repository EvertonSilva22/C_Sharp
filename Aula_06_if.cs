namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 1 e 10: ");
            int n = Convert.Toint32(Console.ReadLine());

            // Operadores: > (Maior que) < (Menor que) 
            // Operador: || (ou)  && (e)
            if (n<1 || n>10)
            {
                Console.WriteLine("Número errado!");
            }
            else
            {
                Console.WriteLine("Obrigado");
            }
            Console.ReadLine();
        }
    }
}