
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array, int index) {
    if (index >= array.Length)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArray(array, index + 1);
}

void PrintArrayRevers(int[] array, int index)
{
    if (index < 0)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArrayRevers(array, index - 1);
}

System.Console.WriteLine($"Enter the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Enter the minimum element value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Enter the maximum element value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size, min, max);
System.Console.Write("Printing the array first: ");
PrintArray(array, 0);
System.Console.Write("Outputting an array from the end: ");
PrintArrayRevers(array, array.Length - 1);