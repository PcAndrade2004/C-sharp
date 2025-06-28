Console.WriteLine("## Struct DateTime ##\n");

Console.WriteLine("Obtendo Data Atual");
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

Console.WriteLine("\nData Especifica");
DateTime dataEspecifica = new DateTime(2025, 06, 25);
Console.WriteLine(dataEspecifica);

Console.WriteLine("\nDefinindo Date e Hora");
DateTime dataEHora = new DateTime(2025, 06, 25, 19, 00, 00);
Console.WriteLine(dataEHora);

//Extraindo informações 
Console.WriteLine("\n===Extraindo informações===");
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Microsecond);

//adicionando valores 
Console.WriteLine("\n===Adicionando valores===");
Console.WriteLine(dataAtual.AddDays(2));
Console.WriteLine(dataAtual.AddHours(1));
Console.WriteLine(dataAtual.AddMonths(2));
Console.WriteLine(dataAtual.AddYears(2));


//Obtendo o dia da Semana e o Ano 
Console.WriteLine("\n===Obtendo o dia da Semana e o Ano===");
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

//Obtendo Data no formato longo e abreviado
Console.WriteLine("\n===Obtendo Data no formato longo e abreviado===");
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

//Obtendo Hora no formato longo e abreviado
Console.WriteLine("\n===Obtendo Hora no formato longo e abreviado===");
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());


Console.ReadKey();