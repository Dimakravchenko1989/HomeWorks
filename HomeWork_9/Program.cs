// ДЗ 9.
/*
-----------------------------------------------------
Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5. -> "5, 4, 3, 2, 1"
N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

void ShowNumbers(int n, int count)
{
    if (count > n) return;
    else
        ShowNumbers(n, count + 1);
        Console.Write(count + " ");
}

ShowNumbers(number, count);



-------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalElements(int m, int n)
{
    if (m > n)
        return SumNaturalElements(m, n + 1) + n;
    else if (m < n)
        return SumNaturalElements(m + 1, n) + m;
    return m;
}
Console.Write($"Сумма натуральных чисел: {SumNaturalElements(m, n)}");




------------------------------------------------------
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29



int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);

    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AckermanFunction(m, n)}");
*/