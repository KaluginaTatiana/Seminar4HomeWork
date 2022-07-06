// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число a - основание степени.");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральное число n - показатель степени.");
double n = Convert.ToDouble(Console.ReadLine());
if ( n < 1 || n % 1 != 0 )
Console.WriteLine("Ошибка. Показатель степени должен быть натуральным числом (целое число от 1 до бесконечности).");
else 
Console.WriteLine("Число " + a + " в степени " + n + " равно " + Math.Round(Power(a, n), 3) + ".");
Console.WriteLine("(результат округляется до трех знаков после запятой, если в степень возводится десятичное число)");

double Power(double number, double power)
{
    double count = 1;
    double res = 1;
    while (count <= power)
    {
        res = res * number;
        count++;
    }
    return res;
}

