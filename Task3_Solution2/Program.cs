//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

//Задаем массив случайных вещественных чисел в дипазоне (-100, 100).

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = Convert.ToDouble(-100 + rnd.Next(200));
        array[i] = rnd.NextDouble() * 100 - rnd.NextDouble() * 100;
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine("Задан массив чисел: ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,-19}  ", array[i]);

        //Сделаем переход на следующую строку через 5 чисел массива. 
        if ((i+1) % 5 == 0) Console.WriteLine();
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

Console.ReadKey();