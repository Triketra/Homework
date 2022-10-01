// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

for(int i =0; i<rows; i++)
{
for(int j =0; j<columns; j++)
{
matrix[i,j] = new Random().Next(10, 100);
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numColumns = Convert.ToInt32(Console.ReadLine());

if (rows < numRows || columns < numColumns)
{
    Console.WriteLine("Такой позиции нет");
}
else
Console.WriteLine(matrix[numRows-1, numColumns-1]);