using System.IO;
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
    } 
    
}
