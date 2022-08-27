// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("введите третье число: ");
int n3 = int.Parse(Console.ReadLine());

int max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write("максимальное число ");
Console.WriteLine(max);