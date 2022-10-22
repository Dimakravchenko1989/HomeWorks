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