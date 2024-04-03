using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace exemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime dataVenda){
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }
        // qnd seu Json tem uma chave que fere a convenção do C#, devemos usando essa linha abaixo, para converter como atributo 
        //ligando Nome_Produto à Produto.
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}