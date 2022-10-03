//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк 1-й матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int rows2 = columns1;
int columns2 = rows1;

Console.WriteLine("Первая матрица: ");
int[,] matrix = new int [rows1, columns1];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-50, 51);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


Console.WriteLine("Вторая матрица: ");
int[,] matrix2 = new int [rows2, columns2];

for(int i = 0; i < matrix2.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(-50,51);
        Console.Write(matrix2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
Console.WriteLine("Произведение матриц: ");

int[,] matrixAnsver = new int[matrix.GetLength(0), matrix2.GetLength(1)];
for(int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j <matrix2.GetLength(1); j++)
    {
        for (int k=0; k<matrix2.GetLength(0); k++)
        {
            matrixAnsver[i,j] +=matrix[i,k] * matrix2[k,j];
        }
        Console.Write(matrixAnsver[i,j] + "\t");
    }
    Console.WriteLine();
    }
    
