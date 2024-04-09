using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        //virtual deixa a classe filha sobrescrever o método
        public virtual void Apresentar(){
            Console.Write($"Olá meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}