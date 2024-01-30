// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

int rec(int m, int n)
{
    if (m == n)
        return n;
    else
        Console.WriteLine(m);
    return m + rec(m + 1, n);
}
Console.Write("Вывести числа в промежутке");
Console.Write("от: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("до: ");
int n = Convert.ToInt32(Console.ReadLine());
rec(m, n);
