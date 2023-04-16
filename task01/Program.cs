// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32( Console.ReadLine());
int num2 = Convert.ToInt32( Console.ReadLine());
if ((num1 == num2 * num2) | (num2 == num1 * num1)){
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}

