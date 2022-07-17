void Num(int v)
{
    if (v < 0)
    {
        v = -v;
    }

    if (v < 100)
    {
        Console.WriteLine("There is no third digit");
        return;
    }
    while (v > 1000)
    {
        v = v / 10;    
    }
    Console.WriteLine(v % 10);

}
Console.Write("Write a number N: ");
int v = int.Parse(Console.ReadLine());

Num(v);