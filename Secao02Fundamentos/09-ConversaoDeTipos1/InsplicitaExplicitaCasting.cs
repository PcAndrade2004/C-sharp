Console.WriteLine("## Conversão de Tipos ##\n");

// Conversão Implícita
// Podemos fazer essa conversão porque os dois tipos são compatíveis.
// int ocupa 4 bytes e double ocupa 8 bytes.
// Ou seja, é possível converter de int para double sem perda de dados.
int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble);

Console.WriteLine("\nConversão Explícita");
//double usa 8 bits enquanto Int usa 4 bits com isso não conseguimos converter.
//Para convertermos devemos fazer o uso do Casting
//adicionando dentro do ( ) o tipo de dado para o que queremos que seja convertido.
double varDoublee = 12.456;
int varIntt = (int)varDoublee;
Console.WriteLine(varIntt);



Console.ReadLine();



