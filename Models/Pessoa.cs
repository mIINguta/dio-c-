using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _idade;
        public string Nome { 
            get => _nome.ToUpper();        
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
               }
        }
        public int Idade { 
            get => Convert.ToInt32(_idade);
            set{
                if(value < 0){
                    throw new ArgumentNullException("A idade não pode ser menor que 0!");
                }
                _idade = value.ToString();
            }
        
        }


        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome} \n Idade: {Idade}");
        }
    }
}