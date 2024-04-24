using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    
    public int Somar (int num1, int num2){
        return num1 + num2;
    }
    
    }
}