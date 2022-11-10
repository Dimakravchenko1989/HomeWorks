//ДЗ 4.

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiation(int a, int b)
{
    int result=1;
    for (int i=1; i<=b; i++)
    {
        result=result*a;
    }
    return result;
}
Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Возведение числа {a} в степень {b} = {Exponentiation(a,b)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber(int n)
{
    int count=Convert.ToString(n).Length;
    int result = 0;
    
for (int i=0; i<count; i++)
{
    count = n-n%10;
    result=result + (n-count);
    n=n/10;
}
return result; 
}
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе N = {SumNumber(n)}");
*/



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.



/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}

Console.Write("Ведите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]myArray = CreateArray(n);
ShowArray(myArray);
*/


