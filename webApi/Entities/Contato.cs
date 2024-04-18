using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Entities
{
    public class Contato
    {
        public Contato(int id, string nome, string telefone, bool ativo){
            Id = id;
            Nome = nome; 
            Telefone = telefone;
            Ativo = ativo;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}