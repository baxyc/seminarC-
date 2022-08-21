// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            array[i, j] = new Random().Next(1, 50);
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

int[,] minMaxArr(int[,] array)
{
    for (int i = array.GetLength(0) - 1; i > 0; i--)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[k, j] > array[k, j + 1])
                {
                    int tmp = array[k, j];
                    array[k, j] = array[k, j + 1];
                    array[k, j + 1] = tmp;
                }
            }
        }
    }
    return array;
}

int[,] array = fillArray();
printArray(array);
Console.WriteLine();
printArray(minMaxArr(array));