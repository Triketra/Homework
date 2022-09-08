// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
int num1 = num / 10;
int num2 = num1 % 10;

Console.WriteLine(num);
Console.WriteLine(num2);