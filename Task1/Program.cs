//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив положительных трёхзначных чисел: ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Сделаем переход на следующую строку через 25 чисел массива. 
        if ((i+1) % 25 == 0) Console.WriteLine();
    }
    Console.WriteLine();
}

int GetNumberOfEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }   
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] arr = new int[size]; 

FillArray(arr);
PrintArray(arr);

Console.WriteLine();

int res = GetNumberOfEven(arr);
Console.WriteLine($"Количестство четных чисел в массиве: {res}");
Console.WriteLine();

//Console.ReadKey();