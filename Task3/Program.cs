//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

void FillArray(double[] array)
{
    Console.WriteLine($"Введите массив вещественных чисел, состоящий из {array.Length} чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    Console.Write("Задан массив чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}

double FindTheDifference(double[] array)
{    
    double min = array[0];
    double max = array[1];
    double diff = 0;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    diff = max - min;
    return diff;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] arr = new double[size];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
double difference = FindTheDifference(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет: {difference}");

Console.WriteLine();

//Console.ReadKey();
