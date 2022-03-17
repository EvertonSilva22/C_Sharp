namespace Tabuada
{
    class Program
    {
        static async void Main(string[] args)
        {
           int tabuada;
           Console.Write("Qual é a tabuada desejada?");
           tabuada = Convert.Toint32(Console.ReadLine());

           for(int i = 1; i <=10; i++)
           {
               Console.WriteLine("{0} x {1} = {2}", tabuada, i, i * tabuada);
           }

           Console.ReadLine();
        }
    }
}