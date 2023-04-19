// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome(int num)
{
    int dig1 = num / 10000;
    int dig2 = num / 1000 % 10;
    int dig4 = num / 10 % 10;
    int dig5 = num % 10;
    return dig1 == dig5 && dig2 == dig4;
}

string result = IsPalindrome(number) ? "Да" : "Нет";
Console.WriteLine(result);