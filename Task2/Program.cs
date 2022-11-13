//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

void FillArray(int[] array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a,b);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Задан массив чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetSumElemInOddPos(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите диапазон массива от: ");
int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите диапазон массива до: ");
int before = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] arr = new int[size];
FillArray(arr,from,before);
PrintArray(arr);
Console.WriteLine();

int res = GetSumElemInOddPos(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");

//Console.ReadKey();