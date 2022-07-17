Console.Write("Write number N: ");
int n = int.Parse(Console.ReadLine());
if (n > 999 ^ n < 100)
{
    Console.Write("error");
}
else 
{
    Console.WriteLine(n % 100 / 10);
}