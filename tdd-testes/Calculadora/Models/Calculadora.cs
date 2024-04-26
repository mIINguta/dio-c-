using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {

        private List<string> _historico;

        public Calculadora() {
            _historico = new List<string>();
        }
        public int Somar(int num1, int num2){
            int resultado = num1 + num2;
            _historico.Insert(0, "Resultado: "+ resultado); // insere no começo da lista a operação qnd for chamada.
            
           return resultado;
        }
        public int Subtrair(int num1, int num2){
            int resultado = num1 - num2;
            _historico.Insert(0, "Resultado: " + resultado);
            
            return resultado;
        }
        public int Dividir(int num1, int num2){
            int resultado = num1 / num2;
            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int Multiplicar(int num1, int num2){
            int resultado = num1 * num2;
            _historico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public List<string> Historico(){

            _historico.RemoveRange(3, _historico.Count - 3); // aqui, eliminamos todos os valores da lista a partir do index 3, usando o tamanho da lista para saber quantos temos, o menos 3 é para o programa saber que tem 3 numeros iniciais que queremos.
             return _historico;
        }
    }
}