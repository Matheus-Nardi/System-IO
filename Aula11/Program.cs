using System.IO;
namespace Aula11;

class Program
{
    static void Main(string[] args)
    {
        string[] diretorios = Directory.GetDirectories(@"C:\Program Files");  

        foreach( var diretorio in diretorios) // Exibindo todos os diretorios existentes no path acima 
        {
            Console.WriteLine(diretorio);
        }
        Console.WriteLine("--------------------------------");

        foreach( var  arquivo in Directory.GetFiles(@"C:\Riot Games\VALORANT\live"))
        {
            Console.WriteLine(arquivo);   // Exibindo os aruivos e não os diretorios/subdiretorios
        }
    }
}
