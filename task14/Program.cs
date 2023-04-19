// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет 
// 161 -> да

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

bool result = MultipleTwoDigits(numberA);
Console.WriteLine(result ? "да" : "нет");
bool MultipleTwoDigits(int num)
{
     return numberA %7 == 0 && num % 23 == 0;
}