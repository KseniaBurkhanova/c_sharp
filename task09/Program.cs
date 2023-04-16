// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int num = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {num}");
// int firstDigit = num / 10;
// int secondDigit = num % 10;
// if (firstDigit > secondDigit) 
// {
//     Console.Write($" Наибольшая цифра числа=  {firstDigit}");
// }
// else 
// {
// Console.Write($" Наибольшая цифра числа=  {secondDigit}" );
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.Write($" Наибольшая цифра числа=  {maxDigit}" );

int maxDigit = MaxDigit(num);
Console.Write($" Наибольшая цифра числа =  {maxDigit}" );

int MaxDigit(int number) // number = num
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;

}