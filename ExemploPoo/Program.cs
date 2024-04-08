using ExemploPoo.Models;



Aluno a1 = new Aluno();
a1.Nome = "Gustavo";
a1.Idade = 23;
a1.Email = "gustavo.minguta@gmail.com";
a1.Nota = 10;

Professor p1 = new Professor();
p1.Nome = "Chico Moedas";
p1.Idade = 27;
p1.Email = "eutentei.loirinha@gmail.com";
p1.Salario = 10.000M;


a1.Apresentar();
p1.Apresentar();