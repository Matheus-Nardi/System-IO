using System.Text;

namespace Aula05._1;

class Program
{
    static void Main(string[] args)
    {
        FileStream fluxo = new FileStream("arquivo5.1.txt" , FileMode.Create , FileAccess.Write);

        byte[] texto = Encoding.UTF8.GetBytes("Algum texto em bytes ");

        fluxo.Write(texto , 0 , 6);   //Trabalha-se com baixo nível , bytes  
                                      //Passa-se o array , o byte que vai inicar , e até onde parar
        fluxo.Close();                // UTF.8 considera um caractere um byte.

    }
}
