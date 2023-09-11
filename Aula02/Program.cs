using System.IO;
namespace Aula02;

class Program
{
    static void Main(string[] args)
    {
        string[] linhas = {"Primeiro componente " ,  "Segundo Componente"};

      
        File.WriteAllLines("arquivo1.txt" , linhas);  // Passo o nome do arquivo e o que ira ser add // All lines pq estou usando um array
           
                                                    
        string[] linhasArqv1 = File.ReadAllLines("arquivo1.txt");  // O processo inverso , le o meu array de string presente do arquivo , linha a linha
        foreach(var linha in linhas)  //Percorrer o array e imprimir na tela
        {
            Console.WriteLine(linha);
        }




    }                                                
    
}
