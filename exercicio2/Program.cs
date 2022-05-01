// See https://aka.ms/new-console-template for more information
/* Escreva um programa em C# e no Visual Studio para calcular uma 
 * média aritmética entre quatro números quaisquer.
 */


Console.WriteLine("Exercico 2: Escreva um programa em C# e no Visual Studio/n" +
    " para calcular uma média aritmética entre quatro números quaisquer.");

float numero1;
float numero2;
float numero3;
float numero4;
float media_aritimetica;

Console.WriteLine("Informe o 1ª numero: ");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o 1ª numero: ");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o 1ª numero: ");
numero3 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o 1ª numero: ");
numero4 = float.Parse(Console.ReadLine());

media_aritimetica = (numero1 + numero2 + numero3 + numero4) / 4;

Console.WriteLine(" A média dos 4 valores é: " + media_aritimetica);








