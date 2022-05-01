// See https://aka.ms/new-console-template for more information

/* calcular o consumo médio de um automóvel
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível
 * consumo para percorrê-la (medido em l).
 */


Console.WriteLine("Exercicio 5");

float distancia;
float consumo;
float volume;

Console.WriteLine("Qual a distancia percorrida: ");
distancia = float.Parse (Console.ReadLine());

Console.WriteLine("Qual o volume de combustivel usado: ");
volume = float.Parse (Console.ReadLine());

consumo = distancia / volume;

Console.WriteLine("o consumo medio é  km/l" + consumo);


