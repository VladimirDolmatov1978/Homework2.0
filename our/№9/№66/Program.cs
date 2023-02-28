// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SummNum(int min, int max)
{
    if (min == max)
        return max;
    else
    {
        return min + SummNum(min+1, max);
    }
}


int m = Prompt("введи M: ");
int n = Prompt("введи N: ");
System.Console.WriteLine(SummNum(m, n));
