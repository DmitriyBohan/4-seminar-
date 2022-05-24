/*
Задача 26: Напишите программу, которая 
принимает на вход число и выдаёт количество
цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Напишите вход число  и узнаете  сумму чисел от 1 до Вашего числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = number;
while (count > 0)
{
    count /= 10;
    i++;
}
Console.WriteLine(number + " -> " + i);