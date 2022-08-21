// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

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

int[] searchPosOfMin(int[,] array)
{
    int min = array[0, 0];
    int indexIOfMin = 0;
    int indexJOfMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexIOfMin = i;
                indexJOfMin = j;
            }
        }
    }
    int[] index = { indexIOfMin, indexJOfMin };
    Console.WriteLine($"Min is {min}, i = {indexIOfMin}, j = {indexJOfMin}");
    return index;
}

void newArray(int[,] array, int[] indexes)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexes[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexes[1])
                {
                    Console.Write($"{array[i, j]} \t");
                }
            }
            Console.WriteLine();
        }
    }
}

int[,] array = fillArray();
printArray(array);
newArray(array, searchPosOfMin(array));