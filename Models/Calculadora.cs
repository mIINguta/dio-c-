using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y){
            decimal resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
        }

        public void Potencia(int x, int y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}° {y} = {pot}");

        }
    }
}