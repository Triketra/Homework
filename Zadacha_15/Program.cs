// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay<1 || numberDay>7)
{
    Console.WriteLine("Ошибка");
}
    if(numberDay ==6 || numberDay==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
