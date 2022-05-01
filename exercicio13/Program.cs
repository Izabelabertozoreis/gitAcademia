// See https://aka.ms/new-console-template for more information
/*Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado
*/


Console.WriteLine("Exercicio 13");

double salario;
double comissao;
double custo;
double venda;
double venda1;
double salariofinal;

Console.WriteLine(" Qual o Salario minimo? ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine(" Qual o custo? ");
custo = double.Parse(Console.ReadLine());

Console.WriteLine("Quantas vendas foram realizadas? ");
venda = double.Parse(Console.ReadLine());

comissao= custo * 0.15;

venda1 = comissao * venda;

salariofinal = salario * 2 + venda1;

Console.WriteLine("O salario final é " + salariofinal);



