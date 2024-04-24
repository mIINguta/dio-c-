using Calculadora.Services;


CalculadoraImplementacao calculadora = new CalculadoraImplementacao();


calculadora.Num1 = 1;
calculadora.Num2 = 3;

Console.WriteLine($"Numero {calculadora.Num1} + Número {calculadora.Num2} = {calculadora.Somar(calculadora.Num1, calculadora.Num2)}");