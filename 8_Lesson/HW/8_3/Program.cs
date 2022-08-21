// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = new Random().Next(0, 50);
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

int[,] matrixMultiply(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            result[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return result;
}

Console.WriteLine("Input rows&columns of 1st array");
int[,] arr1 = fillArray();
Console.WriteLine("Input rows&columns of 2nd array");
int[,] arr2 = fillArray();
printArray(arr1);
Console.WriteLine();
printArray(arr2);
Console.WriteLine();
printArray(matrixMultiply(arr1, arr2));