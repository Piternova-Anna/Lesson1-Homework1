// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("введите число:");
int N = int.Parse(Console.ReadLine());
int i = 0;

if (N <= 1 )
{
    Console.WriteLine("Введите число больше единицы");
}
 else while (i < N)
    {
      Console.WriteLine(i+2);
       i=i+2;       
    }
    