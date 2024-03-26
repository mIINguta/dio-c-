using System.Dynamic;
using ExemploFundamentosCommon.Models;

int [] arrayInteiros = new int[3];

arrayInteiros[0] = 20;
arrayInteiros[1] = 40;
arrayInteiros[2] = 60;


//copiando array para outro

int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


foreach(int valor in arrayInteiros){
    Console.WriteLine(valor);
}

Console.WriteLine("-----------------");

foreach(int valorDup in arrayInteirosDobrado){
    Console.WriteLine(valorDup);
}



//aumentando array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);






//utilizando for each para percorrer array
// int contador = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição {contador} valor: {valor}");
//      contador++;
// }
// for(int contador = 0; contador < arrayInteiros.Length;contador++){
// Console.WriteLine($"Posição {contador} do Array: " + arrayInteiros[contador]);
// }
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Gustavo";
// pessoa1.Idade = 20;

// pessoa1.Apresentar();



// string opcao;
// bool exibirMenu = true;

// while(exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");


//     opcao = Console.ReadLine();
    
    
//     switch(opcao){
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar de cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
        
        
//         default:
//             Console.WriteLine("Essa opção não existe!");
//             break;
//         }

        


//     }

// Console.WriteLine("O programa se encerrou!");







// int i, soma = 0;
// do{
//     Console.WriteLine("Digite um número: - (0) para parar ");
//     i = Convert.ToInt32(Console.ReadLine());
//     soma += i;
// }
// while(i != 0 );
//     Console.WriteLine($"O resultado é: {soma}");
















// int i = 0;

// while(i <= 20){
//     Console.WriteLine($"{i}");
//     i++;
// }







// int numero = 5;
// for(int contador = 0; contador <= 10; contador++){
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");

// }















// Calculadora calc = new Calculadora();

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
// calc.RaizQuadrada(7);
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