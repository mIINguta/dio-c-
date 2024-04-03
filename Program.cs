using System.ComponentModel;
using System.Globalization;
using exemploExplorando.Models;



Pessoa p1 = new Pessoa("Gustavo", "Minguta", 23);

// desconstrutor
(string nome, string sobrenome, int idade) = p1;

Console.WriteLine($"{nome} {sobrenome}");
Console.WriteLine("-------------");
p1.Apresentar();

















// LeituraArquivo arquivo = new LeituraArquivo();

// // para aplicar o descarte de variável usamos " _ " no lugar da váriavel, segue o exemplo;
// // não queremos quantidade de linha
// var(sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso){
//     Console.WriteLine("Funcionou!!");
//     foreach(string linha in linhasArquivo){
//         Console.WriteLine(linha);
//     }    
// }else{
//     Console.WriteLine("Não foi possível ler o arquivo");
// }




















// (int, string, string, decimal) tupla  = (1, "Gustavo", "Minguta", 1.75M);
// // outras formas de criar tuplas
// ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Neymá", "Juniu", 1.75M);

// var outroExemploTuplaCreate = Tuple.Create(2, "Neymá", "Juniu", 1.75M);

// //acima, maneiras para criar tuplas

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}m");

















// Dictionary<string,string> estados = new Dictionary<string, string>();

// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");


// estados.Add("RJJ", "Rio");

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------");

// estados.Remove("RJJ"); // removendo valor

// estados["SP"] = "São Paulo (Alterado)"; // alterando valor, sempre pela chave 

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("-----------");
// string chave = "BA";
// Console.WriteLine($"Consultando valor: {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"Valor existente:{estados[chave]}");
// }
// else{
//     Console.Write($"Valor não encontrado. A chave: {chave} pode ser inserida!");
// }

// Stack<int> pilha = new Stack<int>();
// // lifo - last in first out, fazendo a pilha ficar de cabeça para baixo

// pilha.Push(3);
// pilha.Push(6);
// pilha.Push(9);
// pilha.Push(12);

// foreach(int p in pilha){
//     Console.WriteLine(p);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);


// foreach(int p in pilha){
//     Console.WriteLine(p);
// }















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach(int f in fila){
//     Console.WriteLine(f);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove sempre o primeiro da fila
// fila.Enqueue(10);

// foreach(int f in fila){
//     Console.WriteLine(f);
// }





















// new ExemploExcecao().Metodo1();
// como fizemos uma cascata de métodos, a exceção no metodo 4
//vai sendo jogada para cima, até acharem um bloco catch.
// como não tem o bloco catch em nenhum método, o programa se encerra.


















// try{

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas){
//         Console.WriteLine(linha);
// }
// }
// catch(FileNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho do arquivo não encontrado. {ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exeção genérica! {ex.Message}" );
// }
// finally{
//     //sempre irá rodar, independente se o programa falhar ou nãogit
//     Console.WriteLine("Chegou até aqui!");
// }

















// string dataString = "2024-00-20 18:00";

// //tryparseExact para tratar exceções de alguma data inválida ser inserida
// bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// //a saída será zerada, caso a data e hora seja inválida

// if(sucesso){
//     Console.WriteLine("Conversão com sucesso! Data: " + data);
// }
// else{
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }
// Console.WriteLine(data);














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