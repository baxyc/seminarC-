void Checking (int N)
{
    if (N % 7 == 0 && N % 23 == 0)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");
}
Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

Checking(n);