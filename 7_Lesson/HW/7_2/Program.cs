// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] fillArray()
{
    Console.Write("Enter number of rows: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void findPositionOfElement(int[,] array)
{
    Console.WriteLine("Enter 1st coordinate of position: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter 2nd coordinate of position: ");
    int b = int.Parse(Console.ReadLine());
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a - 1 == i && b - 1 == j)
            {
                result = array[i, j];
                Console.WriteLine($"Element on input position is {result}");
                return;
            }
        }
    }
    Console.WriteLine("There is no element on that position");
}

int[,] array = fillArray();
findPositionOfElement(array);
printArray(array);