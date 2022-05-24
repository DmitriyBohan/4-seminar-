/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


Console.WriteLine("Напишите вход число  и узнаете  сумму чисел от 1 до Вашего числа");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 0;
while (i <= number)
{
    result = result + i;
    i++;
}
Console.WriteLine(number + " -> " + result);