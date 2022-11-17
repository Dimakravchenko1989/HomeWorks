/*
ДЗ 6.
Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write($"Укажите количество чисел M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];
int count = 0;


void InputNumbers(int m)
{
    for (int i=0; i<m; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

InputNumbers(m);

for (int i = 0; i < massiveNumbers.Length; i++)
{
    if (massiveNumbers[i] > 0) count++;
}

Console.WriteLine($"Количество элементов больше 0 равно: {count}");



--------------------------------------------------------------------

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


if ((k1 == k2) && (b1 == b2))
    {
        Console.Write($"\nПрямые совпадают");
    }
        
else 
if (k1==k2)
    {
        Console.Write($"\nПрямые параллельны");
    }   

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
}
*/



