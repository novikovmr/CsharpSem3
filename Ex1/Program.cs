/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

bool f(int x)
{
    int x1 = x / 10000;
    int x2 = x / 1000 % 10;
    int x3 = x / 100 % 10;
    int x4 = x / 10 % 10;
    int x5 = x % 10;
    if (x1 == x5 && x2 == x4) return true;
    else return false;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9999 && n < 100000)
{
    if (f(n)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Неверное число");