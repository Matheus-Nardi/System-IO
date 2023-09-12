using System.IO;
using System.Text;

namespace Aula08;

class Program
{
    static void Main(string[] args)
    {
        string arquivo = @"C:\Users\55639\Área de Trabalho\Mira.txt";

        using(FileStream streamLido = new FileStream (arquivo , FileMode.Open , FileAccess.Read))
        using(FileStream streamEscrito = new FileStream("Valorant.txt" , FileMode.Create , FileAccess.Write))
        {
                int  bytesLidos = 0 ;
                byte[] buffer = new byte[4096];

                while((bytesLidos = streamLido.Read(buffer , 0 , buffer.Length)) > 0 )
                {
                    streamEscrito.Write(buffer , 0 , bytesLidos);

                    Console.WriteLine("Mais 4kb foram escritos");
                }
        }
       
    }
}
