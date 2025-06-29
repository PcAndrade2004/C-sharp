Console.WriteLine("## Saida de dados : Formatação ##\n");

int idade = 20;
string nome = "Paulo";

//Escrever na mesma linha
Console.WriteLine(nome);
Console.WriteLine("tem ");
Console.WriteLine(idade);
Console.WriteLine("nos \n");

//Concatenação : usando operador de +
Console.WriteLine("-----Usando Concatenação-----");
Console.WriteLine(nome + " tem " + idade + " anos\n");

//Interpolação de string : $ -> a interpolação {}
Console.WriteLine("-----Concatenação de string-----");
Console.WriteLine($"{nome} tem {idade} anos");

//usando place holder : usa {} com numéração com inicio em zero
Console.WriteLine("-----place holders-----");
Console.WriteLine("{0} tem {1} anos ", nome, idade);
//utilizam a numeracao começando com a chave e dentro o numero que comeca com 0 , apos a vigula colocamos o nome da variavel que queremos que comece.

Console.ReadLine();

