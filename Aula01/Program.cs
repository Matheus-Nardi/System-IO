using System.IO;
namespace Aula01;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Olá System.IO" ;
        File.WriteAllText("arquivo.txt" , texto);  // Passa como parametro o nome do arquivo que desejo criar e o que ele ira receber
        

        string lerArquivo = File.ReadAllText("arquivo.txt");  // Faz o proceso inverso , le o conteudo do arquivo
        Console.WriteLine(lerArquivo);
        Console.ReadKey();
    }
}
