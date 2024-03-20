// Задача 1: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void FuncNutNumber(int m, int n)
{
    if (n == m)
    {
        return;
    }
    if (m < n)
    {
        Console.WriteLine(m);
        m++;
        FuncNutNumber(m, n);
    }
}

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
FuncNutNumber(m, n+1);
