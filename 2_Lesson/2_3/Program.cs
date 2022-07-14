void Method1 (int a, int b)
{
    if (a%b == 0)
        Console.WriteLine ("Кратно");
    else
    {
        Console.WriteLine ($"Не кратно {a%b}");
    }
}
Method1 (34,5);
// Method1 (16,4)
