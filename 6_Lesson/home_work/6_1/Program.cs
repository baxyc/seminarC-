void Print(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 20) - 10, 2);
    }
    return arr;
}
double[] CopyMass(double[] arr)
{
    int size = arr.Length;
    double[] new_arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}
double[] arr_1 = MassNums(5, 1, 11);
Print(arr_1);
double[] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);