﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число:");
string? numberStringOne = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);

if (numberIntOne % 2 == 0)
{
    Console.Write("да");
}
else
{
   Console.WriteLine("нет");  
    
}    