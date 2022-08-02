// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int NumExp(int num, int a)
{
    int Mult = 1;
    for(int i = 1; i <= a; i++)
        Mult *= num;
    return Mult;
}
Console.WriteLine(NumExp(3,5));