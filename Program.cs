using exemploExplorando.Models;
//configurar localização do código
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");


decimal valorMonetario = 82.99M;
// Interpolação para formatar como moeda (ele pegou a localização do sistema, no caso BRASIL)
// Console.WriteLine($"{valorMonetario:C}");
//outra forma de mudar a cultura de uma string, mesmo com o código setado para US
Console.WriteLine(valorMonetario.ToString("C1", CultureInfo.CreateSpecificCulture("pt-BR")));
// c1 representa uma casa decimal, podemos aumentar ou diminuir, podemos trocar tbm por N
Console.WriteLine(valorMonetario.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));


double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P1"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));















// ele vai resultador 1020, porque as variáveis tem tipos diferentes
//tipo string sempre vai ser preferencia quando estivermos concatenando
// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);










// // usando o construtor para enviar valores
// Pessoa pessoa1 = new Pessoa(nome: "Gustavo", sobrenome: "Minguta", 23);
// //podemos usar de outra forma para ajudar a quem está lendo o código
// Pessoa pessoa2 = new Pessoa(nome: "Raiane", sobrenome: "Mateus", 28);


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.ListarAlunos();






// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Gustavo";
// pessoa.Sobrenome = "Minguta";   
// pessoa.Idade = 23;





// pessoa.Apresentar();