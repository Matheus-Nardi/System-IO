using System.IO;
namespace Aula13;

class Program
{
    static void Main(string[] args)
    {
        using(FileStream streamLido = new FileStream(@"C:\Users\55639\Downloads\TLauncher-2.885-Installer-1.1.3.exe", FileMode.Open , FileAccess.Read)) // Passando o path , abrir e ler 
        using (FileStream streamEscrito = new FileStream("tlauncher.exe", FileMode.Create , FileAccess.Write)) // Aqui para escrever 
        {
              Copiar(streamLido , streamEscrito , 2048);  //o Ultimo é o tamanho d o buffer 
        }


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
