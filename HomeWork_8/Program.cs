
/*
ДЗ 8.

--------------------------------------

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2



int [,] CreateRandom2dArray(int rows, int colums)
{
    int[,] array = new int [rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(0,10);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortByDecrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
SortByDecrease(myArray);
Show2dArray(myArray);


-------------------------------------------


Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка


int [,] CreateRandom2dArray (int rows, int colums)
{
    int[,] array = new int [rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(0, 10);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);

int minSumLine = 0;
int sumLine = SumLineElements(myArray, 0); 
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(myArray, i); 
  if (sumLine > tempSumLine) 
  {
    sumLine = tempSumLine; 
    minSumLine = i; 
  }
}

Console.WriteLine($"\n Наименьшая сумма элементов - строка {minSumLine+1}");


----------------------------------------------------


Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18


void MatrixMultiplication(int a1, int a2, int b1, int b2, int c1, int c2, int d1, int d2)
{
    Console.WriteLine("Произведение двух матриц равно: ");
    Console.WriteLine($"|{a1 * c1 + b1 * c2} {a1 * d1 + b1 * d2}|");
    Console.WriteLine($"|{a2 * c1 + b2 * c2} {a2 * d1 + b2 * d2}|\n");
}


Console.Write("Введите a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c2: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите d1: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите d2: ");
int d2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сформированная матрица: \n");
Console.WriteLine($"|{a1} {b1}| |{c1} {d1}|");
Console.WriteLine($"|{a2} {b2}| |{c2} {d2}|\n");

MatrixMultiplication(a1, a2, b1, b2, c1, c2, d1, d2);


-----------------------------------------------------

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int n = 1;
int[,] array = new int[n, n];

int temp = 3;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
Show2dArray(array);


Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void Create3dArray (int[,,] array)
{
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] += count;
                count += 3;
            }
        }
    }
}
int[,,] array3D = new int[2, 2, 2];
Create3dArray(array3D);
Show3dArray(array3D);
*/

