// Задача 49: Задайте двумерный массив. Найдите элементы массива, у кот. оба индекса
// четные и замените эти элементы на их квадраты.
// Например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1  4   7  2
// 5 *81* 2 *9*
// 8  4   2  4 



using static System.Console;
Clear();
WriteLine("Введите количество строк и столбцов матрицы: ");

int[,] matrix = GetMatrixArray(3, 4); 
PrintMatrix(matrix);
WriteLine();
EditMatrix(matrix);
PrintMatrix(matrix);




int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = new Random().Next(1, 99);
        }
    }
    return resultMatrix;
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


void EditMatrix(int[,] NewMatrix)
{
    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 ==0)
            {
                NewMatrix[i,j] = Convert.ToInt32(Math.Pow(NewMatrix[i,j],2));
                // NewMatrix[i.j] *= NewMatrix[i,j];
            }
        }
        
    }
}