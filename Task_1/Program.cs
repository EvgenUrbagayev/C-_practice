//using static System.Console;

Console.Clear(); // очистка консоли
Console.Write("Введите число:  "); // Оператор Write позволяет выводить что-либо в консоль
int num1 = Convert.ToInt32(Console.ReadLine()); // Все, что мы положим в скобки переведи в число и положи в переменную num1 (преобразование строки в число)
int num2 = int.Parse(Console.ReadLine()); // То же самое, что и в предыдущей строке. Другой метод
int sqr1 = num1 * num1; // Новая переменная типа int
int sqr2 = Convert.ToInt32(Math.Pow(num2, 2)); // Результат Math.Pow(num2, 2) будет double, поэтому обязательно Convert, чтобы получить int
Console.WriteLine($"Квадрат числа {num1} = {sqr1}"); // Выводим строку. $ - для красивого вывода, чтобы в строку подсунуть переменные
Console.WriteLine($"Квадрат числа {num2} = {sqr2}");
