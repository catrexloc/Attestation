// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// int rec(int m, int n)
// {
//     if (m == n)
//         return n;
//     else
//         Console.WriteLine(m);
//     return m + rec(m + 1, n);
// }
// Console.Write("Вывести числа в промежутке");
// Console.Write("от: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("до: ");
// int n = Convert.ToInt32(Console.ReadLine());
// rec(m, n);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

// int rec(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return rec(m - 1, 1);
//     }
//     else
//     {
//         return (rec(m - 1, rec(m, n - 1)));
//     }
// }
// Console.Clear();
// Console.Write("Число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write($"m = {m}, n = {n} => {rec(m, n)}"); 

//Задача 3

void rec(int[] array, int i = 0)
{ 
   if (i != array.Length)
   {
      rec(array, i + 1);
      Console.Write($"{array[i]} ");
   }
}
Console.Clear();
Console.Write($"[1, 7, 5, 6, 2] => ");
int[] array = new int[] { 1, 7, 5, 6, 2 };
rec(array);

