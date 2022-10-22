
 // ДЗ 2


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int des = number % 100 / 10;
    return des;
}
int randNum = new Random().Next(100,1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*
int ThreeDigit(int num)
{
    while (num > 999)
        num = num / 10;
        num = num % 10;
        return num;
}
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int three = ThreeDigit(num);
if (num < 100)
{
    Console.WriteLine($"В данном числе нет третьей цифры");
}
else
Console.WriteLine($"Третья цифра заданного числа: {three}");
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool DayWeek(int num)
{
    if(num > 5 & num <= 7)
        return true;
    else
        return false;
} 
Console.Write("Является ли это день выходным? Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayWeek(num));
*/