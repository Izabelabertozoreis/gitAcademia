// See https://aka.ms/new-console-template for more information
/*
 * Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
*/

Console.WriteLine("Exercicio 12 ");

double quilometragem;
double odometro1;
double odometro2;
double litros;
double gastod;
double recebidodia;
double consumo;
double lucrodia;
double consumo1;



Console.WriteLine("Digite a quilometrage inicial ");
odometro1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor total recebidos pelos passageiros do dia ");
recebidodia = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de litros gasto no dia ");
litros = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final ");
odometro2 = double.Parse(Console.ReadLine());

quilometragem = odometro1 - odometro2;

consumo = quilometragem / litros * (-1);

consumo1 = litros * 6.90;

lucrodia = recebidodia - consumo1;

Console.WriteLine(" A media de consumo é " + consumo + "km/l"+ " O lucro dia foi R$" + lucrodia);








