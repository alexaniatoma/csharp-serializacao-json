using dioAvanade.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var(Sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");
if(Sucesso)
{
    Console.WriteLine("O arquivo contém: " + quantidadeLinhas + " linhas");

    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
    else
    {
        Console.WriteLine("Não foi possiviel ler o arquivo");
    }




