bool movendo;
bool deveria;
string resposta;

Console.Clear();

Console.WriteLine("*--- Fluxograma da Engenharia ---*");
Console.WriteLine("O objeto está se movendo (Digite 's' para sim ou 'n' para não)?");
movendo = Console.ReadLine()! == "s"; 
Console.WriteLine("Deveria (Digite 's' para sim ou 'n' para não)?");
deveria = Console.ReadLine()! == "s";

if (!movendo)
{
    if (!deveria)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        resposta = "Ótimo!";
        Console.WriteLine(resposta);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        resposta = "Use WD-40!";
        Console.WriteLine(resposta);
        Console.ResetColor();
    }
}
else
{
    if (!deveria)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        resposta = "Use Silver Tape!";
        Console.WriteLine(resposta);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        resposta = "Ótimo!";
        Console.WriteLine(resposta);
        Console.ResetColor();
    }
}