//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;
if(B>max) max=B;
if(C>max) max=C;
Console.Write("Введённое максимальное число: max=");
Console.WriteLine(max);

Console.WriteLine($"{A}{B}{C} -> {max}");