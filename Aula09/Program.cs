using System.Text;
using System.IO;

namespace Aula09;


class Program
{
    static void Main(string[] args)
    {


       Console.Write("Digite o caminho completo do arquivo: ");
       string caminhoArquivo =@"";
       caminhoArquivo = Console.ReadLine();

        FileInfo fi = new FileInfo(caminhoArquivo); //Passando o path do arquivo

        Console.WriteLine(fi.Name);    // O nome do arquivo 
        Console.WriteLine(fi.FullName);   //Nome do arquivo completo (seu path)
        Console.WriteLine(fi.Extension);   // Retorna o "tipo" do arquivo , no caso .exe
        Console.WriteLine(fi.Exists);   //Se o arquivo existe ou não.
        Console.WriteLine(fi.Attributes); // Retorna se é um arquivo ou outra coisa **
        Console.WriteLine(fi.CreationTime); //Data de criação do arquivo
        Console.WriteLine("Tamanho do arquivo : {0} KB" , fi.Length /1024); //Auto explicativo
    }
}
