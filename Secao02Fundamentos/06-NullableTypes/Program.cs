Console.WriteLine("## Nullable Types ##\n");
//Nullable Types => Tipos anulaveis

int? i = null; //null => valor indefinido ou ausente.
int b = i ?? 0;
//aqui estou aviando se (i) for igual a NULL ele será (0).
//Caso (a) sejá diferente de NULL ele atribui o valor de (a)
Console.WriteLine(b);

int? idade = null;
if (idade.HasValue) {
    Console.WriteLine(idade.Value + " anos");
} else {
    Console.WriteLine("Deu certo");
}
    Console.ReadKey();