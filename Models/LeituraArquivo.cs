using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class LeituraArquivo
    {
        //um médoto retorna apenas um tipo, porém usando tuplas, mudamos isso, como no ex abaixo.
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho){
            try {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count()); // caso tenha sucesso  
            
            }catch (Exception ex){
                return (false, new string[0], 0); // caso ocorra uma exceção
            }
        }
    }
}