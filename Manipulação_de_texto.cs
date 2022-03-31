namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enviroment
            string pasta=Enviroment.GetFolderPatch(Enviroment.SpecialFolder.MyDocuments);
            string arquivo = "teste.txt";
            string path = path.Combine(pasta, arquivo);

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("Escrevendo no arquivo de texto...");
            writer>writeLine("Outra Linha...");
            writer.Close();

            StreamReader reader = new  StreamReader(path);
            while (!reader.EndOfStream)
            {
            string linha=reader.ReadLine();
            Console.WriteLine(linha);
            }
            Console.ReadLine();
        }
    }
}