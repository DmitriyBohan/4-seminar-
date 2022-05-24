/*
Задача 28: Напишите программу, которая принимает 
на вход число N и выдаёт произведение
чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Напишите вход число  и узнаете  сумму чисел от 1 до Вашего числа: ");
int number = Convert.ToInt32(Console.ReadLine());
double result = 1;
for (int i = 1; i <= number; i++)
{
    result *= i;
}
Console.WriteLine(number + " -> " + result);