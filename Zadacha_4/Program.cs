// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Наибольшее значение: ");

if(number1>=number2 && number1>=number3)
{
    Console.WriteLine(number1);
}
if(number2>=number1 && number2>=number3)
{
    Console.WriteLine(number2);
}
if(number3>=number1 && number3>=number2)
{
    Console.WriteLine(number3);
}