﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());
void day (int num)
{
if (num <= 0 || num > 7)
{
    Console.WriteLine("Введенная цифра не соответствует не одному из дней недели");
}

else if (num >= 1 && num <= 5)
{
    Console.WriteLine("Этот день не выходной");

}
else if (num == 6 || num == 7)
{

    Console.WriteLine("Этот день выходной");

}
}
day(num);