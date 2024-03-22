using System.Dynamic;
using ExemplosFundamentos.Models;


int inteiro = 5;
// para string não tem convert nem parse.
string a = inteiro.ToString();

Console.WriteLine(a);






// Cast - Casting (conversão de tipo de variável)
// int a = Convert.ToInt32("5");

// Parse tbm faz o mesmo processo

// a diferença de Convert e PArse é o tratamento de valores null
// int parse = int.Parse(null); // erro, não aceita o nulo

// int convert = Convert.ToInt32(null); // aqui converte para 0;

// Console.WriteLine("Convert: " + convert);


// Console.WriteLine("Parse: "+ parse);


// int a = 10;
// int b = 20;

// int c = a + b; 


// c = c + 5;

// // ou
// // c += 5; (35)
// // c -= 5; (25)



// Console.WriteLine($"A soma de A + B é = {c}");


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// string apresentacao = "Olá, seja bem vindo!";
// int quantidade = 1;
// Console.WriteLine("O primeiro valor é: " + quantidade);

// quantidade = 10;
// Console.WriteLine("O primeiro valor é: " + quantidade);

// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine("Valor da variável: " + apresentacao);
// Console.WriteLine("Valor da variável: " + quantidade);
// Console.WriteLine("Valor da variável: " + altura.ToString("0.00")); // tratamento manual para aumentar as casas decimais
// Console.WriteLine("Valor da variável: " + preco);
// Console.WriteLine("Valor da variável: " + condicao);

Pessoa p = new Pessoa();

p.Nome = "Gustavo Minguta";
p.Idade = 23;


//p.Apresentar();