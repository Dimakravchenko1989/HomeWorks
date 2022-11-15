// ДЗ 3.

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
// Console.WriteLine("Введите любое пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num>99999 || num<=9999)
// {
//     Console.WriteLine("Вы ввели некорректное число");
//     return;
// }
// if (num/10000==num%10 && num/1000%10==num/10%10)
//     Console.WriteLine($"Число {num} является палиндромом");
// else
//     Console.WriteLine($"Число {num} не является палиндромом");
// */



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

/*
double Distance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double dist1 = x1 - x2;
    double dist2 = y1 - y2;
    double dist3 = z1 - z2;
    double dist4 = Math.Sqrt(dist1*dist1 + dist2*dist2 + dist3*dist3);
    return dist4;
}
Console.Write("Введите координаты точки А x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки В x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки В y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки В z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками А и В равно: {Math.Round(Distance(x1,y1,x2,y2,z1,z2),2)}");
*/



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int number)
{
    int index = 1;
    while (index <= number)
    {
      double result = Math.Pow(index,3);
      Console.Write(result + " ");
      index++;
    }
}
Console.Write("Введите любое число: ");
int res = Convert.ToInt32(Console.ReadLine());
Cube(res);
*/
/*
Console.WriteLine("Введите число N ");
int N= int.Parse(Console.ReadLine());
int SumNumber()
{
    int count=Convert.ToString(N).Length;
    int result = 0;
    
for (int i=0; i<count; i++)
{
    count = N-N%10;
    result=result + (N-count);
    N=N/10;
}
return result; 
}
int sumN=SumNumber();
Console.WriteLine(sumN);
*/


/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

// Console.WriteLine("Введите число А ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int B = int.Parse(Console.ReadLine());
// int Exponentiation()
// {
//     int result=1;
//     for (int i=1; i<=B; i++)
//     {
//         result=result*A;
//     }
//     return result;

// }
// int exp=Exponentiation();
// Console.WriteLine("Возведение числа А в степень В = " + exp);


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
int[] numbers = new int[10];
void FillArray(int[]array, int min, int max)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(min,max);
    }
}
void WriteArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int QuantityPositive(int[]array)
{
int quantity= 0;
    for (int i=0; i< array.Length; i++ )
{
    if (array[i]%2==0)
    {
        quantity++;
    }
}
return quantity;
}
FillArray(numbers,100,1000);
WriteArray(numbers);
// Console.WriteLine();
int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity} ");