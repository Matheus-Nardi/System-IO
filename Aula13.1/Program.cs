using System.IO;
namespace Aula13;

class Program
{
    static void Main(string[] args)
    {
            FileInfo fi = new FileInfo(@"C:\Users\55639\Downloads\VSCodeUserSetup-x64-1.81.1.exe"); // Semelhante a Aula13 , pórem usando a classe FileInfo
            Stream saída = new FileStream("Visual-Code.exe" , FileMode.Create , FileAccess.Write);

            Copiar(fi.OpenRead() , saída , 4046); // Passando os paramentros 


    }       


    private static void Copiar(Stream streamIn , Stream streamOut , int tamanhodoBuffer )   //Criação do Método para ler o arquivo 
    {
        int bytesLidos = 0;
        byte[] buffer = new byte[tamanhodoBuffer];    //Buffer : Memória que armazena os dados de forma temporária.

        while((bytesLidos = streamIn.Read(buffer , 0 , buffer.Length)) > 0 ) //Aqui le
        {

            streamOut.Write(buffer , 0 , bytesLidos);

        }
    }
}
