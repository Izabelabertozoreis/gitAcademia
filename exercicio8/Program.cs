// See https://aka.ms/new-console-template for more information
/* Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
 */

Console.WriteLine("Exercicio 8: Ler uma temperatura em graus Celsius/n" +
    " e apresentá-la convertida em graus Fahrenheit.");

float temperatura;
float temperatura_f;


Console.WriteLine("Digite quantos graus esta fazendo hoje: ");
temperatura = float.Parse(Console.ReadLine());

temperatura_f = (9 * temperatura + 160) / 5;

Console.WriteLine("A temperatura convertida para Fahrenheit é: " + temperatura_f);





