//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b>a)
    Console.WriteLine(b);

if(a<b)
    Console.WriteLine(a);
else
    Console.WriteLine(a > b? "Первое число больше второго": "Второе число больше первого");
