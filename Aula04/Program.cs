using System.IO;
namespace Aula04;

class Program
{
    static void Main(string[] args)
    {
       StreamWriter escritor = new StreamWriter("arquivo4.txt"); // Crio um obj e passa o caminho/nome do arquivo que criarei

       for(int i = 1 ; i<4 ; i++)      // Add coisas no arquivo 
       {
        escritor.WriteLine ( "{0}° Linha " , i);
      
       }
        escritor.Close();  // fechar o objeto 


        StreamReader leitor = new StreamReader("arquivo4.txt");  //Processo inverso , ler o arquivo
        Console.WriteLine(leitor.ReadToEnd());   // imprimindo o arq // não recomendavel pois consome memória de uma só vez

        
        StreamReader leitorLinha  = new StreamReader("arquivo4.txt"); // Instancio o leitor   

        string line ;

        while( (line = leitorLinha.ReadLine()) != null )    //Repetir  o processo linha a linha
        {
             Console.WriteLine(line);
        }
    }
}
