// Напишите программу, которая определяет присутствует ли данное
// число в массиве.

using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение массива:  ");
int max = int.Parse(ReadLine()!);
WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max); 
WriteLine($"Исходный массив: [{String.Join(",", array)}]");

foreach(var element in array)
{
    if(element == number)
        {
            WriteLine($"В данном массиве {number} присутствует");
            return;
        }
}       

WriteLine($"В данном массиве {number} отсутствует");




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