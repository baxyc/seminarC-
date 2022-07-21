void Searching (int a)
{
    int b = 1;
    while (b <= a)
    {
        Console.WriteLine(Math.Pow(b, 2));
        b = b + 1;
    }
}

Searching(5);