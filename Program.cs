using System.Dynamic;
using ExemplosFundamentos.Models;

Calculadora calc = new Calculadora();

// Console.WriteLine("Digite o primeiro número: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite o segundo número: ");
// int y = Convert.ToInt32(Console.ReadLine());

// calc.Somar(x,y);
// calc.Subtrair(x,y);
// calc.Multiplicar(x,y);
// calc.Dividir(x,y);
// calc.Potencia(x,y);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);


calc.RaizQuadrada(7);



// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 10;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 10");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);



















// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();


// switch(letra){

//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.Write("É uma vogal!");
//     break;

//     default:
//     Console.WriteLine("Não é uma vogal!");
//     break;


// }














// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 1;

// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// if (possivelVenda && quantidadeCompra > 0)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else if(quantidadeCompra <= 0 )
// {
//     Console.WriteLine("Você não comprou nada!");
// }
// else
// Console.WriteLine("Desculpe, não temos a quantidade desejada no estoque");



// string a = "15";
// int b = Convert.ToInt32(a);

// Console.Write("Imprimindo: "+ b);

//podemos usar uma forma mais segura, que é o tryParse

// string a = "15c";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine("Resultado de B: " + b);  

// neste exemplo, colocamos 15c, para dar erro na hora de converter para o Int, então
// automaticamente o resultado de B será 0;



// C# faz as operações respeitando as ordens naturais
// double a = 4 / 2 + 2;

// Console.WriteLine("Resultado: " + a);
// // se quisermos dar prioridades para resolução antes, colocamos () para resolver primeiro

// double b = 4 / (2 + 2);

// Console.WriteLine("Resultado 2: " + b);










// int a = 5;
// double b = a;
//cast implicito = quando não conseguimos ver, mas a linguagem faz por nós.
// um inteiro cabe no double.

// int a = 5;
// long b = a;

//long suporta int também.


// long a = 5;
// int b = a;

// aqui não consegue, pois o int não suport ao tipo long
// Console.WriteLine(b);









// int inteiro = 5;
// // para string não tem convert nem parse.
// string a = inteiro.ToString();

// Console.WriteLine(a);






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