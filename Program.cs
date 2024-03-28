using exemploExplorando.Models;


// usando o construtor para enviar valores
Pessoa pessoa1 = new Pessoa(nome: "Gustavo", sobrenome: "Minguta", 23);
//podemos usar de outra forma para ajudar a quem está lendo o código
Pessoa pessoa2 = new Pessoa(nome: "Raiane", sobrenome: "Mateus", 28);


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