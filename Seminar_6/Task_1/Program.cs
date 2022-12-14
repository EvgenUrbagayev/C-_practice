


using static System.Console;

Clear();
WriteLine("Введите размер массива, мин и макс значение через пробел:  ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
 // после введения размера, мин и макс значения
// получим массив строк string, назовем его parameters. Чтобы разбить строку
// на подстроки через указанный символ.
// Для этого мы считываем параметр строки ReadLine и вызываем метод Split
// Split позволяет разбить строку на подстроки по указанным параметрам (" ")
// StringSplitOptions.RemoveEmptyEntries - параметр для удаления лишних пробелов
// при вводе цифр. Этой опцией принудительно говорим: удали пустые сущности

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
// создаем массив array, вызываем метод GetArray, в качестве входных параметров
// передаем мин и макс значения parameters
// Считали все параметры и положили в массив array

WriteLine($"[{String.Join(",",array)}]"); // выводим массив в консоль

WriteLine($"[{String.Join(",",ReverseArray1(array))}]"); //выводим массив в консоль
// реверс массива (т.к. метод возвращает значение, то мы его можем подложить
// в String.Join)

ReverseArray2(array); //т.к. ReverseArray2 метод void, то сначала мы его вызываем,
// подкладываем в него наш массив, он его тусует
WriteLine($"[{String.Join(",",array)}]"); // выводим массив в консоль

WriteLine($"[{String.Join(",",ReverseArray3(array))}]"); // метод возьмет массив
// array, перетасует и вернет его в качестве выходного параметра



int[] GetArray(int size, int minValue, int maxValue) // создали целочисленный массив 
// GetArray, передали в него размер, минимальное и максимальное значение
{
    int[] result = new int[size];  // создали выходную переменную result
    Random rnd = new Random();
        
        for (int i = 0; i < size; i++) // инициализировали массив
        {
            result[i] = rnd.Next(minValue, maxValue + 1); // вызвали метод Next
        }


    return result; // вернули ее, чтобы метод был как минимум рабочий
}

// Вариант 1: создаем реверс на базе нового массива

// Создаем новый метод реверс массива
int[] ReverseArray1(int[] inArray) // реализуем этот метод через создание нового
// массива ReverseArray. В качестве входного параметра передаем наш массив
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++) //разворачиваем массив
    {
        result[i] = inArray[inArray.Length-1-i]; // только говорим, 
        // что result[i] это наш входной массив, но начинаем обрабатывать его с конца
        // длина массива - 1, потому что нумерация начинается с 0 и - i 
    }
    return result; // возвращаем наш массив
}


// Вариант 2: создаем реверс на базе старого

void ReverseArray2(int[] inArray) // так как мы разворачиваем текущий массив и
// нам возвращать ничего не надо, метод наш становится void

{
    // промежуточные переменные не нужны, так как метод void
    for (int i = 0; i < inArray.Length/2; i++) //разворачиваем массив
    {
        // для перетасовывания элементов нам нужна буферная (временная) переменная
        int temp = inArray[i]; // в нее мы кладем условно стартовую переменную
        
        inArray[i] = inArray[inArray.Length-1-i]; // стартовой переменной присваиваем
        // конечное значение
        inArray[inArray.Length-1-i] = temp;  // а в конечное значение подкладываем начальное
        // значение
    }
}


// Вариант 3: возвращает перетасованный массив

int[] ReverseArray3(int[] inArray) 

{
    for (int i = 0; i < inArray.Length/2; i++) //разворачиваем массив
    {
        // для перетасовывания элементов нам нужна буферная (временная) переменная
        int temp = inArray[i]; // в нее мы кладем условно стартовую переменную
        
        inArray[i] = inArray[inArray.Length-1-i]; // стартовой переменной присваиваем
        // конечное значение
        inArray[inArray.Length-1-i] = temp;  // а в конечное значение подкладываем 
        // начальное значение
    }
    return inArray;
}