/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number;
Console.Write("Введите трехзначное число: ");
number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.Write("Третьей цифры нет ");
}
else
{
while (number > 999)
{
    number = number/10;
    Console.WriteLine(number);
}

Console.WriteLine("Третья цифра: " +number%10);
}