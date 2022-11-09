//Программа, которая задаёт массив из 8 элементов и выводит их на экран.
//Заполнение массива производит пользователь.

Console.Clear();

void FillArray(int[] array)
{
    Console.WriteLine($"Введите 8 любых целых чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("Массив чисел: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}

int[] arr = new int[8];
Console.WriteLine();
FillArray(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
