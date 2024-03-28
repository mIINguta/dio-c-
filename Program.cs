using System.ComponentModel;
using System.Globalization;
using exemploExplorando.Models;

string dataString = "2024-00-20 18:00";

//tryparseExact para tratar exceções de alguma data inválida ser inserida
bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
//a saída será zerada, caso a data e hora seja inválida

if(sucesso){
    Console.WriteLine("Conversão com sucesso! Data: " + data);
}
else{
    Console.WriteLine($"{dataString} não é uma data válida!");
}
Console.WriteLine(data);














// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// //MM - mes  mm - minutos  HH - horas em PM hh - em AM
// Console.WriteLine(data.ToString("dd/MM/yy - HH:mm "));


// //exibindo somente a data
// Console.WriteLine(data.ToShortDateString());

// //exibindo somente a hora
// Console.WriteLine(data.ToShortTimeString());






















// decimal valorMonetario = 82.99M;
// // Interpolação para formatar como moeda (ele pegou a localização do sistema, no caso BRASIL)
// // Console.WriteLine($"{valorMonetario:C}");
// //outra forma de mudar a cultura de uma string, mesmo com o código setado para US
// Console.WriteLine(valorMonetario.ToString("C1", CultureInfo.CreateSpecificCulture("pt-BR")));
// // c1 representa uma casa decimal, podemos aumentar ou diminuir, podemos trocar tbm por N
// Console.WriteLine(valorMonetario.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));


// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P1"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));















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