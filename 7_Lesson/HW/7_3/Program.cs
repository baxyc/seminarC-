// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.Например, задан массив

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

void findAverageArithmeticOfColumn(int[,] array)
{
    double result = 0;
    Console.WriteLine("Average arithmetics of columns:");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        Console.Write($"{Math.Round(result / array.GetLength(0), 2)} \t");
        result = 0;
    }

}

int[,] array = fillArray();
printArray(array);
findAverageArithmeticOfColumn(array);