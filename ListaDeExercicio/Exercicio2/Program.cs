int time1, time2;

Console.WriteLine("Quantos gols o Time 1 fez?");
time1 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos gols o Time 2 fez?");
time2 = int.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine("Time 1 venceu!");
}
else if (time2 > time1)
{
    Console.WriteLine("Time 2 venceu!");
}
else
{
    Console.WriteLine("Deu empate!");
}