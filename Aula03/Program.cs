using System.IO;
using System.Text;
namespace Aula03;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Olá meus amigos , isso é uma string";

        byte[] bytes = Encoding.UTF8.GetBytes(texto);  // Pega os bytes da minha string

        File.WriteAllBytes("arquivo3.txt" , bytes);   // Passa para o arquivo 3 , trabalha com baixo nível.


        byte[] dados = File.ReadAllBytes("arquivo3.txt");  // Leio a minha array de bytes presente no arquivo 3 
        Console.WriteLine(Encoding.UTF8.GetString(dados)); // Imprimo o mesmo convertendo de bytes para string
        
    }
}
