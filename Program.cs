String frase, fraseCebola;

Console.Write("Digite uma flase: ");
frase = Console.ReadLine()!;

fraseCebola = frase
.Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(fraseCebola);
