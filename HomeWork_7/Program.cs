/*
ДЗ 7.

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Console.Clear();

double [,] CreateRandom2dArrayDouble(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            array[i, j] += new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArrayDouble(m, n, min, max);
Show2dArray(myArray);





Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет


Console.Clear();

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

bool СheckValue2dArray(int[,] array, int poz1, int poz2)
{
    if (poz1 < array.GetLength(0) && poz2 < array.GetLength(1))
        return true;
    return false;
}

int GetValue2dArray(int[,] array, int poz1, int poz2)
{
    return array[poz1, poz2];
}


Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = CreateRandom2dArray(6, 6, 10, 99);
Show2dArray(randomArray);
if (СheckValue2dArray(randomArray, row, column))
    Console.Write($"В указанной позиции элемент: {GetValue2dArray(randomArray, row, column)}");
else
    Console.Write("В указанной позиции элемент отсутствует!");




Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


double[] ArithmeticMean(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    double[] arrayArithmetic = new double[column];

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++)
            arrayArithmetic[i] += array[j, i];

        arrayArithmetic[i] /= row;
        arrayArithmetic[i] = Math.Round(arrayArithmetic[i], 1);
        Console.Write(arrayArithmetic[i] + "; ");
    }

    return arrayArithmetic;
}   
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
double[] newArray = ArithmeticMean(myArray);
ShowArrayDouble(newArray);

 */
