// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] num = {-1,-7,567,89,223};
Console.WriteLine(num);
int sum = 0;
for (int i = 0; i < 5; i++)
{
    if (num[i] >0)
    sum++;
}

Console.WriteLine(string.Join(",",num));
Console.WriteLine(sum);