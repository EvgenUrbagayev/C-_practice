using static System.Console;

Clear();
//Write("Введите число:  ");
int number = new Random().Next(100, 999+1); // генерируем число в указанном диапазоне
WriteLine(number);  // выводим число в консоль
int num = number / 100;  // забираем старший разряд
int num1 = number % 10;  // забираем младший разряд

WriteLine($"{num}{num1}");
