using ExemploPoo.Models;



Pessoa p1 = new Pessoa("Gustavo", 23);

p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(33556, 12.000M);

c1.Sacar(13.000M);
c1.ExibirSaldo();