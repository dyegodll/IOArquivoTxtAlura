

using System;
using System.Text;
using System.Text.Unicode;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "texto.txt";

        using (var fs = new FileStream(enderecoArquivo, FileMode.Open))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8)) //Habilita leitura de caracteres especiais
        {
            var encoding = UTF8Encoding.UTF8;

            //Acessa conteúdo do arquivo
            var leitor = new StreamReader(fs);

            var linha = leitor.ReadLine(); // Lê a primeira linha do arquivo
            
            var texto = leitor.ReadToEnd(); // Lê arquivo todo
            Console.WriteLine(texto);
        }

    }
}