// Задача: напишите программу, которая выводит все натуральные числа от 1 до n без циклов, с 
// использованием рекурсии

using static System.Console;
Clear();
Write("Введите число >1: ");
int number = int.Parse(ReadLine()!);
string numbersStr = GetNumbers(number);



WriteLine(numbersStr);
GetNumbers1(number);

string GetNumbers(int n) // так, как нам нужно вывести числа от 1 до n,
// создадим метод, который собирает строку назовем GetNumbers, передадим в него
// число n
// Чтобы была это рекурсия, надо чтоб внутри метода было обращение к названию и самое
// главное продумать выход из рекурсии
{
    if (n == 1) return n.ToString(); // завершили рекурсию. 
    else return GetNumbers(n - 1) + " " + n; // вызываем нашу рекурсию с n-1 и при этом напечатаем
    // перед самим n
    // Словами: изначально в памяти печатает " "+n, заходит на 1 меньше, сравнивает
    // стало равно 1 или нет, тогда он опять печатает " "+n на 1 меньше, и опять заходит
    // в метод на 1 меньше. И таким образом он печатает до тех пор, пока не будет равен 1.
    // Как только сравняется с 1, и в обратном порядке отрабатывает свой выход
    // n.ToString() - преобразование чего угодно в строку
}

void GetNumbers1(int n)
{
    if (n == 1) Write(n);
    else
    {

        GetNumbers1(n - 1);
        Write(" " + n);
    }
}
