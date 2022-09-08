// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string array = Console.ReadLine();
if(array.Length <= 2) 
Console.WriteLine("Третьей цифры нет");

Console.WriteLine(array[2]);


