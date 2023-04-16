// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<0)
   num = -num;
if(num>=100&&num<=999)
   Console.Write(num%10);
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}