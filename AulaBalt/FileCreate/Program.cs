using System.IO;
namespace FileCreate;

class Program
{
    static void Main(string[] args)
    {
        const string filePath = @"C:\Users\55639\Área de Trabalho\Balt.Io\meuarquivo.txt";
            // Add texto
      // using var file = File.AppendText(filePath);
     //  file.WriteLine("Teste"); // Add um texto 
     //  file.Close();


            //Add texto
      // using var file = File.CreateText(filePath);
      // file.WriteLine("Texte 2 ") ; // Substitui o arqv
      // file.Close();

            //Copiar
      //File.Copy(filePath , @"C:\Users\55639\Área de Trabalho\Balt.Io\outro.txt" ,true);


            //Mover
       // File.Move(filePath , @"C:\Users\55639\Área de Trabalho\Balt.Io\novo.txt");

           //Substituir
           //File.Replace(@"C:\Users\55639\Área de Trabalho\Balt.Io\outro.txt" , filePath, @"C:\Users\55639\Área de Trabalho\Balt.Io\backup.txt");

           //Deletar
           //File.Delete(@"C:\Users\55639\Área de Trabalho\Balt.Io\backup.txt");

           //Verificar Existencia
         //  var existencia = File.Exists(filePath);   //Retorna um bool
         //System.Console.WriteLine(existencia);

          // Verificar ultimo acesso
          var time = File.GetLastAccessTime(filePath);
          System.Console.WriteLine(time);
    }
}
