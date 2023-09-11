using System.IO;
using System.Text;

namespace Aula06._1;

class Program
{
    static void Main(string[] args)
    {
        using(FileStream fluxo = File.Create("arquivo6.1.txt"))
        using (StreamWriter escritor = new StreamWriter(fluxo , Encoding.UTF8) )
        {
             byte[] dados = Encoding.UTF8.GetBytes("Isso é um array de dados");


             for(int i= 0 ; i <dados.Length; i++)
             {
                fluxo.WriteByte(dados[i]);
             }

 
 
        }    
     }       
}
