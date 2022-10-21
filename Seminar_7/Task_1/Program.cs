// Задача 46: задайте двумерный массив размером m*n, заполненный случайными целыми числами
// m=3, n=4
// 1  4 8  19
// 5 -2 33 -2
// 5 -2 33 -2
// 77 3 8   1


using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!); // создадим наш массив с параметрами
// и передадим в него нашу консоль и получили набор чисел
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
// создадим нашу матрицу - это ничто иное, как наш масси GetMatrixArray
// в качестве параметров мы передаем готовые числа. В первом лежит кол-во
// строк, во втором - кол-во столбцов, мин и макс элементы

PrintMatrix(matrix); // выведем нашу матрицу в консоль


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
// метод называется GetMatrixArray,который возвращ. двумерный массив в указанном диапазоне
// в качестве параметров передадим количество строк rows, количество столбцов columns
// мин и макс значения элементов в массиве
{
    int[,] resultMatrix = new int[rows, columns];  // создадим результирующий элемент
    // resultMatrix. Кол-во строк и столбцов известно: rows, columns
    // далее нам матрицу необходимо заполнить, заполняем через циклы:
    for (int i = 0; i < resultMatrix.GetLength(0); i++) // 0 - макс кол-во строк
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) // 1 - макс кол-во столбцов
        {
            resultMatrix[i,j] = new Random().Next(minValue, maxValue);
            // начинаем матрицу заполнять (инициализируем нашу матрицу)
        }
    }
    return resultMatrix; // вернем

}



void PrintMatrix(int[,] inMatrix)   // создали метод void, кот. будет печатать матрицу.
// (выводить в консоль) В качестве входного параметра передаем туда наш двумерный массив,
// назовем например inMatrix
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) // Проходим циклом выведем все в консоль
    {
        for (int j = 0; j < inMatrix.GetLength(0); j++) //  в этом цикле мы собираем строку
        {
            Write($"{inMatrix[i,j]} "); //выведем с параметром, будем выводить поэлементно
            // строку, добавляя один пробел после вывода
        }
        WriteLine(); // после того как мы строку собрали нам необходимо вывести пустую строчку
        // для того чтобы переместить курсор на следующую строку
    } 
}



// сделаем метод, кот. из строки будет возвращать в числовом виде параметры,
// а именно кол-во строк и столбцов и мин и макс элемент
int[] GetArrayFromString(string parameters) // назовем этот метод GetArrayFromString,
// в качестве параметра будем передавать строку и назовем ее parameters

{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
    // метод Split() разбивает строку на подстроки
    // указанным разделителем, в кач. разделителя укажем например пробел
    // StringSplitOptions.RemoveEmptyEntries-опция удаляет пустые переменные
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++) // пройдемся циклом
    {
        parameterNum[i] = int.Parse(parames[i]);
    }

// мы попросим ввести кол-во строк и столбцов и этот метод GetArrayFromString
// вернет набор чисел


    return parameterNum;
}
