Console.Write("Enter the number indicating the day of the week: ");
int c = int.Parse(Console.ReadLine());
if (c < 1 || c > 7)
{
    Console.WriteLine("error");
}
else
{
    if (c < 6)
    {
        Console.WriteLine("Weekday");
    }
    else
    {
        Console.WriteLine("Weekend");
    }
}