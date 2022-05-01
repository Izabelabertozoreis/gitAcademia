// See https://aka.ms/new-console-template for more information

/* Escreva uma seqüência de atribuições, em forma de programa em C# e no Visual Studio,
 * para trocar entresi os valores de duas variáveis ​​A e B.
 * 

 */

Console.WriteLine("Exercicio 3: Escreva uma seqüência de atribuições, em forma de programa em C# e no Visual Studio,/n" +
    " para trocar entre si os valores de duas variáveis ​​A e B.");

Console.WriteLine("Digite um frase qualquer ");
string varialvel1 = Console.ReadLine();

Console.WriteLine("Digite um frase qualquer ");
string varialvel2 = Console.ReadLine();

Console.WriteLine("o conteudo da variavel1 é: " + varialvel1);
Console.WriteLine("o conteudo da variavel2 é: " + varialvel2);

Console.WriteLine(" Processo de troca de valores entre duas variaveis");


string tmp = varialvel1;
varialvel1 = varialvel2;
varialvel2 = tmp;

Console.WriteLine("o conteudo da variavel1 é: " + varialvel1);
Console.WriteLine("o conteudo da variavel2 é: " + varialvel2);






