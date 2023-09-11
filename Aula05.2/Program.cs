using System.Text;
using System.IO;

namespace Aula05._2;

class Program
{
    static void Main(string[] args)
    {
        
       using ( FileStream fluxo = new FileStream("arquivo5.2.txt" , FileMode.Create , FileAccess.Write)) // O uso do using mais chaves permitem que não seja necessario finalizar o obj com fluxo.Close();
       using (StreamWriter escritor = new StreamWriter(fluxo)){
                escritor.WriteLine ("Linha k7");
       }

    }
}
