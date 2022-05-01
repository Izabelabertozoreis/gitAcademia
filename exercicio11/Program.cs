// See https://aka.ms/new-console-template for more information

/*
 * Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
representa em relação ao total de eleitores.
*/


Console.WriteLine("Exercicio 11");

float eleitores;
float votosb;
float votosn;
float votosv;
float votosn1;
float votosv1;
float votosb1;

Console.WriteLine("Digite o numero de eleitores no municipio ");
eleitores = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de votos em branco ");
votosb = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de votos nulos ");
votosn = float.Parse(Console.ReadLine());

votosv = eleitores - votosb - votosn;

Console.WriteLine("A quantidade de votos validos é " + votosv);

votosn1 = 100 * (votosn / eleitores);
votosv1 = 100 * (votosv / eleitores);
votosb1 = 100 * (votosb / eleitores);

Console.WriteLine("A % de votos Nulos é " + votosn1+"%");
Console.WriteLine("A % de votos Brancos é " + votosb1+"%");
Console.WriteLine("A % de votos Validos é " + votosv1+"%");



