namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(condição) { }
            // ! Não
            // == igual
            // != Diferente 
            string senha = "123";
            string SenhaInformada=string.Empty;
            while (senha != SenhaInformada)
            {
                Console.write("Digite a senha: ");
                SenhaInformada = Console.ReadLine();
            }
            Console.WriteLine("Fim");

            //for ( inicia; condição; incremento) {}
            //Operador ++

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */
            Console.ReadLine();
        }
    }
}