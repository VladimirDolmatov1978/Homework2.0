// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = new Random().Next(0, 100);
}

Console.WriteLine(String.Join(" ", arr));
int max = arr[0];
int min = arr[0];
for (int i = 1; i < 10; i++)
{
    if (arr[i] > (max))
        max = arr[i];

}
Console.WriteLine($"Это максимальный элемент массива   {max}");
for (int i = 1; i < 10; i++)
{
    if (arr[i] < (min))
        min = arr[i];
}
Console.WriteLine($"Это минимальный элемент массива     {min}");
int diff = max - min;
Console.WriteLine($"Разница между минимальным и максимальным элементами массива   {diff}");