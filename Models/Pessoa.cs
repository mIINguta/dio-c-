using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Pessoa
    {
        //construtor
        public Pessoa(){
            
        }
        public Pessoa(string nome, string sobrenome){

        }
        private string _nome;
        private string _idade;
        private string _sobrenome;
        //nomeCompleto somente leitura;
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public string Sobrenome { 
            get => _sobrenome.ToUpper();

            set{
                if(value == ""){
                    throw new ArgumentException("Sobrenome não pode ser vazio!");
                }
                _sobrenome = value;
            }
        
        }
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
            Console.WriteLine($"Nome: {NomeCompleto} \n Idade: {Idade}");
        }
    }
}