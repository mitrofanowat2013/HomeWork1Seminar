﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// a = 3 b = 3 -> равны

 Console.WriteLine("Введите первое число");
 Console.WriteLine("Введите второе число");
 
       int a = Convert.ToInt32(Console.ReadLine());
 
        int b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b) Console.WriteLine("{0} наибольшее число", a);
 
        if (a < b) 
        {
            Console.WriteLine("{0} наибольшее число", b);  
        }     

            else Console.WriteLine( "числа равны" ); 

 
      

 
        
   