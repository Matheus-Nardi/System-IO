using System.IO;
namespace Aula10;

class Program
{
    static void Main(string[] args)
    {
        
        if(Directory.Exists("Teste") == true)   // Verficando a existencia do diretorio
        {
           
            Console.WriteLine("Ops , essa pasta já existe");
            Console.WriteLine("Deseja excluir essa pasta ? sim|nao"); // Opãoo de exclusão da pasta 
            string escolha =Console.ReadLine();
            switch(escolha)
            {
                
                case "sim" : 
                Console.WriteLine("Excluindo...");
                Directory.Delete("Teste"); // Deletando diretorio
                break;

                case "nao" :
                Console.WriteLine("Ok, pasta mantida");
                break;

                default :
                Console.WriteLine("Opção não reconhecida");
                break;
            }
        }
        else
        {
            Directory.CreateDirectory("Teste"); // Criando um diretorio
            Console.WriteLine("Criando uma nova pasta...");
        }
    }
}
