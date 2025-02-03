using System.Text;
using System.Text.Unicode;

// C:/Users/dyego.lima/source/repos/IOArquivoTxtAlura/IOArquivoTxtAlura/bin/Debug/net8.0/
string caminhoArquivo = "texto.txt"; //quando ele está na pasta do projeto, não é necessário declarar o caminho completo do arquivo

//abre o arquivo pra leitura
using (var fs = new FileStream(caminhoArquivo, FileMode.Open))//indica ao using a variável que ele tem que gerenciar e para chamar o Dispose() para remover da memória e liberar recurso
{

    var buffer = new byte[1024]; //1Kb / array de bytes pra salvar os dados do arquivo lido através do método FileStream.Read()

    int bytesLidos = -1; //armazena somente os bytes lidos(com conteúdo) do arquivo, para ignorar os '0' gerados nos bytes sem conteúdos

    while (bytesLidos != 0) //recebe o tamanho do arquivo lido, e continua lendo enquanto o byte for maior que '0', ou seja houver conteúdo.
    {
        bytesLidos = fs.Read(buffer, 0, buffer.Length);
        EscreverBuffer(buffer, bytesLidos);
    }

}//o using gerencia o fechamento da conexão com o arquivo( como o fs.Close() ), para habilitar o acesso a novas modificações
// Dispose() é chamado automaticamente no final

//escreve bytes lidos do arquivo no console
static void EscreverBuffer(byte[] buffer, int bytesLidos)
{
    var utf8 = new UTF8Encoding(); //formata o texto para aceitar caracteres especiais
    var texto = utf8.GetString(buffer, 0, bytesLidos); // Apenas os bytes lidos
    Console.Write(texto);
}