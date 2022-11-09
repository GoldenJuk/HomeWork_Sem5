//Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Для решения задания использование цикла for является обязательным условием.
//Не использовать встроенный метод возведения в степень.

//Используем "double" для получения результата при отрицательном показателе степени

Console.Clear();

double GetPow (double a, int b)
{
    double res = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
        {
            res = res * a;
        }
    
    if (b < 0)
    {
        res = 1 / res;
      
    }
     return res;
}

Console.Write("Введите число А: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


double pow = GetPow(number1, number2);
Console.WriteLine($"{number1} ^ {number2} = {pow}");
Console.WriteLine();