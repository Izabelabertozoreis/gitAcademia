// See https://aka.ms/new-console-template for more information

//Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
// /n quebra a linha 


Console.WriteLine("Exercício 1!");

float numero1;
float numero2;
float media_aritimetica;

Console.Write(" Digite um Número qualquer: ");
numero1 = float.Parse ( Console.ReadLine() );

Console.Write(" Digite um segundo Número qualquer: ");
numero2 = float.Parse(Console.ReadLine());

media_aritimetica = (numero1 + numero2) / 2 ;

Console.WriteLine(" A média aritimética dos valores é de: " + media_aritimetica);







