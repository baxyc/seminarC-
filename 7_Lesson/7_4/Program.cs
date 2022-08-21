// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
void findElement(int[,] array)
{
    Console.Write("Enter number to find: ");
    int number = int.Parse(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Number to find {number}, result: [{i}, {j}]");
                return;
            }
        }
    }
    Console.WriteLine($"No number to find in array");
}


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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = fillArray();
findElement(array);
printArray(array);