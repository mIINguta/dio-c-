using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public decimal saldoAtual { get; set; }
        
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é: {saldo}");
        }

    }
}