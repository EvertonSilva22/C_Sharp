namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime>now.Hour;
            string mensagem = string.Empty;
            switch (hora)
            {
                case 10:
                    mensagem = "Hora do Intervalo";
                    break;
                case 12:
                    mensagem = "Almoço";
                    break;
                case 15: 
                    mensagem = "Horado Intervalo";
                    break;
                default:
                    mensagem = string.Empty;
                    break;            
            }
            Console.ReadLine();
        }
    }
}