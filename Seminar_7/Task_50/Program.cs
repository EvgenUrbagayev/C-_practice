// Задайте двумерный массив, найти сумму элементов, находящихся на главной диагонали
// Главная диагональ - в которой оба индекса равны



using static System.Console;
Clear();
WriteLine("Введите количество строк и столбцов матрицы: ");

int[,] matrix = GetMatrixArray(5, 4);
PrintMatrix(matrix);
WriteLine();
EditMatrix(matrix);
WriteLine(EditMatrix(matrix));




int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = new Random().Next(0, 5);
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
            Write($"{InMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


int EditMatrix(int[,] NewMatrix)
{
    int result = 0;
    int newI = NewMatrix.GetLength(0) > NewMatrix.GetLength(1) ? 1 : 0;
    for (int i = 0; i < NewMatrix.GetLength(newI); i++)
    {
        //for (int j = 0; j < NewMatrix.GetLength(1); j++)
        //{
        //    if(i == j)
        //    {

        result += NewMatrix[i, i];
        //NewMatrix[i,j] = Convert.ToInt32(Math.Pow(NewMatrix[i,j],2));
        // NewMatrix[i.j] *= NewMatrix[i,j];
        //    }
        //}

    }
    return result;
}

