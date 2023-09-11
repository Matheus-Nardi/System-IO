using System.IO;
using System.Text;
namespace Aula05;

class Program
{
    static void Main(string[] args)
    {
        FileStream fluxo = new FileStream("arquivo5.txt" , FileMode.Create , FileAccess.Write); // Há varias sobrecargas , primeiro o caminho , depois a criação e a ação 
        StreamWriter escritor = new StreamWriter(fluxo);

        escritor.WriteLine("Uma linha");
        escritor.WriteLine("Outra linha");

        escritor.Close(); //Fechar os obj
        fluxo.Close();


         FileStream stream  = new FileStream("arquivo5.txt", FileMode.Open , FileAccess.Read); //Criação do Stream , para abrir e ler o arquivo 5 


        StreamReader leitor = new StreamReader(stream , Encoding.UTF8) ;

        string line ; // var sentinela  
        while( (line = leitor.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    } 
    
}
