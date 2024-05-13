using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dioAvanade.Models
{
    public class LeituraArquivo 
    {
        // tupla com o metodo LerAquivo()
        // tupla contem 03 tipagem sendo booleano, string e int
        public(bool Sucesso, string [] linhas, int quantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return(true, linhas, linhas.Count());

            }
            catch(Exception)
            {
                return (false, new string[0], 0) ;
            }
        }
    }
}