Console.WriteLine("## Saida de dados : Formatação ##\n");

int idade = 20;
string nome = "Paulo";

//Escrever na mesma linha
Console.WriteLine(nome);
Console.WriteLine("tem ");
Console.WriteLine(idade);
Console.WriteLine("nos \n");

//Concatenação : usando operador de +
Console.WriteLine("=== Usando Concatenação ===");
Console.WriteLine(nome + " tem " + idade + " anos\n");

//Interpolação de string : $ -> a interpolação {}
Console.WriteLine("=== Concatenação de string ===");
Console.WriteLine($"{nome} tem {idade} anos");







Console.ReadLine();

