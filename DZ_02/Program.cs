// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.WriteLine("Введите число M:");
int  m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int  n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if(m <= n)
{
   Console.WriteLine("Ошибка введения данных!"); 
}
if(m < n)
{
    while(m <= n)
    {
        Console.Write(m + "\t");
        sum += m;
        m++;
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел: " + sum);
}
else
{
    while(n <= m)
    {
        Console.Write(n + "\t");
        sum += n;
        n++;
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел: " + sum);
}
