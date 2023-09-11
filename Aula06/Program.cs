using System.IO;
using System.Text;
namespace Aula06;

class Program
{
    static void Main(string[] args)
    {
          using(FileStream fluxo = File.Create("arquivo6.txt")) //Crio o arquivo e seu path
          using(StreamWriter escritor = new StreamWriter(fluxo , Encoding.UTF8))  
          {
             escritor.WriteLine("Isso foi criado com File.Create!");  // Atribuo coisas nesse arquivo
          }
    }
}
