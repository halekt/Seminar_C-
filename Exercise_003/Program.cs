﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 1)  //Означает, что при делении на 2 остаток будет равен целому числу

Console.WriteLine("Число "  +  a  + " является : Нечетное");

else

Console.WriteLine("Число " + a + " является : Четное");
            
           