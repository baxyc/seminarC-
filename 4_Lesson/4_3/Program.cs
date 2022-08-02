void Random01Array(int num)
{
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }

}
Random01Array(8);