using static System.Console;
Clear();
WriteLine("Введите размер массива:  ");
int lenght = int.Parse(ReadLine()!);
WriteLine("Введите минимальное значение массива:  ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальное значение массива:  ");
int max = int.Parse(ReadLine()!);


int[] array = GetArray(lenght, min, max); // есть массив array, это результат выполнения функции GetArray
// параметры для GetArray мы считали с консоли (ввел пользователь)
// string strArray = String.Join(",", array); // выводит массив в строку
WriteLine($"[{String.Join(",", array)}]"); // вывести в качестве параметра наш массив



int positivSum = 0; //переменная которая вычисляет сумму положительных элементов
int negativSum = 0; //переменная которая вычисляет сумму отрицательных элементов
foreach(int element in array)
{
    if(element > 0)
    {
        positivSum += element;
    }
    if(element < 0)
    {
        negativSum += element;
    }

// тернарный оператор, вместо if:
// positivSum += element > 0 ? element : 0;   если element > 0, то мы докидываем 
// переменную element, а иначе некую переменную, кот.нам ничего не испортит напр. 0
// negativSum += element > 0 ? element : 0;


}
WriteLine($"NegativeSum = {negativSum}, PositivSum = {positivSum}");


int[] GetArray(int size, int minValue, int maxValue) // в ф-цию передали размер,макс.и мин. значения

{
    Random rnd = new Random(); // переменная rnd типа Random
    int[] result = new int[size];  // создай новый массив new int[указали размер массива]
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1); // вызываем rnd метод Next (в качестве мин и макс значений указываем minValue и maxValue)
    }



    return result; // наш результат нужно отдать

}