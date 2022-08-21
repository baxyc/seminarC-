//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void findMinSumRow(int[,] array)
{
    int sumFirstRow = 0;
    int sumOfOthers = 0;
    int result = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sumFirstRow += array[i, j];
            }
            else
            {
                sumOfOthers += array[i, j];
            }
        }
        if (result < sumFirstRow)
        {
            result = sumFirstRow;
            sumFirstRow = 0;
            row = i;
        }
        else if (result > sumOfOthers)
        {
            result = sumOfOthers;
            row = i;
        }
        sumOfOthers = 0;
    }
    Console.WriteLine($"Row number: {row + 1}, sum of elements: {result}");
}

int[,] arr = fillArray();
printArray(arr);
findMinSumRow(arr);
