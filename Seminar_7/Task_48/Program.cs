// Задача 48: Задайте двумерный массив m на n, каждый элемент массива находится по формуле
// A = m + n. Выведите полученный массив на экран
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using static System.Console;
Clear();
Write("Введите количество строк и столбцов матрицы: ");

int[,] matrix = GetMatrixArray(3, 4); 
PrintMatrix(matrix);



int[,] GetMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}


void PrintMatrix(int[,] InMatrix)
{
    for (int i = 0; i < InMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InMatrix.GetLength(1); j++)
        {
            Write($"{InMatrix[i,j]}\t");
        }
        WriteLine();
    }
}