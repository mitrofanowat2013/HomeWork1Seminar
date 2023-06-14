// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStrinTwo= Console.ReadLine();

Console.WriteLine("Введите третье число:");
string? numberStrinThree= Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStrinTwo);
int numberIntThree = Convert.ToInt32(numberStrinThree);
int max = numberIntOne;

if (numberIntOne > max) max = numberIntOne;
if (numberIntTwo > max) max = numberIntTwo;
if (numberIntThree > max) max = numberIntThree;
 
Console.Write("max = ");
Console.WriteLine(max);  
