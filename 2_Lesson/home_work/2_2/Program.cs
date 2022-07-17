int Delete(int num)
{
    int A = num / 100;
    int B = num % 10;
    return A * 10 + B;
}
int a = new Random().Next(100,1000);
Console.WriteLine(a);

Console.WriteLine(Delete(a));
