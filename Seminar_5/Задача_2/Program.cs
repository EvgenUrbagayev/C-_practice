// Задача: напишите программу, которая меняет элементы массива положительные
// на отрицательные и наоборот.




using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение массива:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max); 
Write($"Исходный массив: [{String.Join(",", array)}]");



for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        array[i] = - array[i];
    }
    else
    {
        array[i] = - array[i];
    }
       
}
WriteLine();
Write($"Измененный массив: [{String.Join(",", array)}]");


int[] GetArray(int size, int minValue, int maxValue)

{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }



    return result;

}