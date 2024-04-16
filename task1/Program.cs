// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string NatN(int start, int stop)
{
    if (start == stop) return Convert.ToString(stop);
    return start + " " + NatN(start + 1, stop);
}

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NatN(n, m));