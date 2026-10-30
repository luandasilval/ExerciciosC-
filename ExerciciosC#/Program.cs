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
Console.WriteLine("Nome do produto comprado: ");
string? NomeProduto = Console.ReadLine();

Console.WriteLine("Quantidade comprada do produto: ");
int QuantidadeComprada = int.Parse(Console.ReadLine())!;

Console.WriteLine("Valor unitário: ");
decimal PrecoUnitario = decimal.Parse(Console.ReadLine()!);

decimal ValorTotal = QuantidadeComprada * PrecoUnitario;

Console.WriteLine($"Nome do produto: {NomeProduto}, Quantidade Comprada: {QuantidadeComprada}, Valor unitário: R${PrecoUnitario}, Valor total: R${ValorTotal}");