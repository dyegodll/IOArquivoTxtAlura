

using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "Metodo_Dispose_em_Using.txt";

        using (var fs = new FileStream(enderecoArquivo, FileMode.Open)) 
        {
            //Acessa conteúdo do arquivo
            var leitor = new StreamReader(fs);

            var linha = leitor.ReadLine(); // Lê a primeira linha do arquivo
            
            var texto = leitor.ReadToEnd(); // Lê arquivo todo

            Console.WriteLine(texto);
        }

    }
}