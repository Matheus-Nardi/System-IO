using System.IO;
namespace Aula12;

class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\55639\CalculadoraSimplesApi");

        foreach(var pasta in di.GetDirectories())
        {
              foreach(var arquivo in pasta.GetFiles())
              {
                    Console.WriteLine("----------------------------------------------");
                     Console.WriteLine(arquivo.Name);    // O nome do arquivo 
                     Console.WriteLine(arquivo.FullName);   //Nome do arquivo completo (seu path)
                     Console.WriteLine(arquivo.Extension);   // Retorna o "tipo" do arquivo , no caso .exe
                     Console.WriteLine(arquivo.Exists);   //Se o arquivo existe ou não.
                     Console.WriteLine(arquivo.Attributes); // Retorna se é um arquivo ou outra coisa **
                     Console.WriteLine(arquivo.CreationTime); //Data de criação do arquivo
                     Console.WriteLine("Tamanho do arquivo : {0} KB" , arquivo.Length /1024); //Auto explicativo

              }
        }
    }
}
