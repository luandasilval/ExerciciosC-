//Luanda da Silva Leite

//* Exercico 1
// Console.WriteLine("Digite o seu Nome: ");
// string? nome = Console.ReadLine();

// Console.WriteLine("Digite a sua Idade: ");
// string? idade = Console.ReadLine();

// Console.WriteLine("Digite a sua Cidade ");
// string? cidade = Console.ReadLine();

// Console.WriteLine($"Nome: {nome}, Idade: {idade}, Cidade: {cidade}");


//*Exercicio 2
// Console.WriteLine("Nome do produto comprado: ");
// string? NomeProduto = Console.ReadLine();

// Console.WriteLine("Quantidade comprada do produto: ");
// int QuantidadeComprada = int.Parse(Console.ReadLine())!;

// Console.WriteLine("Valor unitário: ");
// decimal PrecoUnitario = decimal.Parse(Console.ReadLine()!);

// decimal ValorTotal = QuantidadeComprada * PrecoUnitario;

// Console.WriteLine($"Nome do produto: {NomeProduto}, Quantidade Comprada: {QuantidadeComprada}, Valor unitário: R${PrecoUnitario}, Valor total: R${ValorTotal}");

//*Exercicio 3
// Console.WriteLine("Digite o nome do aluno: ");
// string? nomeAluno = Console.ReadLine();

// Console.WriteLine("Digite a nota do aluno: ");
// int NotaAluno = int.Parse(Console.ReadLine()!);

// if (NotaAluno >= 7 && NotaAluno <= 10)
// {
//     Console.WriteLine("Aluno Aprovado!");
// }
// else if (NotaAluno == 5 && NotaAluno < 7)
// {
//     Console.WriteLine("Aluno de recuperação");
// }
// else if (NotaAluno >= 0 && NotaAluno < 5)
// {
//     Console.WriteLine("Aluno Reprovado");
// }
// else
// {
//     Console.WriteLine("Opção inválida");
// }

// *Exercicio 4
// Console.WriteLine("Digite um número de 1 a 10: ");
// int numero = int.Parse(Console.ReadLine()!);

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

//*Exercicio 5
// int secreto = 56;

// Console.Write("Tente acertar o número secreto: ");
// int palpite = int.Parse(Console.ReadLine()!);

// int tentativa = 1;

// while (secreto != palpite)
// {
//     if (secreto > palpite && palpite > 0)
//     {
//         Console.WriteLine("O número secreto é maior.\n");
//     }
//     else if (secreto < palpite && palpite > 0)
//     {
//         Console.WriteLine("O número secreto é menor.\n");
//     }
//     else
//     {
//         Console.WriteLine("Número inválido");
//     }
//     Console.Write("Tente acertar o número secreto: ");
//     palpite = int.Parse(Console.ReadLine()!);
//     tentativa++;
// }

// Console.WriteLine($"Você acertou, o número secreto era {palpite} \n Número de tentativas: {tentativa}");

//*Exercicio 6
Console.WriteLine("Digite um número: ");
int Num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite outro número: ");
int Num2 = int.Parse(Console.ReadLine()!);

int Somar()
{
    int soma = Num1 + Num2;
    return soma;
}

int Multiplicar()
{
    int mult = Num1 * Num2;
    return mult;
}

Console.WriteLine($"A soma dos dois numeros é {Somar()} \nE a multiplicação é {Multiplicar()}");



