using exemploExplorando.Models;



Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Gustavo";
pessoa1.Sobrenome = "Minguta";

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Raiane";
pessoa2.Sobrenome = "Mateus";

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();


















// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Gustavo";
// pessoa.Sobrenome = "Minguta";   
// pessoa.Idade = 23;





// pessoa.Apresentar();