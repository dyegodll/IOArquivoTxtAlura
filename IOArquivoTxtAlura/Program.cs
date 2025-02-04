using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var enderecoArquivo = "texto.txt";

        //Acessa conteúdo do arquivo
        using (var fs = new FileStream(enderecoArquivo, FileMode.Open))
        using (StreamReader leitor = new StreamReader(fs, Encoding.UTF8)) //Habilita leitura de caracteres especiais
        {
            //var linha = leitor.ReadLine(); // Lê a primeira linha do arquivo

            var texto = leitor.ReadToEnd(); // Lê arquivo todo
            Console.WriteLine(texto);
        }

    }
}