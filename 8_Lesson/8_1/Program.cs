// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

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

int[,] changeRowsArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                temp = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
        }
    }
    return array;
}

int[,] array = fillArray();
printArray(array);
Console.WriteLine();
printArray(changeRowsArray(array));