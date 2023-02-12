// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты Ax: ");
double Ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Ay: ");
double Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Az: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Bx: ");
double Bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты By: ");
double By = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Bz: ");
double Bz = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine( $"Расстояние между точками составляет: {(Math.Round(distanse , 2))}");
