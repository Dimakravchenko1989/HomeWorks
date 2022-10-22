
// Домашнее задание 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"Большее число равно: {n1} , меньшее число равно: {n2}");
}
else
{
    Console.WriteLine($"Большее число равно: {n2} , меньшее число равно: {n1}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2 > max)
{
    max = n2;
    if(n3 > max)
    {
        max = n3;
        Console.Write($"Максимальное число равно: {max}");
    }
}
else 
if (n3 > max)
    max = n3;
    Console.WriteLine($"Максимальное число равно: {max}");
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int n1 = Convert.ToInt32 (Console.ReadLine());
int number = n1 % 2;

if(number == 0)
{
Console.WriteLine($"Число {n1} является четным");
}
else{
    Console.WriteLine($"Число {n1} не является четным");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = 2;
int n2 = -2;

if(number >0)
{
   while(n1 <= number)
   {
        Console.Write(n1 + " ");
        n1 = n1 + 2; 
    }
}
else
{
    while(n2 >= number)
    {
        Console.Write(n2 + " ");
        n2 = n2 - 2;  
    }
}
*/