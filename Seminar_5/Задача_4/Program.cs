// Найдите произведение пар чисел в одномерном массиве
// пары считаются: первый - последний, второй - предпоследний.

using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение массива:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max); 
WriteLine($"Исходный массив: [{String.Join(",", array)}]");


if(array.Length % 2 == 0)
{
    int arrayLength = array.Length / 2;
}
else
{
    int arrayLength = array.Length / 2 + 1;
}


int[] newArray = new int [arrayLength];

for (int i = 0; i < array.Length; i++)
{
    int multy = array[i] * array[array.Length - 1 - i];
}





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