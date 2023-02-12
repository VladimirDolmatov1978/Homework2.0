// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число");
//void number (int num);
int num = Convert.ToInt32(Console.ReadLine());
//double num1 = num/100000;
//double num2 = num /10;
//double num3 = num / 10000;
//double num4 = num /100;

// if ((Math.Round(num1 , 1)) = (Math.Round(num4 , 1))) && ((Math.Round(num2 , 1)) = (Math.Round(num3 , 1)))

    //if

      int num1 = num % 10;
      //int num4 = num % 10;
    
    Console.WriteLine(num1);



//else
   // Console.WriteLine("Введенное число не является полиндромом");
