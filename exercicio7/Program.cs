// See https://aka.ms/new-console-template for more information

Console.WriteLine("Exercicio 7");

string Nvendedor;
double salario;
double venda;
double comissao;
double salariofinal;

Console.WriteLine("Escreva o numero do vendedor ");
Nvendedor = Console.ReadLine();

Console.WriteLine("Qual o total de vendas efetuados ");
venda = double.Parse(Console.ReadLine());

comissao = venda * 0.25 ;

salario = 1000;

salariofinal = salario + comissao;

Console.WriteLine("O salario final do vendedor " + Nvendedor + " é " + salariofinal);

