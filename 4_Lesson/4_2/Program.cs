// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int Method(int num)
{
    int AllSum = 1;
    for (int i = 1; i <= num; i++)
        AllSum = AllSum * i;
    return AllSum;
}
Console.WriteLine(Method(4));