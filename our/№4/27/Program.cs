// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (num > 0)
{
    int result  = num % 10;
    num = num / 10;
    summ = summ + result;
}


Console.WriteLine($"Сумма всех цифр числа равна {summ}");