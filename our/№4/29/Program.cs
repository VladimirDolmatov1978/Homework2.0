// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

    int [] arr = new int [8];
for (int i = 0; i < 8; i++)
{
     Console.Write( $"Введите значение для массива под номером {i}:\t ");
     arr[i] = int.Parse(Console.ReadLine()); 
}


Console.WriteLine("Вывод массива");


    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine(arr[i]);
    }

