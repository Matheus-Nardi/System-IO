using System.IO;
using System.Text;
namespace Aula07;

class Program
{
    static void Main(string[] args)
    {
        FileStream stream  = new FileStream("Aula05\arquivo5.txt ", FileMode.Open , FileAccess.Read); //Criação do Stream , para abrir e ler o arquivo 5 


        StreamReader leitor = new StreamReader(stream , Encoding.UTF8) ;

        string line ; // var sentinela  
      //  while( (line = leitor.ReadLine()) != null)
       // {
       //     Console.WriteLine(line);
      //  }


      //Outra maneira utilizando leitor.Peek

      while(leitor.Peek() > 0)
      {
        line = leitor.ReadLine();
        Console.WriteLine(line);
      }


    }
}
