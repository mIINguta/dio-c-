using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor){
            if(saldo >= valor){
                saldo -=valor;
                 Console.WriteLine("Saque feito com sucesso! O valor que você possui na conta agora, é: " +saldo);
            }
            else{
                Console.WriteLine("Impossivel realizar o sauqe. O valor é maior que o saldo!");
            }
        }

         public void ExibirSaldo(){
            Console.WriteLine("Seu saldo atual é: "+ saldo);
           }
    }
}