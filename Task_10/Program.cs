/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
using System.Data;

int number;
Console.Write("Введите трехзначное число: ");
number = int.Parse(Console.ReadLine());
while (number < 100 || number > 1000)
{
    Console.Write("Вы ввели не трёхзначное число, повторите ввод: ");
    number = int.Parse(Console.ReadLine());
}
number = number / 10% 10;
Console.WriteLine("Вторая цифра: " +number);