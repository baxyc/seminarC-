// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int DigitSum(int num)
{
    int Sum = 0;
    for(int i = 1; num > 0; i++)
    {
    Sum += num % 10;
    num /= 10;
    }
return Sum;
}
Console.WriteLine(DigitSum(452));